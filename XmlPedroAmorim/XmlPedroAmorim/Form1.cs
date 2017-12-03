using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace XmlPedroAmorim
{
    public partial class Form1 : Form
    {

        private Cars cars = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // utiliza o componente openFileDialog para abrir o arquivo .xml
            openFileDialog1.Filter = "Arquivo XML|*.xml";
            openFileDialog1.CheckFileExists = true;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (File.Exists(openFileDialog1.FileName))
                {
                    // caso o arquivo exista, o xml é serializado e os combobox preenchidos
                    txtCaminhoArquivo.Text = openFileDialog1.FileName;
                    deserializar();
                    meusCombobox();
                }
            }
        }

        // 
        private void meusCombobox()
        {

            List<string> listaMarca = new List<string>();
            List<string> listaModelo = new List<string>();
            List<string> listaAno = new List<string>();
            List<double> listaPreco = new List<double>();

            // armazeno cada item em uma lista para que posso organiza por ordem alfabética com .sort()
            foreach (Car carro in cars.Carros)
            {
                if (!listaMarca.Contains(carro.Brand))
                    listaMarca.Add(carro.Brand);

                if (!listaModelo.Contains(carro.Model))
                    listaModelo.Add(carro.Model);

                if (!listaAno.Contains(carro.Year))
                    listaAno.Add(carro.Year);

                if (!listaPreco.Contains(carro.Price))
                    listaPreco.Add(carro.Price);
            }

            // ordena as listas
            listaMarca.Sort();
            listaModelo.Sort();
            listaAno.Sort();
            listaPreco.Sort();

            // adicioa aos combobox items default
            cbxMarca.Items.Add("Todas Marcas");
            cbxModelo.Items.Add("Todos Modelos");
            cbxAno.Items.Add("Todos Anos");
            cbxPreco.Items.Add("Todos Preços");

            // adiciona aos combobox itens ordenados
            foreach (var marca in listaMarca)
                cbxMarca.Items.Add(marca);

            foreach (var modelo in listaModelo)
                cbxModelo.Items.Add(modelo);

            foreach (var ano in listaAno)
                cbxAno.Items.Add(ano);

            foreach (var preco in listaPreco)
                cbxPreco.Items.Add(preco);

            // Deixa os items Default dos comboboxes selecionados
            cbxMarca.SelectedIndex = 0;
            cbxModelo.SelectedIndex = 0;
            cbxAno.SelectedIndex = 0;
            cbxPreco.SelectedIndex = 0;
        }


        private void deserializar()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Cars));
            StreamReader reader = new StreamReader(txtCaminhoArquivo.Text);

            cars = (Cars)serializer.Deserialize(reader);
            reader.Close();
        }


        private void selecionaComboBox(object sender, EventArgs e)
        {   
            listViewCarros.Items.Clear();

            var marca = cbxMarca.Text;
            var modelo = cbxModelo.Text;
            var preco = cbxPreco.Text;
            var ano = cbxAno.Text;
            List<Car> carrosListaAux = cars.Carros;

            // Somente usa LINQ se o item dos combobox nao forem defaults
            // a cada LINQ é armazenado uma lista de carros de acordo com
            // o que está selecionado no combobox

            if (!cbxMarca.Text.Equals("Todas Marcas"))
            {
                carrosListaAux =
(from c in carrosListaAux
 where c.Brand.Equals(marca)
 select c).ToList();
            }

            if (!cbxModelo.Text.Equals("Todos Modelos"))
            {
                carrosListaAux =
(from c in carrosListaAux
 where c.Model.Equals(modelo)
 select c).ToList();
            }

            if (!cbxAno.Text.Equals("Todos Anos"))
            {
                carrosListaAux =
(from c in carrosListaAux
 where c.Year.Equals(ano)
 select c).ToList();
            }

            if (!cbxPreco.Text.Equals("Todos Preços"))
            {
                carrosListaAux =
(from c in carrosListaAux
 where c.Price.ToString() == preco
 select c).ToList();
            }

            // popula o listView com com os dados filtrados
            foreach (Car carro in carrosListaAux)
            {
                string[] linha = new string[] { carro.StockNumber.ToString(), carro.Brand, carro.Model, carro.Year, carro.Price.ToString() };
                ListViewItem listViewItem = new ListViewItem(linha);
                listViewCarros.Items.Add(listViewItem);
            }
        }

    }
}