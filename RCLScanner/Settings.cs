using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA;

namespace RCLScanner
{
    public partial class Settings : Form
    {

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\RCLScanner\LocalDB.mdf;Integrated Security=True";

        public Settings()
        {
            InitializeComponent();
            txtBoxWorkstationID.Text = System.Environment.MachineName;
           
            // SQL query to select data from the table
            string query = "SELECT WorkstationID,ScanDirectory,UploadDirectory,HistoryDirectory FROM AppSettings WHERE Id = 1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Create a command object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Execute the query and get a data reader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Loop through the rows in the data reader and display the values in a message box
                        while (reader.Read())
                        {
                            string WorkstationID = reader.GetString(0);
                            string ScanDirectory = reader.GetString(1);
                            string UploadDirectory = reader.GetString(2);
                            string HistoryDirectory = reader.GetString(3);

                            txtBoxWorkstationID.Text = WorkstationID;
                            txtBoxScanDirectory.Text = ScanDirectory;
                            txtBoxUploadDirectory.Text = UploadDirectory;
                            txtBoxHistoryDirectory.Text = HistoryDirectory;

                        }
                    }
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();            
        }

        private void newScanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var MainForm = new frmMain();
            MainForm.Visible = true;
            MainForm.Left = 100;
            MainForm.Top = 150;
            Close();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            this.Left = 100;
            this.Top = 150;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            // SQL query to insert a new row into the table
            string query = "UPDATE AppSettings SET WorkstationID = @WorkstationID, ScanDirectory = @ScanDirectory, UploadDirectory = @UploadDirectory, HistoryDirectory = @HistoryDirectory WHERE Id = 1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Create a command object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Set parameter values for the query                    
                    command.Parameters.AddWithValue("@WorkstationID", txtBoxWorkstationID.Text);
                    command.Parameters.AddWithValue("@ScanDirectory", txtBoxScanDirectory.Text);
                    command.Parameters.AddWithValue("@UploadDirectory", txtBoxUploadDirectory.Text);
                    command.Parameters.AddWithValue("@HistoryDirectory", txtBoxHistoryDirectory.Text);

                    // Execute the query
                    int result = command.ExecuteNonQuery();

                    // Show the number of rows affected in a message box
                    MessageBox.Show($"{result} rows inserted.");
                }
            }
        }

        private void btnFindScanners_Click(object sender, EventArgs e)
        {
            // Create an instance of the WIA Common Dialog class
            var dialog = new WIA.CommonDialog();

            // Create a DeviceManager instance
            var deviceManager = new DeviceManager();

            //// Create an empty variable to store the scanner instance
            //DeviceInfo firstScannerAvailable = null;

            // Loop through the list of devices to choose the first available
            for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
            {
                // Skip the device if it's not a scanner
                if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
                {
                    continue;
                }

                cmbScanner.Items.Add(deviceManager.DeviceInfos[i].DeviceID);
                //firstScannerAvailable = deviceManager.DeviceInfos[i];

                break;
            }
        }
    }
}
