using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Calculadora : Form
    {
        public decimal resultado {  get; set; }
        public decimal valor { get; set; }

        private operacao OperacaoSelecionada { get; set; }
        private enum operacao
        {
            adicao,
            subtracao,
            multiplicacao,
            divisao,
            porcentagem
        }
        public Calculadora()

        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nove_Click(object sender, EventArgs e)
        {
            visor.Text += "9";
        }

        private void sete_Click(object sender, EventArgs e)
        {
            visor.Text += "7";
        }

        private void C_Click(object sender, EventArgs e)
        {
            visor.Text = "";
            mostrador.Text = "";
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
            visor.Text += "3";
        }

        private void dois_Click(object sender, EventArgs e)
        {
            visor.Text += "2";
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
            switch (OperacaoSelecionada)
            {
                case operacao.adicao:
                    resultado = valor + Convert.ToDecimal(visor.Text);
                    break;

                     case operacao.subtracao:
                      resultado = valor - Convert.ToDecimal(visor.Text);
                       break;

                        case operacao.multiplicacao:
                         resultado = valor * Convert.ToDecimal(visor.Text);  
                          break;

                           case operacao.divisao:
                            resultado = valor / Convert.ToDecimal(visor.Text);
                             break;
                              
            }
             
             visor.Text = Convert.ToString(resultado);
             mostrador.Text = "=";
        }
        private void porcento_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(visor.Text) && decimal.TryParse(visor.Text, out decimal valorVisor))
            {
                
                if (OperacaoSelecionada == operacao.subtracao)
                {                 
                    decimal resultado = valor * (valorVisor / 100);                   
                    visor.Text = (valor - resultado).ToString();                 
                    OperacaoSelecionada = operacao.porcentagem;                
                    mostrador.Text = $"-{valorVisor}%";
                }
                else if (OperacaoSelecionada == operacao.adicao)
                {
                    decimal resultado = valor * (valorVisor / 100);
                    visor.Text = (valor + resultado).ToString();
                    OperacaoSelecionada = operacao.porcentagem;
                    mostrador.Text = $"+{valorVisor}%";
                }
            }
            
        }
        private void adicao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = operacao.adicao;
            valor = Convert.ToDecimal(visor.Text);
            visor.Text = "";
            mostrador.Text = "+";
        }
        private void divisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = operacao.divisao;
            valor = Convert.ToDecimal(visor.Text);
            visor.Text = "";
            mostrador.Text = "/";
        }

        private void multiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = operacao.multiplicacao;
            valor = Convert.ToDecimal(visor.Text);
            visor.Text = "";
            mostrador.Text = "X";

        }

        private void subtracao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = operacao.subtracao;
            valor = Convert.ToDecimal(visor.Text);
            visor.Text = "";
            mostrador.Text = "-";
        }

        private void virgula_Click(object sender, EventArgs e)
        {
            if (!visor.Text.Contains(","))
                visor.Text += ",";
        }

        private void ponto_Click(object sender, EventArgs e)
        {
            if (!visor.Text.Contains("."))
                visor.Text += ".";
        }

        private void visor_TextChanged(object sender, EventArgs e)
        {

        }


    }
}