using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        int operacao, virgula;
        double fat1, fat2, result;
        bool apagadinho;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void Botao(object sender, EventArgs e)
        {
            if (apagadinho)
            {
                Resultado.Text = "";
                apagadinho = false;
            }

                Button digito = sender as Button;
                Resultado.Text += digito.Text;
        }

        private void Soma(object sender, EventArgs e)
        {
            operacao = 1;
            fat1 = Convert.ToDouble(Resultado.Text);
            Resultado.Text = "";
            virgula = 0;
        }

        private void sub(object sender, EventArgs e)
        {
            operacao = 2;
            fat1 = Convert.ToDouble(Resultado.Text);
            Resultado.Text = "";
            virgula = 0;

        }

        private void mult(object sender, EventArgs e)
        {
            operacao = 3;
            fat1 = Convert.ToDouble(Resultado.Text);
            Resultado.Text = "";
            virgula = 0;
        }

        private void div(object sender, EventArgs e)
        {
            operacao = 4;
            fat1 = Convert.ToDouble(Resultado.Text);
            Resultado.Text = "";
            virgula = 0;
        }

        private void Resto(object sender, EventArgs e)
        {
            operacao = 5;
            fat1 = Convert.ToDouble(Resultado.Text);
            Resultado.Text = "";
            virgula = 0;
        }
        private void Pot(object sender, EventArgs e)
        {
            operacao = 6;
            fat1 = Convert.ToDouble(Resultado.Text);
            Resultado.Text = "";
            virgula = 0;
        }
        private void sin(object sender, EventArgs e)
        {
            operacao = 7;
            fat1 = Convert.ToDouble(Resultado.Text);
            virgula = 0;
            apagadinho = true;

            result = Math.Sin(fat1);

            Resultado.Text = Convert.ToString(result);
        }
        private void cos(object sender, EventArgs e)
        {
            operacao = 8;
            fat1 = Convert.ToDouble(Resultado.Text);
            virgula = 0;
            apagadinho = true;

            result = Math.Cos(fat1);

            Resultado.Text = Convert.ToString(result);
        }
        private void tg(object sender, EventArgs e)
        {
            operacao = 9;
            fat1 = Convert.ToDouble(Resultado.Text);
            virgula = 0;
            apagadinho = true;

            result = Math.Tan(fat1);

            Resultado.Text = Convert.ToString(result);
        }
        private void raiz(object sender, EventArgs e)
        {
            operacao = 10;
            fat1 = Convert.ToDouble(Resultado.Text);
            Resultado.Text = "";
            virgula = 0;
        }
        private void Porcento(object sender, EventArgs e)
        {
            operacao = 12;
            fat1 = Convert.ToDouble(Resultado.Text);
            Resultado.Text = "";
            virgula = 0;
        }
        private void C(object sender, EventArgs e)
        {
            Resultado.Text = null;
            operacao = 0;
            virgula = 0;
        }
        private void CE(object sender, EventArgs e)
        {
            Resultado.Text = null;  
        }

        private void Back(object sender, EventArgs e)
        {
            int tamanho = Resultado.Text.Length - 1;
            if (tamanho >= 0)
            {
                Resultado.Text = Resultado.Text.Substring(0, tamanho);
            }
        }
        private void Virgula(object sender, EventArgs e)
        {
            if (virgula == 0)
            {
                Button virg = sender as Button;
                Resultado.Text += virg.Text;
                virgula = 1;
            }
        }
        private void igual(object sender, EventArgs e)
        {
            fat2 = Convert.ToDouble(Resultado.Text);
            apagadinho = true;
            virgula = 0;

            if(operacao == 1){
                result = fat1 + fat2;
            }
            else if (operacao == 2){
                result = fat1 - fat2;
            }
            else if (operacao == 3)
            {
                result = fat1 * fat2;
            }
            else if (operacao == 4)
            {
                result = fat1 / fat2;
            }
            else if (operacao == 5)
            {
                result = fat1 % fat2;
            }
            else if (operacao == 6)
            {
                result = Math.Pow(fat1, fat2);
            }
            else if (operacao == 10)
            {
                result = Math.Pow(fat1, 1 / fat2);
            }
            else if (operacao == 12)
            {
                result = fat1 * fat2 / 100;
            } 
            Resultado.Text = Convert.ToString(result);
        }

    }
}
