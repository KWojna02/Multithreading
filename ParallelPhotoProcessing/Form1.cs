using System.Windows.Forms;

namespace ParallelPhotoProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private volatile Bitmap? img;

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files|*.jpg;*.jpeg;*.png;*.bmp"; //image files
            openFileDialog1.FileName = "";

            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {

                var file = openFileDialog1.FileName;
                if (!string.IsNullOrEmpty(file))
                {
                    try
                    {
                        img = new Bitmap(file); //load image                        

                        if (img.Width > pictureBoxInputImage.Width || img.Height > pictureBoxInputImage.Height)
                        {
                            img = new Bitmap(img, pictureBoxInputImage.Width, pictureBoxInputImage.Height);
                        }                         

                        pictureBoxInputImage.Image = img;
                        pictureBoxInputImage.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    catch
                    {
                        throw new Exception("Wrong file format.");
                    }
                }
            }
        }       

        private void ButtonProcess_Click(object sender, EventArgs e)
        {
            if (img == null) { MessageBox.Show("No image loaded."); return; }

            buttonProcess.Enabled = false;

            Bitmap[] processedImages = new Bitmap[4];
            
            Parallel.Invoke(() =>
            {
                processedImages[0] = Filters.ApplyGrayscale(img);
                processedImages[1] = Filters.ApplyMirror(img);
                processedImages[2] = Filters.ApplyThreshold(img);
                processedImages[3] = Filters.ApplyNegative(img);
            });

            for (int i = 0; i < 4; i++)
            {
                processedImages[i] = new(processedImages[i], pictureBoxGrayscale.Width, pictureBoxGrayscale.Height);
            }

            pictureBoxGrayscale.Image = processedImages[0];
            pictureBoxGrayscale.SizeMode = PictureBoxSizeMode.Zoom;

            pictureBoxMirror.Image = processedImages[1];
            pictureBoxMirror.SizeMode = PictureBoxSizeMode.Zoom;

            pictureBoxThreshold.Image = processedImages[2];
            pictureBoxThreshold.SizeMode = PictureBoxSizeMode.Zoom;

            pictureBoxNegative.Image = processedImages[3];
            pictureBoxNegative.SizeMode = PictureBoxSizeMode.Zoom;

            buttonProcess.Enabled = true;             
        }        
    }
}
