using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace SpriteFuser
{
    public partial class SpriteFuser : Form
    {
        private int Rows { get; set; }
        private int Columns { get; set; }
        private int WidthValue { get; set; }
        private int HeightValue { get; set; }
        public SpriteFuser()
        {
            InitializeComponent();
        }
      

        private void FusionButton_Click(object sender, EventArgs e)
        {
            this.FusionButton.Enabled = false;
            this.ResultLabel.Text = String.Empty;
            Bitmap result = FuseSprites(Rows, Columns);
            SaveImageToDisk(result, WidthValue, HeightValue);
            DeleteInputFiles();
            this.FusionButton.Enabled = true;
            this.ResultLabel.Text = "Fusion successful. Check the \"Output\" folder.";
        }
        private void SaveImageToDisk(Bitmap image, int width, int height)
        {
            try
            {
                string pathToOutput = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Output");
                string fileName = $"{GetOutputFileName()}.png";
                new Bitmap(image, new Size(width, height)).Save(Path.Combine(pathToOutput, fileName), ImageFormat.Png);
            }
            catch
            {
                this.ResultLabel.Text = "Something went wrong when trying to save the image output to disk.";
                this.FusionButton.Enabled = true;
                throw;
            }            
        }

        private string GetOutputFileName()
        {
            string pathToFiles = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Input");
            string[] imagePaths = Directory.GetFiles(pathToFiles);
            //using (FileInfo info = new FileInfo(imagePaths.FirstOrDefault()))
            //{

            //}
            FileInfo info = new FileInfo(imagePaths.FirstOrDefault());
            string result = info.Name.Split('@').FirstOrDefault();
            return result;
        }

        private void DeleteInputFiles()
        {
            try
            {
                string pathToFiles = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Input");
                string[] imagePaths = Directory.GetFiles(pathToFiles);
                foreach (string imagePath in imagePaths)
                {
                    File.Delete(imagePath);
                }
            }
            catch
            {
                this.ResultLabel.Text = "Something went wrong when trying to delete the input files.";
                this.FusionButton.Enabled = true;
                throw;
            }
        }

        private Bitmap FuseSprites(int rows, int columns)
        {
            try
            {
                string pathToFiles = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Input");
                string[] imagePaths = Directory.GetFiles(pathToFiles);
                int imageFileCounter = 0;
                List<List<Bitmap>> inputImages = new List<List<Bitmap>>();
                for (int i = 0; i < rows; i++)
                {
                    inputImages.Add(new List<Bitmap>());
                    for (int j = 0; j < columns; j++)
                    {
                        inputImages[i].Add(new Bitmap(imagePaths[imageFileCounter]));
                        imageFileCounter++;
                    }
                }
                List<Bitmap> rowsImages = GenerateRows(rows, columns, inputImages);
                for (int i = 0; i < rows; i++)
                {
                    inputImages.Add(new List<Bitmap>());
                    for (int j = 0; j < columns; j++)
                    {
                        inputImages[i][j].Dispose();
                    }
                }
                Bitmap finalImage = JoinRows(rowsImages);
                return finalImage;
            }
            catch
            {
                this.ResultLabel.Text = "Something went wrong when trying to fuse the input files.";
                this.FusionButton.Enabled = true;
                throw;
            }

        }
        private List<Bitmap> GenerateRows(int rows, int rowSize, List<List<Bitmap>> inputImages)
        {
            List<Bitmap> rowsImages = new List<Bitmap>();
            for(int i=0; i<rows; i++)
            {
                Bitmap temporalRow = inputImages[i][0];
                for(int j=1; j<rowSize; j++)
                {
                    temporalRow = JoinHorizontaly(temporalRow, inputImages[i][j]);                   
                }
                rowsImages.Add(temporalRow);
            }
            return rowsImages;
        }
        private Bitmap JoinRows(List<Bitmap> rowImages)
        {
            Bitmap temporalImage = rowImages[0];
            for(int j = 1; j< rowImages.Count; j++)
            {
                temporalImage = JoinVertically(temporalImage, rowImages[j]);
            }
            return temporalImage;           
        }

        private Bitmap JoinHorizontaly(Bitmap firstImage, Bitmap secondImage)
        {
            Bitmap bitmap = new Bitmap(firstImage.Width + secondImage.Width, Math.Max(firstImage.Height, secondImage.Height));
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.DrawImage(firstImage, 0, 0);
                g.DrawImage(secondImage, firstImage.Width, 0);
            }
            return bitmap;
        }

        private Bitmap JoinVertically(Bitmap firstImage, Bitmap secondImage)
        {
            Bitmap bitmap = new Bitmap(Math.Max(firstImage.Width, secondImage.Width), firstImage.Height + secondImage.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.DrawImage(firstImage, 0, 0);
                g.DrawImage(secondImage, 0, firstImage.Height);
            }
            return bitmap;
        }



        private void ColumnsInput_ValueChanged(object sender, EventArgs e)
        {
            if (sender is NumericUpDown input)
            {
                this.Columns = Decimal.ToInt32(input.Value);
            }
        }

        private void RowsInput_ValueChanged(object sender, EventArgs e)
        {
            if (sender is NumericUpDown input)
            {
                this.Rows = Decimal.ToInt32(input.Value);
            }
        }

        private void WidthInput_ValueChanged(object sender, EventArgs e)
        {
            if (sender is NumericUpDown input)
            {
                this.WidthValue = Decimal.ToInt32(input.Value);
            }
        }

        private void HeightInput_ValueChanged(object sender, EventArgs e)
        {
            if (sender is NumericUpDown input)
            {
                this.HeightValue = Decimal.ToInt32(input.Value);
            }
        }

        private void ResultLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
