using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace MissionPlanner
{
    public partial class Imagef : Form
    {

        private int currentIndex;
        public string[] imagePaths;
        private int selectedImageIndex = -1;
        public static List<string> deletedImagePaths = new List<string>();
        public static List<string> deleted = new List<string>();

        public Imagef(string[] imagePaths)
        {
            InitializeComponent();
            this.imagePaths = imagePaths;
            currentIndex = 0;
            this.MinimizeBox = false;
        }

        private void nxtbut_Click(object sender, EventArgs e)
        {
            currentIndex += 8;
            if (currentIndex >= imagePaths.Length)
                currentIndex = imagePaths.Length - 1;

            ShowImages();
        }

        private void prvbut_Click(object sender, EventArgs e)
        {
            currentIndex -= 8;
            if (currentIndex < 0)
                currentIndex = Math.Max(0, imagePaths.Length - 8);

            ShowImages();
        }

        private void rembut_Click(object sender, EventArgs e)
        {
            if (selectedImageIndex >= 0 && selectedImageIndex < imagePaths.Length)
            {
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(imagePaths[selectedImageIndex]);
                string newFileName = Path.ChangeExtension(fileNameWithoutExtension, ".txt");
                deletedImagePaths.Add(imagePaths[selectedImageIndex]);// Add the image path to the list of deleted images
                deleted.Add(newFileName);
                selectedImageIndex = -1;

                if (currentIndex >= imagePaths.Length - 1)
                {
                    currentIndex = Math.Max(0, imagePaths.Length - 4);
                }



                tableLayoutPanel1.Controls.Clear();

                ShowImages();


            }
        }

            private void Imagef_Load(object sender, EventArgs e)
            {
                ShowImages();
            }

            public void ShowImages()
            {
                // Clear existing controls from the tableLayoutPanel
                tableLayoutPanel1.Controls.Clear();
                rembut.Visible = false;

                // Calculate the number of rows and columns based on the number of images
                int numImages = imagePaths.Length;
                int numColumns = 4; // Adjust the number of columns as needed
                int numRows = 2; // Adjust the number of rows as needed

                // Configure the tableLayoutPanel
                tableLayoutPanel1.RowCount = numRows;
                tableLayoutPanel1.ColumnCount = numColumns;

                // Calculate the starting and ending indexes for the current page
                int startIndex = currentIndex;
                int endIndex = Math.Min(startIndex + (numColumns * numRows), numImages);
                int index = 0;
                // Loop through the imagePaths and create PictureBox controls for each image
                for (index = startIndex; index < endIndex; index++)
                {
                    if (deletedImagePaths != null && index < imagePaths.Length && deletedImagePaths.Contains(imagePaths[index]))
                    {
                        continue;

                    }
                    string imagePath = imagePaths[index];

                    // Calculate the row and column index for the current image
                    int row = (index - startIndex) / numColumns;
                    int column = (index - startIndex) % numColumns;

                    // Create a new PictureBox control for the image
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = Image.FromFile(imagePath);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage; // Adjust the image display mode as needed
                    pictureBox.Dock = DockStyle.Fill; // Make the PictureBox fill the entire cell

                    pictureBox.Tag = index;

                    // Add the PictureBox to the tableLayoutPanel
                    tableLayoutPanel1.Controls.Add(pictureBox, column, row);

                    pictureBox.Click += PictureBox_Click;


                    // Enable or disable the previous and next buttons based on the current page
                    prvbut.Enabled = currentIndex > 0;
                    nxtbut.Enabled = endIndex < numImages;

                }
            }


            private void MakeBorderStylish(PictureBox pictureBox)
            {
                pictureBox.Paint += (sender, e) =>
                {
                    int borderWidth = 4;
                    Color borderColor = Color.Red;

                    ControlPaint.DrawBorder(e.Graphics, pictureBox.ClientRectangle, borderColor, borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth, ButtonBorderStyle.Solid);
                };
            }


            private void PictureBox_Click(object sender, EventArgs e)
            {
                // Clear the selection of all PictureBox controls
                foreach (Control control in tableLayoutPanel1.Controls)
                {
                    if (control is PictureBox pictureBox)
                    {
                        // Reset the border style of the PictureBox
                        pictureBox.BorderStyle = BorderStyle.None;
                    }
                }

                // Get the clicked PictureBox control
                PictureBox clickedPictureBox = (PictureBox)sender;
                clickedPictureBox.BorderStyle = BorderStyle.FixedSingle;
                // Set the border style of the clicked PictureBox to indicate selection
                MakeBorderStylish(clickedPictureBox);


                // Get the index of the selected image


                selectedImageIndex = (int)clickedPictureBox.Tag;

                rembut.Visible = true;
            }

        private void waypoints_Click(object sender, EventArgs e)
        {
            string baseDirectory = Application.StartupPath;
            string folderName = "five";
            string directoryPath = Path.Combine(baseDirectory, folderName);

            if (!Directory.Exists(directoryPath))
                Directory.CreateDirectory(directoryPath);

            string[] txtFiles = Directory.GetFiles(directoryPath, "*.txt");

            int i = 0;


            StringBuilder missionFileContent = new StringBuilder();

            missionFileContent.AppendLine($"S.NO,latitude,longitude");

            foreach (string txtFile in txtFiles)
            {
                string fileContent = File.ReadAllText(txtFile);

                // Assuming each line in the text file contains a latitude and longitude separated by a space
                string[] lines = fileContent.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string line in lines)
                {
                    string[] coordinates = line.Split(',');

                    if (coordinates.Length == 2 && double.TryParse(coordinates[0], out double latitude) && double.TryParse(coordinates[1], out double longitude))
                    {
                        missionFileContent.AppendLine($"{i},{latitude},{longitude}");
                        i++;
                    }
                }

            }

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string waypointFilePath = Path.Combine(desktopPath, "final.csv");

            File.WriteAllText(waypointFilePath, missionFileContent.ToString());

            MessageBox.Show("CSV generated successfully!");
        }
    }
}
