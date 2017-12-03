namespace InverterPedroAmorim
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
            this.lblDigiteTexto = new System.Windows.Forms.Label();
            this.lblTextoInvertido = new System.Windows.Forms.Label();
            this.lblResposta = new System.Windows.Forms.Label();
            this.tbxInverter = new System.Windows.Forms.TextBox();
            this.btnInverter = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDigiteTexto
            // 
            this.lblDigiteTexto.AutoSize = true;
            this.lblDigiteTexto.Location = new System.Drawing.Point(56, 76);
            this.lblDigiteTexto.Name = "lblDigiteTexto";
            this.lblDigiteTexto.Size = new System.Drawing.Size(195, 17);
            this.lblDigiteTexto.TabIndex = 0;
            this.lblDigiteTexto.Text = "Digite um texto a ser invertido";
            // 
            // lblTextoInvertido
            // 
            this.lblTextoInvertido.AutoSize = true;
            this.lblTextoInvertido.Location = new System.Drawing.Point(56, 141);
            this.lblTextoInvertido.Name = "lblTextoInvertido";
            this.lblTextoInvertido.Size = new System.Drawing.Size(109, 17);
            this.lblTextoInvertido.TabIndex = 1;
            this.lblTextoInvertido.Text = "Texto invertido: ";
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(56, 158);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(144, 17);
            this.lblResposta.TabIndex = 2;
            this.lblResposta.Text = "_________________";
            // 
            // tbxInverter
            // 
            this.tbxInverter.Location = new System.Drawing.Point(59, 96);
            this.tbxInverter.MaxLength = 40;
            this.tbxInverter.Name = "tbxInverter";
            this.tbxInverter.Size = new System.Drawing.Size(297, 22);
            this.tbxInverter.TabIndex = 3;
            // 
            // btnInverter
            // 
            this.btnInverter.Location = new System.Drawing.Point(362, 95);
            this.btnInverter.Name = "btnInverter";
            this.btnInverter.Size = new System.Drawing.Size(75, 23);
            this.btnInverter.TabIndex = 4;
            this.btnInverter.Text = "Inverter";
            this.btnInverter.UseVisualStyleBackColor = true;
            this.btnInverter.Click += new System.EventHandler(this.btnInverter_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(73, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(337, 29);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "INVERTER CARACTERES";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(482, 208);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnInverter);
            this.Controls.Add(this.tbxInverter);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.lblTextoInvertido);
            this.Controls.Add(this.lblDigiteTexto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inverter Caracteres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDigiteTexto;
        private System.Windows.Forms.Label lblTextoInvertido;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.TextBox tbxInverter;
        private System.Windows.Forms.Button btnInverter;
        private System.Windows.Forms.Label lblTitulo;
    }
}

