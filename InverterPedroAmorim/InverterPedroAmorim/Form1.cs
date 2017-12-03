using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InverterPedroAmorim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnInverter_Click(object sender, EventArgs e)
        {
            // especifica quais caracteres não serão aceitos
            char[] lixo = new char[] { '.', ';', '!', '?', ',', ' ' };


            String textoInvertido = "";

            // percorre todo o texto caracter por caracter a partir do final do texto
            for (int i = tbxInverter.Text.Length - 1; i >= 0; i--)
            {
                // se existir algum caracter não desesado este será ignorado
                if (!lixo.Contains(tbxInverter.Text[i]))
                {
                    // armazena o "limpo" e em letras minúsculas
                    textoInvertido += Char.ToLower(tbxInverter.Text[i]);
                }
            }

            lblResposta.Text = textoInvertido;
        }

    }
}
