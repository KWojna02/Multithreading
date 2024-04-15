namespace ParallelPhotoProcessing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxInputImage = new PictureBox();
            buttonLoad = new Button();
            openFileDialog1 = new OpenFileDialog();
            buttonProcess = new Button();
            pictureBoxGrayscale = new PictureBox();
            pictureBoxThreshold = new PictureBox();
            pictureBoxNegative = new PictureBox();
            pictureBoxMirror = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxInputImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGrayscale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxThreshold).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNegative).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMirror).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxInputImage
            // 
            pictureBoxInputImage.Location = new Point(46, 44);
            pictureBoxInputImage.Name = "pictureBoxInputImage";
            pictureBoxInputImage.Size = new Size(579, 385);
            pictureBoxInputImage.TabIndex = 0;
            pictureBoxInputImage.TabStop = false;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(667, 180);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(94, 29);
            buttonLoad.TabIndex = 1;
            buttonLoad.Text = "Load";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += ButtonLoad_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonProcess
            // 
            buttonProcess.Location = new Point(667, 232);
            buttonProcess.Name = "buttonProcess";
            buttonProcess.Size = new Size(94, 55);
            buttonProcess.TabIndex = 2;
            buttonProcess.Text = "Parallel processing";
            buttonProcess.UseVisualStyleBackColor = true;
            buttonProcess.Click += ButtonProcess_Click;
            // 
            // pictureBoxGrayscale
            // 
            pictureBoxGrayscale.Location = new Point(824, 44);
            pictureBoxGrayscale.Name = "pictureBoxGrayscale";
            pictureBoxGrayscale.Size = new Size(220, 177);
            pictureBoxGrayscale.TabIndex = 3;
            pictureBoxGrayscale.TabStop = false;
            // 
            // pictureBoxThreshold
            // 
            pictureBoxThreshold.Location = new Point(824, 252);
            pictureBoxThreshold.Name = "pictureBoxThreshold";
            pictureBoxThreshold.Size = new Size(220, 177);
            pictureBoxThreshold.TabIndex = 4;
            pictureBoxThreshold.TabStop = false;
            // 
            // pictureBoxNegative
            // 
            pictureBoxNegative.Location = new Point(1096, 252);
            pictureBoxNegative.Name = "pictureBoxNegative";
            pictureBoxNegative.Size = new Size(220, 177);
            pictureBoxNegative.TabIndex = 5;
            pictureBoxNegative.TabStop = false;
            // 
            // pictureBoxMirror
            // 
            pictureBoxMirror.Location = new Point(1096, 44);
            pictureBoxMirror.Name = "pictureBoxMirror";
            pictureBoxMirror.Size = new Size(220, 177);
            pictureBoxMirror.TabIndex = 6;
            pictureBoxMirror.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1351, 450);
            Controls.Add(pictureBoxMirror);
            Controls.Add(pictureBoxNegative);
            Controls.Add(pictureBoxThreshold);
            Controls.Add(pictureBoxGrayscale);
            Controls.Add(buttonProcess);
            Controls.Add(buttonLoad);
            Controls.Add(pictureBoxInputImage);
            Name = "Form1";
            Text = "Parallel Image Processing";
            ((System.ComponentModel.ISupportInitialize)pictureBoxInputImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGrayscale).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxThreshold).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNegative).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMirror).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxInputImage;
        private Button buttonLoad;
        private OpenFileDialog openFileDialog1;
        private Button buttonProcess;
        private PictureBox pictureBoxGrayscale;
        private PictureBox pictureBoxThreshold;
        private PictureBox pictureBoxNegative;
        private PictureBox pictureBoxMirror;
    }
}
