using System;
using System.IO;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Security.Principal;
using System.Windows.Forms;
using Microsoft.Win32.SafeHandles;


namespace RCLScanner
{

    public class NetworkShareConnector
    {
        public static bool ConnectToNetworkShare(string sharePath, string username, string password)
        {
            try
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();

                startInfo.FileName = "net";
                startInfo.Arguments = $"use {sharePath} /user:{username} {password}";
                startInfo.CreateNoWindow = true;
                startInfo.RedirectStandardOutput = true;
                startInfo.RedirectStandardError = true;
                startInfo.UseShellExecute = false;

                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();

                int exitCode = process.ExitCode;
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                if (exitCode == 0)
                {
                    Console.WriteLine(startInfo.Arguments);
                    Console.WriteLine("Connected to network share: " + sharePath);
                    return true;
                }
                else
                {
                    Console.WriteLine(startInfo.Arguments);
                    Console.WriteLine("Failed to connect to network share: " + sharePath);
                    Console.WriteLine("Error: " + error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting to network share: " + ex.Message);
                return false;
            }
        }

        public static void DisconnectFromNetworkShare(string sharePath)
        {
            try
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();

                startInfo.FileName = "net";
                startInfo.Arguments = $"use {sharePath} /delete";
                startInfo.CreateNoWindow = true;
                startInfo.RedirectStandardOutput = true;
                startInfo.RedirectStandardError = true;
                startInfo.UseShellExecute = false;

                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();

                int exitCode = process.ExitCode;
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();

                if (exitCode == 0)
                {
                    Console.WriteLine("Disconnected from network share: " + sharePath);
                }
                else
                {
                    Console.WriteLine("Failed to disconnect from network share: " + sharePath);
                    Console.WriteLine("Error: " + error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error disconnecting from network share: " + ex.Message);
            }
        }
    }




    public sealed class SafeTokenHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        private SafeTokenHandle()
            : base(true)
        {
        }

        [DllImport("kernel32.dll")]
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        [SuppressUnmanagedCodeSecurity]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool CloseHandle(IntPtr handle);

        protected override bool ReleaseHandle()
        {
            return CloseHandle(handle);
        }
    }

    public class ImpersonationHelper
    {
        [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern bool LogonUser(String lpszUsername, String lpszDomain, String lpszPassword,
        int dwLogonType, int dwLogonProvider, out SafeTokenHandle phToken);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        private extern static bool CloseHandle(IntPtr handle);

        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        public static void Impersonate(string domainName, string userName, string userPassword, string Path, Action<string> actionToExecute)
        {
            SafeTokenHandle safeTokenHandle;
            try
            {

                const int LOGON32_PROVIDER_DEFAULT = 0;
                //This parameter causes LogonUser to create a primary token.
                const int LOGON32_LOGON_INTERACTIVE = 2;

                // Call LogonUser to obtain a handle to an access token.
                bool returnValue = LogonUser(userName, domainName, userPassword,
                    LOGON32_LOGON_INTERACTIVE, LOGON32_PROVIDER_DEFAULT,
                    out safeTokenHandle);
                //Facade.Instance.Trace("LogonUser called.");

                if (returnValue == false)
                {
                    int ret = Marshal.GetLastWin32Error();
                    //Facade.Instance.Trace($"LogonUser failed with error code : {ret}");

                    throw new System.ComponentModel.Win32Exception(ret);
                }

                using (safeTokenHandle)
                {
                    //Facade.Instance.Trace($"Value of Windows NT token: {safeTokenHandle}");
                    //Facade.Instance.Trace($"Before impersonation: {WindowsIdentity.GetCurrent().Name}");

                    // Use the token handle returned by LogonUser.
                    using (WindowsIdentity newId = new WindowsIdentity(safeTokenHandle.DangerousGetHandle()))
                    {
                        using (WindowsImpersonationContext impersonatedUser = newId.Impersonate())
                        {
                            //Facade.Instance.Trace($"After impersonation: {WindowsIdentity.GetCurrent().Name}");
                            //Facade.Instance.Trace("Start executing an action");

                            actionToExecute.Invoke(Path);

                            //Facade.Instance.Trace("Finished executing an action");
                        }
                    }
                    //Facade.Instance.Trace($"After closing the context: {WindowsIdentity.GetCurrent().Name}");
                }

            }
            catch (Exception ex)
            {
                //Facade.Instance.Trace("Oh no! Impersonate method failed.");
                //ex.HandleException();
                //On purpose: we want to notify a caller about the issue /Pavel Kovalev 9/16/2016 2:15:23 PM)/
                throw ex;
            }
        }
    }
}