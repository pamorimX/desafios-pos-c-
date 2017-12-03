namespace XmlPedroAmorim
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.cbxModelo = new System.Windows.Forms.ComboBox();
            this.cbxPreco = new System.Windows.Forms.ComboBox();
            this.cbxAno = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listViewCarros = new System.Windows.Forms.ListView();
            this.cCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cMarca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cModelo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cAno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cPreco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAbreArquivo = new System.Windows.Forms.Button();
            this.txtCaminhoArquivo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxMarca
            // 
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(149, 129);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(121, 24);
            this.cbxMarca.TabIndex = 0;
            this.cbxMarca.SelectedIndexChanged += new System.EventHandler(this.selecionaComboBox);
            // 
            // cbxModelo
            // 
            this.cbxModelo.FormattingEnabled = true;
            this.cbxModelo.Location = new System.Drawing.Point(149, 169);
            this.cbxModelo.Name = "cbxModelo";
            this.cbxModelo.Size = new System.Drawing.Size(121, 24);
            this.cbxModelo.TabIndex = 0;
            this.cbxModelo.SelectedIndexChanged += new System.EventHandler(this.selecionaComboBox);
            // 
            // cbxPreco
            // 
            this.cbxPreco.FormattingEnabled = true;
            this.cbxPreco.Location = new System.Drawing.Point(575, 176);
            this.cbxPreco.Name = "cbxPreco";
            this.cbxPreco.Size = new System.Drawing.Size(121, 24);
            this.cbxPreco.TabIndex = 0;
            this.cbxPreco.SelectedIndexChanged += new System.EventHandler(this.selecionaComboBox);
            // 
            // cbxAno
            // 
            this.cbxAno.FormattingEnabled = true;
            this.cbxAno.Location = new System.Drawing.Point(575, 126);
            this.cbxAno.Name = "cbxAno";
            this.cbxAno.Size = new System.Drawing.Size(121, 24);
            this.cbxAno.TabIndex = 0;
            this.cbxAno.SelectedIndexChanged += new System.EventHandler(this.selecionaComboBox);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Preço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(532, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ano:";
            // 
            // listViewCarros
            // 
            this.listViewCarros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cCodigo,
            this.cMarca,
            this.cModelo,
            this.cAno,
            this.cPreco});
            this.listViewCarros.GridLines = true;
            this.listViewCarros.Location = new System.Drawing.Point(88, 240);
            this.listViewCarros.Name = "listViewCarros";
            this.listViewCarros.Size = new System.Drawing.Size(617, 160);
            this.listViewCarros.TabIndex = 2;
            this.listViewCarros.UseCompatibleStateImageBehavior = false;
            this.listViewCarros.View = System.Windows.Forms.View.Details;
            // 
            // cCodigo
            // 
            this.cCodigo.Text = "Codigo";
            // 
            // cMarca
            // 
            this.cMarca.Text = "Marca";
            // 
            // cModelo
            // 
            this.cModelo.Text = "Modelo";
            // 
            // cAno
            // 
            this.cAno.Text = "Ano";
            // 
            // cPreco
            // 
            this.cPreco.Text = "Preço";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Abrir xml";
            // 
            // btnAbreArquivo
            // 
            this.btnAbreArquivo.Location = new System.Drawing.Point(649, 77);
            this.btnAbreArquivo.Name = "btnAbreArquivo";
            this.btnAbreArquivo.Size = new System.Drawing.Size(47, 23);
            this.btnAbreArquivo.TabIndex = 3;
            this.btnAbreArquivo.Text = "...";
            this.btnAbreArquivo.UseVisualStyleBackColor = true;
            this.btnAbreArquivo.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCaminhoArquivo
            // 
            this.txtCaminhoArquivo.Location = new System.Drawing.Point(88, 77);
            this.txtCaminhoArquivo.Name = "txtCaminhoArquivo";
            this.txtCaminhoArquivo.Size = new System.Drawing.Size(555, 22);
            this.txtCaminhoArquivo.TabIndex = 4;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(280, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(234, 29);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "XML DE CARROS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 461);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtCaminhoArquivo);
            this.Controls.Add(this.btnAbreArquivo);
            this.Controls.Add(this.listViewCarros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxPreco);
            this.Controls.Add(this.cbxAno);
            this.Controls.Add(this.cbxModelo);
            this.Controls.Add(this.cbxMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "XML de Carros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.ComboBox cbxModelo;
        private System.Windows.Forms.ComboBox cbxPreco;
        private System.Windows.Forms.ComboBox cbxAno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listViewCarros;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnAbreArquivo;
        private System.Windows.Forms.TextBox txtCaminhoArquivo;
        private System.Windows.Forms.ColumnHeader cCodigo;
        private System.Windows.Forms.ColumnHeader cMarca;
        private System.Windows.Forms.ColumnHeader cModelo;
        private System.Windows.Forms.ColumnHeader cAno;
        private System.Windows.Forms.ColumnHeader cPreco;
        private System.Windows.Forms.Label lblTitulo;
    }
}

