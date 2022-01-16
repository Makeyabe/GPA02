namespace GPA
{
    public partial class Form1 : Form
    {
        double sum = 0;
        int n = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strInput = GIN.Text;
            double dInput = double.Parse(strInput);
            sum = sum + dInput;
            n = n + 1;
            double result = sum / n;
            Box2.Text = result.ToString();
            GIN.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Box2.Text = "";
            GIN.Text = "";
            sum = 0;
            n =0;
        }
    }
}