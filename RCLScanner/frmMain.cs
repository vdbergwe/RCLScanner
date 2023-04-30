using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Xml.Linq;
using Ghostscript.NET.Rasterizer;
using iTextSharp.text;
using iTextSharp.text.pdf;
using WIA;

namespace RCLScanner
{

    public partial class frmMain : Form
    {
        string SelectedFile;

        private void LoadFiles()
        {
            string directoryPath = @"C:\Temp";
            string[] fileNames = Directory.GetFiles(directoryPath);

            ButtonContainer.Controls.Clear();

            Button btnRefresh1 = btnRefresh;
            btnRefresh1.Text = "REFRESH";
            btnRefresh1.Location = new System.Drawing.Point(45,360);
            btnRefresh1.Visible = true;
            ButtonContainer.Controls.Add(btnRefresh1);

            foreach (var file in fileNames)
            {
                if (file.Substring(file.Length - 4) == ".pdf")
                {
                    // Create a new button
                    Button btnFile = new Button();
                    Button btnFileDelete = new Button();

                    // Set the button text to the file name
                    btnFile.Text = Path.GetFileName(file.ToUpper());
                    btnFileDelete.Text = "X";

                    // Set the button location and size
                    btnFile.Location = new System.Drawing.Point(10, 15 + (25 * (ButtonContainer.Controls.Count/2)));
                    btnFile.Size = new System.Drawing.Size(150, 25);
                    btnFile.BackColor = Color.LightGray;

                    btnFileDelete.Location = new System.Drawing.Point(165, 15 + (25 * (ButtonContainer.Controls.Count/2)));
                    btnFileDelete.Size = new System.Drawing.Size(40, 25);
                    btnFileDelete.BackColor = Color.Red;


                    // Add a click event handler for the button
                    btnFile.Click += (sender, e) =>
                    {
                        // Handle button click here
                       SelectedFile = "C:\\temp\\" + btnFile.Text.ToString();
                       
                        PDFtoJPEG(SelectedFile);

                        string fileName = (@"c:\temp\output.jpg").ToString();

                        // Load the full image from a file
                        System.Drawing.Image fullImage = System.Drawing.Image.FromFile(fileName);

                        // Display the enlarged corner of the full image in a PictureBox
                        DisplayEnlargedCorner(fullImage, 300);

                        fullImage.Dispose();
                    };

                    btnFileDelete.Click += (sender, e) =>
                     {                         
                         File.Delete(file);
                         LoadFiles();
                     };


                    // Add the button to the container
                    ButtonContainer.Controls.Add(btnFile);
                    ButtonContainer.Controls.Add(btnFileDelete);
                }
            }

            //dataGridView1.DataSource = fileNames.Select(fileName => new { FileName = fileName }).ToList();



            //this.Controls.Add(dataGridView1);
        }

        public frmMain()
        {
            InitializeComponent();
            LoadFiles();
            this.Left = 100;
            this.Top = 150;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of the WIA Common Dialog class
            var dialog = new WIA.CommonDialog();

            // Create a DeviceManager instance
            var deviceManager = new DeviceManager();

            // Create an empty variable to store the scanner instance
            DeviceInfo firstScannerAvailable = null;

            // Loop through the list of devices to choose the first available
            for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
            {
                // Skip the device if it's not a scanner
                if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
                {
                    continue;
                }

                firstScannerAvailable = deviceManager.DeviceInfos[i];

                break;
            }

            // Connect to the first available scanner
            var device = firstScannerAvailable.Connect();

            // Select the scanner
            var scannerItem = device.Items[1];

            //// Show the WIA common dialog to start the scanning process
            //ImageFile scannedImage = (ImageFile)dialog.ShowAcquireImage(
            //    WiaDeviceType.ScannerDeviceType,
            //    WiaImageIntent.GrayscaleIntent,
            //    WiaImageBias.MinimizeSize,
            //    FormatID.wiaFormatJPEG,
            //    false,
            //    true,
            //    false);

            var scanerItem = (Item)device.Items[1];

            //Property pageSizeProperty = device.Properties["Page Size"];
            //if (pageSizeProperty != null)
            //{
            //    pageSizeProperty.set_Value(WiaPageType.A4);
            //}

            scanerItem.Properties["6146"].set_Value(2); // Color
            scanerItem.Properties["6147"].set_Value(150); // Resolution
            scanerItem.Properties["6151"].set_Value(1754); // Width
            scanerItem.Properties["6152"].set_Value(2480); // Height

            // Retrieve a image in JPEG format and store it into a variable
            var imageFile = (ImageFile)scannerItem.Transfer(FormatID.wiaFormatJPEG);

            // Save the image in some path with filename
            var path = @"C:\Temp\WIA\NewPOD.jpg";

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            // Save image !
            imageFile.SaveFile(path);

            //var file = dialog.ShowAcquireImage(WIA.WiaDeviceType.ScannerDeviceType);
            //file.SaveFile("C:\\Temp\\WIA\\NewPOD.jpg");


            // Convert the saved image to PDF format using iTextSharp
            using (var stream = new FileStream("C:\\Temp\\file.pdf", FileMode.Create))
            {
                var document = new Document(PageSize.A4, 0, 0, 0, 0);
                var writer = PdfWriter.GetInstance(document, stream);
                document.Open();
                var image = iTextSharp.text.Image.GetInstance("C:\\Temp\\WIA\\NewPOD.jpg");
                image.ScaleToFit(PageSize.A4.Width, PageSize.A4.Height);
                document.Add(image);
                document.Close();
            }

            //var dialog = new WIA.CommonDialog();
            //var file = dialog.ShowAcquireImage(WIA.WiaDeviceType.ScannerDeviceType);
            //file.SaveFile("C:\\Temp\\WIA\\NewPOD.jpg");
        }

