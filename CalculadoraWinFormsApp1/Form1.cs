using System.Globalization;

namespace CalculadoraWinFormsApp1
{
    public partial class Form1 : Form
    {
        decimal valor = 0, valor2 = 0;

        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textResultado.Text += "1";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            valor = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);

            textResultado.Text = "";
            operacao = "Div";
            lblOperacao.Text = "/";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textResultado.Text += "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textResultado.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textResultado.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textResultado.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textResultado.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textResultado.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textResultado.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textResultado.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textResultado.Text += "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            valor = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);

            textResultado.Text = "";
            operacao = "Soma";
            lblOperacao.Text = "+";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textResultado.Text += ".";

        }

        private void button18_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);
            if (operacao == "Soma")
            {
                textResultado.Text = Convert.ToString(valor + valor2);
            }
            else if (operacao == "Sub")
            {
                textResultado.Text = Convert.ToString(valor - valor2);
            }
            else if (operacao == "Mult")
            {
                textResultado.Text = Convert.ToString(valor * valor2);
            }
            else if (operacao == "Div")
            {
                textResultado.Text = Convert.ToString(valor / valor2);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            valor = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);

            textResultado.Text = "";
            operacao = "Sub";
            lblOperacao.Text = "-";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            valor = decimal.Parse(textResultado.Text, CultureInfo.InvariantCulture);

            textResultado.Text = "";
            operacao = "Mult";
            lblOperacao.Text = "x";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";
            valor = 0; 
            valor2 = 0;
            lblOperacao.Text = "";
        }
    }
}