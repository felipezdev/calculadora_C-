using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade
{
    public partial class Calculadora : Form
    {
        private double numeroAnterior;
        private string operadorAtual;
        public Calculadora()

        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Adição_Click(object sender, EventArgs e)
        {
            operadorAtual = "+";
            numeroAnterior = double.Parse(visor.Text);
            visor.Text += operadorAtual;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            visor.Text += "9";
        }

        private void sete_Click(object sender, EventArgs e)
        {
            visor.Text += "7";
        }

        private void C_Click(object sender, EventArgs e)
        {
            visor.Text="";
        }

        private void oito_Click(object sender, EventArgs e)
        {
            visor.Text += "8";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            visor.Text += "0";
        }

        private void tres_Click(object sender, EventArgs e)
        {
            visor.Text+= "3";
        }

        private void dois_Click(object sender, EventArgs e)
        {
            visor.Text+= "2";
        }

        private void um_Click(object sender, EventArgs e)
        {
            visor.Text += "1";
        }

        private void seis_Click(object sender, EventArgs e)
        {
            visor.Text += "6";
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            visor.Text += "5";
        }

        private void quatro_Click(object sender, EventArgs e)
        {
            visor.Text += "4";
        }

        private void apagar_Click(object sender, EventArgs e)
        {
            if (visor.Text.Length > 0)
            {
                visor.Text = visor.Text.Substring(0, visor.Text.Length - 1);
            }
        }

        private void igualdade_Click(object sender, EventArgs e)
        {
            string[] partes = visor.Text.Split(new char[] { '+', '-', 'X', '/' });
            double numeroAtual = double.Parse(partes[1]);
            double resultado = 0;

            switch (operadorAtual)
            {
                case "+":
                    resultado = numeroAnterior + numeroAtual;
                    break;
                case "-":
                    resultado = numeroAnterior - numeroAtual;
                    break;
                case "X":
                    resultado = numeroAnterior * numeroAtual;
                    break;
                case "/":
                    if (numeroAtual != 0)
                        resultado = numeroAnterior / numeroAtual;
                    else
                        MessageBox.Show("Não é possivel dividir por zero");
                    break;
            }
            visor.Text = resultado.ToString();
        }
        private void porcento_Click(object sender, EventArgs e)
        {
        double numeroAtual = double.Parse(visor.Text);
            double resultado = 0;   

            switch (operadorAtual)
            {
                case "+"  :
                    resultado = numeroAnterior + (numeroAnterior * (numeroAtual / 100));
                    break; 

                case "-" :
                    resultado = numeroAnterior - (numeroAnterior * (numeroAtual / 100));
                    break;

                    case "X" :
                    resultado = numeroAnterior * (numeroAtual/100);
                    break;

                    case "/"  :
                    if (numeroAtual != 0)
                        resultado = numeroAnterior / (numeroAnterior * (numeroAtual / 100));
                    else
                        MessageBox.Show("Não é posssivel dividir por zero");
                    break;
            }
        }

        private void divisao_Click(object sender, EventArgs e)
        {
            operadorAtual = "/";
            numeroAnterior = double.Parse(visor.Text);
            visor.Text += operadorAtual;
        }

        private void multiplicacao_Click(object sender, EventArgs e)
        {
            operadorAtual = "X";
            numeroAnterior = double.Parse(visor.Text);
            visor.Text += operadorAtual;
        }

        private void subtracao_Click(object sender, EventArgs e)
        {
            operadorAtual = "-";
            numeroAnterior = double.Parse(visor.Text);
            visor.Text += operadorAtual;
        }

        private void virgula_Click(object sender, EventArgs e)
        {
            if (!visor.Text.Contains("."))
            {
                visor.Text += ".";
            }
        }

        private void ponto_Click(object sender, EventArgs e)
        {
            if (!visor.Text.Contains("."))
            {
                visor.Text += ".";
            }
        }
    }
}
