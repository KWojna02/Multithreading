namespace Multithreading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelTime.Visible = false;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            buttonGenerate.Enabled = false;
            if (textBoxRows.Text == ""|| textBoxThreads.Text=="") { buttonGenerate.Enabled = true; return; }
            
            int rows = int.Parse(textBoxRows.Text);
            int threads = int.Parse(textBoxThreads.Text);
            matrixView1.Rows.Clear();
            matrixView2.Rows.Clear();
            matrixView3.Rows.Clear();

            Matrix matrix1 = new(rows);
            Matrix matrix2 = new(rows);

            matrix1.Display(matrixView1);
            matrix2.Display(matrixView2);

            var watch = System.Diagnostics.Stopwatch.StartNew();
            Matrix matrix3 = matrix1.Multiplication(matrix2, threads);
            watch.Stop();

            matrix3.Display(matrixView3);
            
            labelTime.Text = $"Time: {watch.ElapsedMilliseconds} ms";
            labelTime.Visible = true;
            buttonGenerate.Enabled=true;
        }

        
    }
}
