namespace Multithreading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if(textBoxRows.Text == "") { return; }

            int rows = int.Parse(textBoxRows.Text);
            matrixView1.Rows.Clear();
            matrixView2.Rows.Clear();
            matrixView3.Rows.Clear();

            Matrix matrix1 = new(rows);
            Matrix matrix2 = new(rows);

            matrix1.Display(matrixView1);
            matrix2.Display(matrixView2);

            Matrix matrix3 = matrix1.Multiply(matrix2);
            matrix3.Display(matrixView3);
        }

        
    }
}
