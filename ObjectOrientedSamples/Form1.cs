namespace ObjectOrientedSamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.White;
            label1.ForeColor = Color.Red;
            label1.Text = "����ɂ���";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Hide();
            MessageBox.Show("����ɂ���");
        }

        public void MyMethod()
        {

        }
    }
}