        private void DisplayEnlargedCorner(System.Drawing.Image fullImage, int cornerSize)
        {
            // Calculate the coordinates of the corner of the full image to be displayed
            int cornerX = fullImage.Width - 400;
            int cornerY = 0;

            // Create a new bitmap to hold the enlarged corner image
            Bitmap cornerBitmap = new Bitmap(400, 300);

            // Create a graphics object for the new bitmap
            Graphics cornerGraphics = Graphics.FromImage(cornerBitmap);

            // Draw the corner of the full image onto the new bitmap
            cornerGraphics.DrawImage(fullImage, new System.Drawing.Rectangle(0, 0, 400, 300),
                new System.Drawing.Rectangle(cornerX, cornerY, cornerSize, cornerSize), GraphicsUnit.Pixel);

            // Display the enlarged corner image in a PictureBox
            picBoxEnlarged.Image = cornerBitmap;
            picBoxEnlarged.Width = 400;
            picBoxEnlarged.Height = 300;
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
                var lastPage = -1;

                // Loop through the pages and convert each one to a JPEG image
                for (var i = firstPage; i <= rasterizer.PageCount && (lastPage == -1 || i <= lastPage); i++)
                {
                    // Get the image for the current page
                    using (var image = rasterizer.GetPage(96, i))
                    {
                        // Save the image to a file
                        var fileName = $"c:\\temp\\output.jpg";
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

        private void btnScan_Click(object sender, EventArgs e)
        {
            int Width = 0;
            int Height = 0;
            int Resolution = 0;

            // Create an instance of the WIA Common Dialog class
            var dialog = new WIA.CommonDialog();

            // Create a DeviceManager instance
            var deviceManager = new DeviceManager();

            // Create an empty variable to store the scanner instance
            DeviceInfo firstScannerAvailable = null;

            // Loop through the list of devices to choose the first available
            for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
            {
                // Skip the device if it's not a scanner
                if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
                {
                    continue;
                }

                firstScannerAvailable = deviceManager.DeviceInfos[i];

                break;
            }

            // Connect to the first available scanner
            var device = firstScannerAvailable.Connect();

            // Select the scanner
            var scannerItem = device.Items[1];
            var scanerItem = (Item)device.Items[1];

            if (rbtnA4.Checked && rbtn150.Checked)
            {
                Width = 1240;
                Height = 1754;
                Resolution = 150;
            }

            if (rbtnA4.Checked && rbtn300.Checked)
            {
                Width = 2400;
                Height = 2400;
                Resolution = 300;
            }

            if (rbtnA3.Checked && rbtn150.Checked)
            {
                Width = 1754;
                Height = 2480;
                Resolution = 150;
            }

            if (rbtnA3.Checked && rbtn300.Checked)
            {
                Width = 3508;
                Height = 4961;
                Resolution = 300;
            }

            scanerItem.Properties["6146"].set_Value(2); // Color
            scanerItem.Properties["6147"].set_Value(Resolution); // Resolution
            scanerItem.Properties["6151"].set_Value(Width); // Width
            scanerItem.Properties["6152"].set_Value(Height); // Height

            // Retrieve a image in JPEG format and store it into a variable
            var imageFile = (ImageFile)scannerItem.Transfer(FormatID.wiaFormatJPEG);

            // Save the image in some path with filename
            var path = @"C:\Temp\WIA\NewPOD.jpg";

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            // Save image
            imageFile.SaveFile(path);

            // Convert the saved image to PDF format using iTextSharp
            using (var stream = new FileStream("C:\\Temp\\file.pdf", FileMode.Create))
            {
                var document = new Document(PageSize.A4, 0, 0, 0, 0);
                var writer = PdfWriter.GetInstance(document, stream);
                document.Open();
                var image = iTextSharp.text.Image.GetInstance("C:\\Temp\\WIA\\NewPOD.jpg");
                image.ScaleToFit(PageSize.A4.Width, PageSize.A4.Height);
                document.Add(image);
                document.Close();
            }

            LoadFiles();
            // Delete the temporary image file
            //File.Delete("C:\\Temp\\WIA\\NewPOD.jpg");
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

        private void frmMain_Load(object sender, EventArgs e)
        {
            cmbDocType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDocType.SelectedItem = "POD";

            // Specify the directory you want to manipulate.
            string path = @"c:\RCLScanner";

            try
            {
                // Determine whether the directory exists.
                if (Directory.Exists(path))
                {
                    Console.WriteLine("The root path already exists.");
                    if (Directory.Exists(@"c:\RCLScanner\Scans"))
                    {
                        Console.WriteLine("The scan path exists already.");
                    }
                    else
                    {
                        Directory.CreateDirectory(@"c:\RCLScanner\Scans");
                    }
                    if (Directory.Exists(@"c:\RCLScanner\History"))
                    {
                        Console.WriteLine("The history path exists already.");
                    }
                    else
                    {
                        Directory.CreateDirectory(@"c:\RCLScanner\History");
                    }                    
                }
                else
                {
                    Directory.CreateDirectory(path);
                    Directory.CreateDirectory(@"c:\RCLScanner\Scans");
                    Directory.CreateDirectory(@"c:\RCLScanner\History");
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("The process failed: {0}", ex.ToString());
            }
            finally { }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadFiles();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            string newfilename = cmbDocType.Text + "_" + txtDocNumber.Text + "_" + dtpDate.Value.ToString("yyyy-MM-dd") + "_" + cmbDocType.Text + ".pdf";
            File.Move(SelectedFile, @"c:\temp\" + newfilename);
            
        }
    }
}
