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
            string caracteresPadrao = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            

            //2. Pegar o comprimento escolhido no NumericUpDown
            int comprimento = (int)numComprimento.Value;

            //3. Gerador de números aleatórios
            Random random = new Random();
            StringBuilder senha = new StringBuilder();

            //4. Sortear caracteres
            if (chkSimbolos.Checked)
            {
                caracteresPadrao += "!@#$%&*";
            }
            if (chkNumeros.Checked)
            {
                caracteresPadrao += "1234567890";
            }

            for (int i = 0; i < comprimento; i++)
            {
                int indice = random.Next(caracteresPadrao.Length);
                senha.Append(caracteresPadrao[indice]);
            }
            //*************Forma inicial que eu havia pensado************************
            //if (chkNumeros.Checked && chkSimbolos.Checked)
            //{

            //    for (int i = 0; i < comprimento; i++)
            //    {
            //        int indice = random.Next(caracteresTodos.Length);
            //        senha.Append(caracteresTodos[indice]);
            //    }
            //} 
            //else if (chkSimbolos.Checked)
            //{
            //    for (int i = 0; i < comprimento; i++)
            //    {
            //        int indice = random.Next(caracteresComSimbolos.Length);
            //        senha.Append(caracteresComSimbolos[indice]);
            //    }
            //}
            //else if (chkNumeros.Checked)
            //{
            //    for (int i = 0; i < comprimento; i++)
            //    {
            //        int indice = random.Next(caracteresComNumeros.Length);
            //        senha.Append(caracteresComNumeros[indice]);
            //    }
            //}
            //else
            //{
            //    for (int i = 0; i < comprimento; i++)
            //    {
            //        int indice = random.Next(caracteresPadrao.Length);
            //        senha.Append(caracteresPadrao[indice]);
            //    }
            //}

            //5. Exibir no TextBox
            txtSenha.Text = senha.ToString();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text != "")
            {
                Clipboard.SetText(txtSenha.Text);
                MessageBox.Show("Senha copiada com sucesso!");
            }
            else
            {
                MessageBox.Show("É necessário gerar uma senha antes de copiar");
            }
        }
    }
}
