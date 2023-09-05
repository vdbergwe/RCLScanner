using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using Ghostscript.NET.Rasterizer;
using iTextSharp.text;
using iTextSharp.text.pdf;
using RCLScanner.Properties;
using WIA;
using System.Net.NetworkInformation;
using System.Linq;
using System.Diagnostics;
using System.Collections;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net;
using iTextSharp.text.pdf.parser;
using System.Windows.Markup;
using static System.Data.Entity.Infrastructure.Design.Executor;
using System.Net.Sockets;
using System.Security.Principal;
using System.Security.Policy;
using System.Collections.Generic;

namespace RCLScanner
{
    public partial class frmMain : Form
    {
        string url = "https://rclmlsdash01.tsb.co.za/Fetch/Get_GlobalConfig?System=TSH";
        //string url = "https://localhost:44361/Fetch/Get_GlobalConfig?System=TSH";
        string FileCheckUrl = "https://rclmlsdash01.tsb.co.za/Fetch/Get_GlobalConfig?System=TSH";
        string SelectedFile;
        string SelectedButton;
        string ScanDirectory;
        string WorkDirectory;
        string PendingDirectory;
        string UploadDirectory;
        string HistoryDirectory;
        string ReplDirectory;
        string OnlineHistoryDirectory;
        string Username;
        string Password;
        int Width = 0;
        int Height = 0;
        int Resolution = 0;
        int FilesInHistory = 0;
        int FilesChecked = 0;
        bool errorFlag = false;
        bool flash = false;       

        DialogResult result;

        // Create an empty variable to store the scanner instance
        DeviceInfo SelectedScanner = null;

        // Create a new Ping object
        Ping ping = new Ping();

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\LocalDB.mdf;Integrated Security=True;Connect Timeout=30";

        private void LoadFiles()
        {
            string directoryPath = ScanDirectory;
            string[] fileNames = Directory.GetFiles(directoryPath);

            ButtonContainer.Controls.Clear();

            Button btnRefresh1 = btnRefresh;
            btnRefresh1.Text = "REFRESH";
            btnRefresh1.Location = new System.Drawing.Point(45, 360);
            btnRefresh1.Visible = true;
            ButtonContainer.Controls.Add(btnRefresh1);

            foreach (var file in fileNames)
            {
                if (file.Substring(file.Length - 4) == ".pdf")
                {
                    // Create a new button
                    Button btnFile = new Button();
                    Button btnViewFile = new Button();
                    Button btnFileDelete = new Button();

                    // Set the button text to the file name
                    btnFile.Text = System.IO.Path.GetFileName(file.ToUpper());
                    btnViewFile.Text = "O";
                    btnFileDelete.Text = "X";
                    btnFile.BackColor = Color.LightGreen;


                    if (btnFile.Text == SelectedButton)
                    {
                        btnFile.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        btnFile.BackColor = Color.DeepSkyBlue;
                    }

                    // Set the button location and size
                    btnFile.Location = new System.Drawing.Point(10, 15 + (30 * (ButtonContainer.Controls.Count / 3)));
                    btnFile.Size = new System.Drawing.Size(150, 25);
                    btnFile.FlatStyle = FlatStyle.Flat;

                    btnViewFile.Location = new System.Drawing.Point(165, 15 + (30 * (ButtonContainer.Controls.Count / 3)));
                    btnViewFile.Size = new System.Drawing.Size(25, 25);
                    btnViewFile.FlatStyle = FlatStyle.Flat;

                    btnFileDelete.Location = new System.Drawing.Point(195, 15 + (30 * (ButtonContainer.Controls.Count / 3)));
                    btnFileDelete.Size = new System.Drawing.Size(25, 25);
                    btnFileDelete.BackColor = Color.Red;
                    btnFileDelete.FlatStyle = FlatStyle.Flat;

                    System.Diagnostics.Process ViewFile;

                    // Add a click event handler for the button
                    btnFile.Click += (sender, e) =>
                    {
                        // Handle button click here
                        SelectedFile = ScanDirectory + "\\" + btnFile.Text.ToString();
                        SelectedButton = btnFile.Text;

                        PDFtoJPEG(SelectedFile);

                        string fileName = (ScanDirectory + "\\" + "Enlarged.jpg").ToString();

                        // Load the full image from a file
                        System.Drawing.Image fullImage = System.Drawing.Image.FromFile(fileName);

                        // Display the enlarged corner of the full image in a PictureBox
                        //DisplayEnlargedCorner(fullImage, 300);
                        RotatePreview(fullImage, 400);

                        fullImage.Dispose();

                        LoadFiles();

                        txtDocNumber.Enabled = true;
                        txtBoxGRNumber.Enabled = true;
                        txtDocNumber.Text = null;
                        cmbDocType.Enabled = true;
                        dtpDate.Enabled = true;
                        btnProcess.Enabled = true;
                        //btnAddPage.Enabled = true;
                        //btnAddPage.Visible = true;
                    };

                    btnViewFile.Click += (sender, e) =>
                    {
                        ViewFile = System.Diagnostics.Process.Start(file);
                    };

                    btnFileDelete.Click += (sender, e) =>
                     {
                         try
                         {
                             picBoxEnlarged.Image = Resources.Waiting400;
                             txtDocNumber.Enabled = false;
                             txtDocNumber.Text = null;
                             cmbDocType.Enabled = false;
                             dtpDate.Enabled = false;
                             btnProcess.Enabled = false;
                             File.Delete(file);
                             LoadFiles();
                         }
                         catch (Exception ex)
                         {
                             MessageBox.Show("The file is currently open, please close and retry action");
                         }

                     };

                    // Add the button to the container
                    ButtonContainer.Controls.Add(btnFile);
                    ButtonContainer.Controls.Add(btnViewFile);
                    ButtonContainer.Controls.Add(btnFileDelete);
                }
            }
        }

