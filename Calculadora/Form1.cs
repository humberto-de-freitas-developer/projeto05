namespace Calculadora;
using System.Globalization;
using System;

    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = " ";
        public Form1()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

    private void button11_Click(object sender, EventArgs e)
    {
        if(txtResultado.Text != "")
        { 
        
        valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
         if (operacao == "SOMA")
        {
           txtResultado.Text = Convert.ToString(valor1 + valor2);
        } else if(operacao == "SUB")
        {
            txtResultado.Text = Convert.ToString(valor1 - valor2);
        } else if(operacao == "MULTI")
        {
            txtResultado.Text = Convert.ToString(valor1 * valor2);
        } else if(operacao == "DIV")
        {
            txtResultado.Text = Convert.ToString(valor1 / valor2);
        }
        }
        else
        {
            MessageBox.Show("Informe um valor para efetuar as operações");
        }
    }

    private void button7_Click(object sender, EventArgs e)
    {
        if(txtResultado.Text != "")
        { 
             valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
             txtResultado.Text = "";
             operacao = "SUB";
             lblOperacao.Text = "-";
        }
        else
        {
            MessageBox.Show("Informe um valor para realizar a subtração");
        }
    }

    private void button12_Click(object sender, EventArgs e)
    {
        if(txtResultado.Text != "")
        { 
        valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
        txtResultado.Text = "";
        operacao = "MULTI";
        lblOperacao.Text = "*";
        }
        else
        {
            MessageBox.Show("Informe um valor para efetuar a Multiplicação");
        }
    }

    private void button17_Click(object sender, EventArgs e)
    {
        if (txtResultado.Text != "")
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "DIV";
            lblOperacao.Text = "/";
        }
        else
        {
            MessageBox.Show("Informe um valor para efetuar a Divisão");
        }
    }

    private void button5_Click(object sender, EventArgs e)
    {
        txtResultado.Text = "";
        lblOperacao.Text = "";
    }

    private void button6_Click(object sender, EventArgs e)
    {
        txtResultado.Text = "";
        valor1 = 0;
        valor2 = 0;
        lblOperacao.Text = "";
    }

    private void button4_Click(object sender, EventArgs e)
        {
        if (txtResultado.Text != "") { 
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "SOMA";
            lblOperacao.Text = "+";
            }
        else
        {
            MessageBox.Show("Informe um valor para efetuar a soma");
        }
        }
    }


