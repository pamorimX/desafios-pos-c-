using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FrequenciaPedroAmorim
{
    public partial class Form : System.Windows.Forms.Form
    {

        private Dictionary<string, int> Palavras = new Dictionary<string, int>(StringComparer.CurrentCultureIgnoreCase);
        
        // \w* pega qualquer caracteres alpha numericos, é o equivalente a [a-zA-Z0-9_]. 
        // E o + diz que tudo aquilo que estiver antes dele deve aparecer pelo menos 1 vez
        private Regex Expressao = new Regex(@"\w+", RegexOptions.None);

        public Form()
        {
            InitializeComponent();
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            // Limpa o dicionário e o datagrid a cada clique
            this.Palavras.Clear();
            dataGridView.Rows.Clear();

            // Verifica a expressão regular definida com o texto digitado
            foreach (Match match in this.Expressao.Matches(txtPalavras.Text))
            {
                // se a palavra não estiver no dicionário, a mesma é adicionada com valor 1
                // caso contrário, incrementa o valor
                if (!this.Palavras.ContainsKey(match.Value))
                    this.Palavras.Add(match.Value.ToLower(), 1);
                else
                    this.Palavras[match.Value]++;
            }

            // popula o datagrid com o dicionário ordenado pela quantidade de palavras e crescente
            foreach (KeyValuePair<string, int> palavra in this.Palavras.OrderBy(key => key.Value))
            {
                dataGridView.Rows.Add(palavra.Key, palavra.Value);
            }
        }
    }
}
