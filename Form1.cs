using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text; //Necessário para usar o StringBuilder
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeSenhas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            //1. Definir os caracteres possíveis
            string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%&*";

            //2. Pegar o comprimento escolhido no NumericUpDown
            int comprimento = (int)numComprimento.Value;

            //3. Gerador de números aleatórios
            Random random = new Random();
            StringBuilder senha = new StringBuilder();

            //4. Sortear caracteres
            for (int i = 0; i < comprimento; i++)
            {
                int indice = random.Next(caracteres.Length);
                senha.Append(caracteres[indice]);
            }

            //5. Exibir no TextBox
            txtSenha.Text = senha.ToString();
        }
    }
}
