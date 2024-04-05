namespace Multithreading
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
            matrixView1 = new DataGridView();
            buttonGenerate = new Button();
            matrixView2 = new DataGridView();
            textBoxRows = new TextBox();
            labelRows = new Label();
            matrixView3 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)matrixView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)matrixView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)matrixView3).BeginInit();
            SuspendLayout();
            // 
            // matrixView1
            // 
            matrixView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            matrixView1.Location = new Point(12, 12);
            matrixView1.Name = "matrixView1";
            matrixView1.RowHeadersWidth = 51;
            matrixView1.Size = new Size(300, 188);
            matrixView1.TabIndex = 0;
            // 
            // buttonGenerate
            // 
            buttonGenerate.Location = new Point(544, 210);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(94, 29);
            buttonGenerate.TabIndex = 1;
            buttonGenerate.Text = "Generate";
            buttonGenerate.UseVisualStyleBackColor = true;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // matrixView2
            // 
            matrixView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            matrixView2.Location = new Point(338, 12);
            matrixView2.Name = "matrixView2";
            matrixView2.RowHeadersWidth = 51;
            matrixView2.Size = new Size(300, 188);
            matrixView2.TabIndex = 2;
            // 
            // textBoxRows
            // 
            textBoxRows.Location = new Point(400, 212);
            textBoxRows.Name = "textBoxRows";
            textBoxRows.Size = new Size(125, 27);
            textBoxRows.TabIndex = 3;
            // 
            // labelRows
            // 
            labelRows.AutoSize = true;
            labelRows.Location = new Point(218, 215);
            labelRows.Name = "labelRows";
            labelRows.Size = new Size(176, 20);
            labelRows.TabIndex = 4;
            labelRows.Text = "Enter the number of rows";
            // 
            // matrixView3
            // 
            matrixView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            matrixView3.Location = new Point(135, 250);
            matrixView3.Name = "matrixView3";
            matrixView3.RowHeadersWidth = 51;
            matrixView3.Size = new Size(300, 188);
            matrixView3.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(matrixView3);
            Controls.Add(labelRows);
            Controls.Add(textBoxRows);
            Controls.Add(matrixView2);
            Controls.Add(buttonGenerate);
            Controls.Add(matrixView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)matrixView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)matrixView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)matrixView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView matrixView1;
        private Button buttonGenerate;
        private DataGridView matrixView2;
        private TextBox textBoxRows;
        private Label labelRows;
        private DataGridView matrixView3;
    }
}
