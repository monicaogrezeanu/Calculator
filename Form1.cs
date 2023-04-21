
namespace Tema2
{
    public partial class Calculator : Form
    {
        string buttonop;
        double numar;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            label1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cifra;
            Button button = sender as Button;
            cifra = double.Parse(button.Text);
            textBox1.Text += cifra.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void buttonop_Click(object sender, EventArgs e)
        {  
            Button button = sender as Button;
            buttonop = button.Text;
            numar = double.Parse(textBox1.Text);
            label1.Text = textBox1.Text + button.Text;
            label1.Show();
            textBox1.Text = null;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double numar2;
            numar2 = double.Parse(textBox1.Text);
            label1.Text += numar2.ToString() + "=";

            if (buttonop == "/")
                textBox1.Text = (numar / numar2).ToString();
            else if (buttonop == "*")
                textBox1.Text = (numar * numar2).ToString();
            else if (buttonop == "-")
                textBox1.Text = (numar - numar2).ToString();
            else if (buttonop == "+")
                textBox1.Text = (numar + numar2).ToString();

        }
    }
}