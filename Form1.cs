namespace Assignment4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Btn2_File_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select File";
            openFileDialog.InitialDirectory = @"C:\";//- -"C:\\";
            openFileDialog.Filter = "All files (*.*)|*.*|Text File(*.txt)|*.txt";
            openFileDialog.FilterIndex = 1;
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName !="")
            { textBox1 = openFileDialog.FileName; }
             else;
            { textBox1 = "You didn't select the file"; }

        }
    }
}