        public void KillProcess(int pid)
        {
            Process[] process = Process.GetProcesses();

            foreach (Process prs in process)
            {
                if (prs.Id == pid)
                {
                    prs.Kill();
                    break;
                }
            }
        }

        public frmMain()
        {
            InitializeComponent();
            picBoxRCLLogo.Image = Resources.RCL_Logo_0420232;
            this.Left = 100;
            this.Top = 150;
        }

        private void ImageFlip()
        {
            System.Drawing.Image flipImage = picBoxEnlarged.Image;
            flipImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            picBoxEnlarged.Image = flipImage;
        }

        private void ImageFlipAnti()
        {
            System.Drawing.Image flipImage = picBoxEnlarged.Image;
            flipImage.RotateFlip(RotateFlipType.Rotate90FlipXY);
            picBoxEnlarged.Image = flipImage;
        }

        private void RotatePreview(System.Drawing.Image fullImage, int cornerSize)
        {
            // Calculate the coordinates of the corner of the full image to be displayed
            int cornerX = 0;
            int cornerY = 0;


            if (rbtnTop.Checked && rbtnRight.Checked)
            {
                cornerX = fullImage.Width - cornerSize;
                cornerY = 0;
            }

            if (rbtnBottom.Checked && rbtnLeft.Checked)
            {
                cornerX = 0;
                cornerY = fullImage.Height - cornerSize;
            }

            if (rbtnBottom.Checked && rbtnRight.Checked)
            {
                cornerX = fullImage.Width - cornerSize;
                cornerY = fullImage.Height - cornerSize;
            }

            // Create a new bitmap to hold the enlarged corner image
            Bitmap cornerBitmap = new Bitmap(cornerSize, cornerSize);

            // Create a graphics object for the new bitmap
            Graphics cornerGraphics = Graphics.FromImage(cornerBitmap);

            // Draw the corner of the full image onto the new bitmap
            cornerGraphics.DrawImage(fullImage, new System.Drawing.Rectangle(0, 0, cornerSize, cornerSize),
            new System.Drawing.Rectangle(cornerX, cornerY, cornerSize, cornerSize), GraphicsUnit.Pixel);

            // Display the enlarged corner image in a PictureBox            
            picBoxEnlarged.Image = cornerBitmap;
            picBoxEnlarged.Width = 400;
            picBoxEnlarged.Height = 400;
        }

        private void PDFtoJPEG(string inputFilePath)
        {
            // Open the PDF file using Ghostscript.NET
            using (var rasterizer = new GhostscriptRasterizer())
            {
                rasterizer.Open(inputFilePath);

                // Set the first page to be rendered
                var firstPage = 1;

                // Set the last page to be rendered (use -1 to render all pages)
                var lastPage = 1;

                // Loop through the pages and convert each one to a JPEG image
                for (var i = firstPage; i <= rasterizer.PageCount && (lastPage == -1 || i <= lastPage); i++)
                {
                    // Get the image for the current page
                    using (var image = rasterizer.GetPage(96, i))
                    {
                        // Save the image to a file
                        var fileName = ScanDirectory + "\\" + "enlarged.jpg";
                        if (File.Exists(fileName))
                        {
                            picBoxEnlarged.Image = null;
                            File.Delete(fileName);
                        }
                        image.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                }
            }
        }

        private void Batch_Scan()
        {
            string[] fileNames = Directory.GetFiles(WorkDirectory);

            // Convert the saved image to PDF format using iTextSharp      
            using (var stream = new FileStream(ScanDirectory + "\\" + DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss") + ".pdf", FileMode.Create))
            {

                var document = new Document(PageSize.A4, 0, 0, 0, 0);
                var writer = PdfWriter.GetInstance(document, stream);
                if (rbtnLandscape.Checked && rbtnA4.Checked)
                {
                    document.SetPageSize(PageSize.A4.Rotate());
                }

                if (rbtnA3.Checked)
                {
                    document = new Document(PageSize.A3, 0, 0, 0, 0);
                    if (rbtnLandscape.Checked)
                    {
                        document.SetPageSize(PageSize.A3.Rotate());
                    }
                }
                document.Open();
                foreach (var file in fileNames)
                {
                    var image = iTextSharp.text.Image.GetInstance(file);
                    if (rbtnA4.Checked)
                    {
                        if (rbtnLandscape.Checked)
                        {
                            image.ScaleToFit(PageSize.A4.Rotate().Width, PageSize.A4.Rotate().Height);
                        }
                        else
                        {
                            image.ScaleToFit(PageSize.A4.Width, PageSize.A4.Height);
                        }
                    }
                    if (rbtnA3.Checked)
                    {
                        image.ScaleToFit(PageSize.A3.Width, PageSize.A3.Height);
                    }

                    document.Add(image);
                    document.NewPage();
                    File.Delete(file);
                }
                document.Close();
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {

            bool secondcall = false;
            string[] TotalPages = Directory.GetFiles(WorkDirectory);
            int pagecount = 0;

            // Create a DeviceManager instance
            var deviceManager = new DeviceManager();

            for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
            {
                cmbBoxScannerID.SelectedIndex = cmbBoxScanners.SelectedIndex;
                if (deviceManager.DeviceInfos[i].DeviceID == cmbBoxScannerID.Text)
                {
                    SelectedScanner = deviceManager.DeviceInfos[i];
                }
            }

            if ((SelectedScanner == null) || (deviceManager.DeviceInfos.Count == 0))
            {
                btnScan.Enabled = false;
                btnScan.BackColor = Color.Orange;
                errorFlag = true;
                StatusLabel.Text = "NO SCANNER CONNECTED";
            }
            else
            {
                // Connect to the first available scanner
                var device = SelectedScanner.Connect();

                // Select the scanner
                var scannerItem = device.Items[1];
                var scanerItem = (Item)device.Items[1];

                //Set to Feeder
                if (chkBoxUseADF.Checked == true)
                {
                    device.Properties["Document Handling Select"].set_Value(1);
                }

                if (rbtnA4.Checked && rbtn150.Checked && rbtnPortrait.Checked)
                {
                    Width = 1240;
                    Height = 1754;
                    Resolution = 150;
                }

                if (rbtnA4.Checked && rbtn150.Checked && rbtnLandscape.Checked)
                {
                    Width = 1754;
                    Height = 1240;
                    Resolution = 150;
                }

                if (rbtnA4.Checked && rbtn300.Checked && rbtnPortrait.Checked)
                {
                    Width = 2480;
                    Height = 3508;
                    Resolution = 300;
                }

                if (rbtnA4.Checked && rbtn300.Checked && rbtnLandscape.Checked)
                {
                    Width = 3508;
                    Height = 2480;
                    Resolution = 300;
                }

                if (rbtnA3.Checked && rbtn150.Checked && rbtnPortrait.Checked)
                {
                    Width = 1754;
                    Height = 2480;
                    Resolution = 150;
                }

                if (rbtnA3.Checked && rbtn150.Checked && rbtnLandscape.Checked)
                {
                    Width = 2480;
                    Height = 1754;
                    Resolution = 150;
                }

                if (rbtnA3.Checked && rbtn300.Checked && rbtnPortrait.Checked)
                {
                    Width = 3508;
                    Height = 4961;
                    Resolution = 300;
                }

                if (rbtnA3.Checked && rbtn300.Checked && rbtnLandscape.Checked)
                {
                    Width = 4961;
                    Height = 3508;
                    Resolution = 300;
                }

                scanerItem.Properties["6146"].set_Value(2); // Color
                scanerItem.Properties["6147"].set_Value(Resolution); // Resolution
                scanerItem.Properties["6148"].set_Value(Resolution); // Resolution
                scanerItem.Properties["6151"].set_Value(Width); // Width
                scanerItem.Properties["6152"].set_Value(Height); // Height

                result = DialogResult.Yes;

                try
                {
                    while (result == DialogResult.Yes)
                    {
                        //Get image from scanner
                        var imageFile = (ImageFile)scannerItem.Transfer(FormatID.wiaFormatJPEG);

                        //path for temp images with unique names
                        var path = WorkDirectory + "\\" + DateTime.Now.ToString("yy-MM-dd HH-mm-ss-s-ff") + ".jpg";

                        //save scanned image
                        imageFile.SaveFile(path);
                        pagecount++;
                        if (chkBoxUseADF.Checked == false)
                        {
                            result = MessageBox.Show("Add Supporting Document?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        }
                    }
                }
                catch (Exception ex)
                {
                    if (chkBoxUseADF.Checked)
                    {

                        result = MessageBox.Show("Confirm batch complete? (load paper in ADF and click NO to continue scanning)", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.No)
                        {
                            btnScan_Click(sender, e);
                            secondcall = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please verify that the scanner is connected/powered and paper is loaded");
                    }
                }
                if (TotalPages.Count() > 0 || pagecount > 0 && secondcall == false)
                {
                    Batch_Scan();
                    LoadFiles();
                }
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuSettings_Click(object sender, EventArgs e)
        {
            var settingsForm = new Settings();
            settingsForm.Show();
            this.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateStatusBar()
        {
            DateLabel.Text = DateTime.Now.ToString("dd=MM-yyyy HH:mm:ss");
        }

        private void frmMain_LoadAsync(object sender, EventArgs e)
        {

            cmbDocType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxScanners.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxScanners.Items.Clear();
            cmbBoxScannerID.Items.Clear();
            cmbBoxScannerID.Visible = false;
            cmbDocType.SelectedItem = "POD";
            picBoxEnlarged.Image = Resources.Waiting400;
            btnProcess.Enabled = false;
            txtDocNumber.Enabled = false;
            txtBoxGRNumber.Enabled = false;
            cmbDocType.Enabled = false;
            dtpDate.Enabled = false;           

            try
            {
                WebRequest request = HttpWebRequest.Create(url);

                WebResponse response = request.GetResponse();

                StreamReader jsonreader = new StreamReader(response.GetResponseStream());

                string jsonResponse = jsonreader.ReadToEnd();

                // Deserialize the JSON into an object
                GlobalData data = JsonConvert.DeserializeObject<GlobalData>(jsonResponse);

                if (Directory.Exists(data.MainFolder))
                {
                    Console.WriteLine("The root path already exists.");
                }
                else
                {
                    Directory.CreateDirectory(data.MainFolder);
                }

                if (Directory.Exists(data.ScanFolder))
                {
                    Console.WriteLine("The scan path exists already.");
                }
                else
                {
                    Directory.CreateDirectory(data.ScanFolder);
                }
                if (Directory.Exists(data.HistoryFolder))
                {
                    Console.WriteLine("The history path exists already.");
                }
                else
                {
                    Directory.CreateDirectory(data.HistoryFolder);
                }
                if (Directory.Exists(data.WorkFolder))
                {
                    Console.WriteLine("The work path exists already.");
                }
                else
                {
                    Directory.CreateDirectory(data.WorkFolder);
                }
                if (Directory.Exists(data.PendingFolder))
                {
                    Console.WriteLine("The pending path exists already.");
                }
                else
                {
                    Directory.CreateDirectory(data.PendingFolder);
                }

                ScanDirectory = data.ScanFolder;
                WorkDirectory = data.WorkFolder;
                PendingDirectory = data.PendingFolder;
                UploadDirectory = data.RepositoryPath;
                HistoryDirectory = data.HistoryFolder;
                ReplDirectory = data.ReplDirectory;
                OnlineHistoryDirectory = data.OnlineHistoryDirectory;
                Username = data.RepositoryUserName; 
                Password = data.RepositoryPassword;

            } 
            catch (Exception ex)
            {
                ScanDirectory = "C:\\RCLScanner\\Scans";
                WorkDirectory = "C:\\RCLScanner\\Work";
                PendingDirectory = "C:\\RCLScanner\\Pending";
                UploadDirectory = "\\\\SRSM083A.tsb.co.za\\14_PODCentral\\Consolidation\\TSH\\021\\Holding";            
                ReplDirectory = "\\\\SRSM083A.tsb.co.za\\14_PODCentral\\Consolidation\\TSH\\021\\ReplPOD";
                HistoryDirectory = "C:\\RCLScanner\\History";
                OnlineHistoryDirectory = "\\\\rclmlsdash01.tsb.co.za\\OnlineHistory\\POD";
                Username = "srvacc_sdashintegration";
                Password = "Th1s1s@serv1ce@ccount@Sdash";

                if (Directory.Exists("C:\\RCLScanner"))
                {
                    Console.WriteLine("The root path already exists.");
                }
                else
                {
                    Directory.CreateDirectory("C:\\RCLScanner");
                }
                if (Directory.Exists(ScanDirectory))
                {
                    Console.WriteLine("The scan path exists already.");
                }
                else
                {
                    Directory.CreateDirectory(ScanDirectory);
                }
                if (Directory.Exists(HistoryDirectory))
                {
                    Console.WriteLine("The history path exists already.");
                }
                else
                {
                    Directory.CreateDirectory(HistoryDirectory);
                }
                if (Directory.Exists(WorkDirectory))
                {
                    Console.WriteLine("The work path exists already.");
                }
                else
                {
                    Directory.CreateDirectory(WorkDirectory);
                }
                if (Directory.Exists(PendingDirectory))
                {
                    Console.WriteLine("The pending path exists already.");
                }
                else
                {
                    Directory.CreateDirectory(PendingDirectory);
                }
            }
            LoadFiles();

            // Create a DeviceManager instance
            var deviceManager = new DeviceManager();

            // Loop through the list of devices to choose the first available
            for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
            {
                // Skip the device if it's not a scanner
                if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
                {
                    continue;
                }

                string DeviceName = deviceManager.DeviceInfos[i].Properties["Manufacturer"].get_Value() + " " + deviceManager.DeviceInfos[i].Properties["Description"].get_Value();

                cmbBoxScanners.Items.Add(DeviceName);
                cmbBoxScannerID.Items.Add(deviceManager.DeviceInfos[i].DeviceID.ToString());

            }

            if (cmbBoxScanners.Items.Count == 0)
            {
                btnScan.Enabled = false;
                btnScan.BackColor = Color.Orange;
                //errorFlag = true;
                StatusLabel.Text = "NO SCANNER CONNECTED";
            }
            else
            {
                cmbBoxScanners.SelectedIndex = 0;
                btnScan.Enabled = true;
                btnScan.BackColor = Color.DeepSkyBlue;
                errorFlag = false;
                StatusLabel.Text = "";
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SelectedButton = null;
            frmMain_LoadAsync(sender, e);
            picBoxEnlarged.Width = 400;
            picBoxEnlarged.Height = 400;
            btnAddPage.Enabled = false;
            btnAddPage.Visible = false;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            txtDocNumber.Enabled = false;
            txtBoxGRNumber.Enabled = false;
            cmbDocType.Enabled = false;
            dtpDate.Enabled = false;
            btnProcess.Enabled = false;
            string padding = "";
            FilesChecked = 0;
            for (int i = 1; i <= (10 - txtDocNumber.Text.Length); i++)
            {
                padding = padding + "0";
            }

            //"TSH021_" + cmbDocType.Text + "_"
            string newfilename = padding + txtDocNumber.Text + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".pdf";
            //Rename Selected File
            File.Move(SelectedFile, ScanDirectory + "\\" + newfilename);

            try
            {
                var MyDataInstance = new DataPublish();

                string Ip = "";

                try
                {
                    string externalIpString = new WebClient().DownloadString("http://icanhazip.com").Replace("\\r\\n", "").Replace("\\n", "").Trim();
                    var Ip1 = IPAddress.Parse(externalIpString);
                    Ip = Ip1.ToString();
                    Console.WriteLine(Ip1.ToString());
                }
                catch
                {
                    var host = Dns.GetHostEntry(Dns.GetHostName());
                    foreach (var ip2 in host.AddressList)
                    {
                        if (ip2.AddressFamily == AddressFamily.InterNetwork)
                        {
                            Ip = ip2.ToString();
                        }
                    }
                }

                if (cmbDocType.SelectedItem.ToString() == "REPL_POD") 
                {
                    ImpersonationHelper.Impersonate("tsb.co.za", Username, Password, ReplDirectory, fileSharePath =>
                    {
                        //Upload to Online Repository
                        File.Copy(ScanDirectory + "\\" + newfilename, ReplDirectory + "\\" + newfilename);
                    });
                    //Move file to History location
                    File.Move(ScanDirectory + "\\" + newfilename, HistoryDirectory + "\\" + newfilename);
                    MyDataInstance.Publish(padding + txtDocNumber.Text, txtBoxGRNumber.Text, dtpDate.Value, System.Environment.MachineName, System.Environment.UserName, Ip, newfilename, cmbDocType.SelectedItem.ToString());

                }
                else
                {
                    ImpersonationHelper.Impersonate("tsb.co.za", Username, Password, UploadDirectory, fileSharePath =>
                    {
                        //Upload to Online Repository
                        File.Copy(ScanDirectory + "\\" + newfilename, UploadDirectory + "\\" + newfilename);
                    });
                    //Move file to History location
                    File.Move(ScanDirectory + "\\" + newfilename, HistoryDirectory + "\\" + newfilename);
                    MyDataInstance.Publish(padding + txtDocNumber.Text, txtBoxGRNumber.Text, dtpDate.Value, System.Environment.MachineName, System.Environment.UserName, Ip, newfilename, cmbDocType.SelectedItem.ToString());
                }


                LoadFiles();
                picBoxEnlarged.Image = Resources.Completed400;
                txtDocNumber.Text = null;
                txtBoxGRNumber.Text = null;
            }
            catch
            {
                newfilename = newfilename.Substring(0, 25);
                File.Move(ScanDirectory + "\\" + newfilename + ".pdf", PendingDirectory + "\\" + cmbDocType.SelectedItem.ToString() + "_" + newfilename + "_" + txtBoxGRNumber.Text + "_" + dtpDate.Value.ToString("yyyyMMddHHmmss") + ".pdf");
                //MessageBox.Show("Cant Connect");
                picBoxEnlarged.Image = Resources.Waiting400;
                txtDocNumber.Text = null;
                
                LoadFiles();
            }
            UpdateStatusBar();

        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog UploadFile = new OpenFileDialog();
            UploadFile.Filter = "All Files (*.*)|*.*";
            UploadFile.FilterIndex = 1;
            UploadFile.Multiselect = false;
            string sFileName = null;
            if (UploadFile.ShowDialog() == DialogResult.OK)
            {
                sFileName = UploadFile.FileName;
                //string[] arrAllFiles = UploadFile.FileNames; //used when Multiselect = true           
            }
            if (sFileName == null)
            {
                StatusLabel.Text = "No file selected for upload";
            }
            else
            {
                File.Move(sFileName, ScanDirectory + "\\" + DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss") + ".pdf");
            }
            LoadFiles();
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {

            DateLabel.Text = DateTime.Now.ToString("dd MMMM yyyy HH:mm:ss");

            if (errorFlag && flash)
            {
                MainStatusStrip.BackColor = Color.Red;
                flash = false;
            }
            else
            {
                if (errorFlag)
                {
                    MainStatusStrip.BackColor = default;
                    flash = true;
                }
            }
        }

        private void OnlineTimer_Tick(object sender, EventArgs e)
        {
            if (errorFlag == false)
            {
                try
                {
                    PingReply reply = ping.Send("SRSM083A.tsb.co.za");

                    if (reply.Status == IPStatus.Success)
                    {
                        StatusLabel.Text = "Server is online.";
                        MainStatusStrip.BackColor = Color.PaleGreen;

                        try
                        {
                            string[] fileNames = Directory.GetFiles(PendingDirectory);

                            foreach (var file in fileNames)
                            {
                                var MyDataInstance = new DataPublish();
                                var FileName = System.IO.Path.GetFileName(file.ToUpper());
                                var DocType = "";
                                var DocTypeUploadDirectory = UploadDirectory;

                                if (FileName.Substring(0, 8) == "REPL_POD") 
                                {
                                    DocType = FileName.Substring(0,8);
                                    FileName = FileName.Remove(0, 9);
                                    DocTypeUploadDirectory = ReplDirectory;
                                }
                                else
                                {
                                    DocType = FileName.Substring(0, 3);
                                    FileName = FileName.Remove(0, 4);
                                }
                                Console.WriteLine(DocTypeUploadDirectory + " - " + Username + " - " + Password);


                                var PODNumber = FileName.Substring(0, 10);
                                var OriginalFilename = FileName.Substring(0, 25);
                                var TempString = FileName.Remove(0, 26);
                                var GRNumber = TempString.Substring(0, TempString.Length - 19);
                                var GRDate = TempString.Substring(GRNumber.Length + 1, 8);
                                var Year = GRDate.Substring(0,4);
                                var Month = GRDate.Substring(4, 2);
                                var Day = GRDate.Substring(6, 2);

                                var GRDateP = DateTime.Parse(Year + "/" + Month + "/" + Day);

                                string Ip = "";

                                try
                                {
                                    string externalIpString = new WebClient().DownloadString("http://icanhazip.com").Replace("\\r\\n", "").Replace("\\n", "").Trim();
                                    var Ip1 = IPAddress.Parse(externalIpString);
                                    Ip = Ip1.ToString();
                                    Console.WriteLine(Ip1.ToString());
                                }
                                catch {
                                    var host = Dns.GetHostEntry(Dns.GetHostName());
                                    foreach (var ip2 in host.AddressList)
                                    {
                                        if (ip2.AddressFamily == AddressFamily.InterNetwork)
                                        {
                                            Ip = ip2.ToString();
                                        }
                                    }
                                }

                                try
                                {
                                    ImpersonationHelper.Impersonate("tsb.co.za", Username, Password, DocTypeUploadDirectory, fileSharePath =>
                                   {
                                        //Upload to Online Repository
                                        File.Copy(file, DocTypeUploadDirectory + "\\" + OriginalFilename + ".pdf");
                                   });
            
                                    //Move file to Archive location
                                    File.Move(file, HistoryDirectory + "\\" + OriginalFilename + ".pdf");
                                    MyDataInstance.Publish(PODNumber, GRNumber, GRDateP, System.Environment.MachineName, System.Environment.UserName, Ip, OriginalFilename + ".pdf", DocType);
                                }
                                catch 
                                {

                                    try
                                    {
                                        bool isConnected = NetworkShareConnector.ConnectToNetworkShare(DocTypeUploadDirectory, "tsb.co.za\\" + Username, Password);
                                        if (isConnected)
                                        {                                           
                                            File.Copy(file, DocTypeUploadDirectory + "\\" + OriginalFilename + ".pdf");
                                            File.Move(file, HistoryDirectory + "\\" + OriginalFilename + ".pdf");
                                            MyDataInstance.Publish(PODNumber, GRNumber, GRDateP, System.Environment.MachineName, System.Environment.UserName, Ip, OriginalFilename + ".pdf", DocType);
                                            Console.WriteLine("File uploaded successfully.");

                                            NetworkShareConnector.DisconnectFromNetworkShare(DocTypeUploadDirectory);
                                        }

                                        Console.ReadLine();
                                        
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("Error uploading file: " + ex.Message);
                                        Console.WriteLine(DocTypeUploadDirectory);
                                    }
                                }                               
                            }
                        }
                        catch
                        { 
                            //MessageBox.Show(ex.ToString() + " - " + Username + " - " + Password);
                        }

                        try
                        {
                            WebRequest request = HttpWebRequest.Create(FileCheckUrl);

                            using (WebResponse response = request.GetResponse())
                            {
                                using (StreamReader jsonreader = new StreamReader(response.GetResponseStream()))
                                {
                                    string jsonResponse = jsonreader.ReadToEnd();
                                    
                                    List<FileCheckClass> FileList = JsonConvert.DeserializeObject<List<FileCheckClass>>(jsonResponse);
                                   
                                    foreach (FileCheckClass CheckFile in FileList)
                                    {                                       
                                        if (System.IO.File.Exists(HistoryDirectory + "\\" + CheckFile.Filename.ToUpper()))
                                        {
                                            Console.WriteLine("File in OnlineHistory Directory: " + CheckFile.Filename.ToUpper().ToString());
                                        }
                                        else
                                        {                                            
                                            try
                                            {
                                                ImpersonationHelper.Impersonate("tsb.co.za", Username, Password, OnlineHistoryDirectory, fileSharePath =>
                                                {
                                                     File.Copy(HistoryDirectory + "\\" + CheckFile.Filename.ToUpper(), OnlineHistoryDirectory + "\\" + CheckFile.Filename.ToUpper());
                                                });
                                            }
                                            catch 
                                            {
                                                try
                                                {
                                                    bool isConnected = NetworkShareConnector.ConnectToNetworkShare(OnlineHistoryDirectory, "tsb.co.za\\" + Username, Password);
                                                    if (isConnected)
                                                    {
                                                        File.Copy(HistoryDirectory + "\\" + CheckFile.Filename.ToUpper(), OnlineHistoryDirectory + "\\" + CheckFile.Filename.ToUpper());

                                                        NetworkShareConnector.DisconnectFromNetworkShare(OnlineHistoryDirectory);
                                                    }
                                                    Console.ReadLine();
                                                }
                                                catch
                                                {
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        catch 
                        { 

                        }                       

                    }
                    else
                    {
                        StatusLabel.Text = "Server is offline.";
                    }
                }
                catch
                {
                    StatusLabel.Text = "Unable to resolve: SRSM083A.TSB.CO.ZA";
                }
            }    
            

        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            ImageFlip();
        }

        private void btnRotateAnti_Click(object sender, EventArgs e)
        {
            ImageFlipAnti();
        }

        private void rbtnA3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnA3.Checked == true)
            {
                rbtnPortrait.Checked = true;
                rbtnLandscape.Enabled = false;
            }
            else
            {
                rbtnLandscape.Enabled = true;
            }
        }

        private void rbtnTop_CheckedChanged(object sender, EventArgs e)
        {
            string fileName = (ScanDirectory + "\\" + "Enlarged.jpg").ToString();

            // Load the full image from a file
            System.Drawing.Image fullImage = System.Drawing.Image.FromFile(fileName);
            RotatePreview(fullImage, 400);
        }

        private void btnAddPage_Click(object sender, EventArgs e)
        {           
            btnScan_Click(sender, e);
        }

        private void grpBoxDocInfo_Enter(object sender, EventArgs e)
        {

        }
    }

    public class GlobalData
    {
        public string RepositoryPath { get; set; }
        public string RepositoryUserName { get; set; }
        public string RepositoryPassword { get; set; }
        public string RetryFreq { get; set; }
        public string MainFolder { get; set; }
        public string ScanFolder { get; set; }
        public string WorkFolder { get; set; }
        public string PendingFolder { get; set; }
        public string HistoryFolder { get; set; }
        public string Validation { get; set; }
        public string ReplDirectory { get; set; }
        public string OnlineHistoryDirectory { get; set; }
    }

    public class FileCheckClass
    {
        public string Filename { get; set; }
    }

    }