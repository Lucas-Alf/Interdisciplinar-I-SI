namespace Interdisciplinar_I_SI
{
    partial class FormImagem
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
            this.pictureBoxImagem = new System.Windows.Forms.PictureBox();
            this.buttonInputImage = new System.Windows.Forms.Button();
            this.buttonRedimencionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxImagem
            // 
            this.pictureBoxImagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxImagem.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxImagem.Location = new System.Drawing.Point(-2, -3);
            this.pictureBoxImagem.Name = "pictureBoxImagem";
            this.pictureBoxImagem.Size = new System.Drawing.Size(503, 415);
            this.pictureBoxImagem.TabIndex = 0;
            this.pictureBoxImagem.TabStop = false;
            // 
            // buttonInputImage
            // 
            this.buttonInputImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonInputImage.Location = new System.Drawing.Point(12, 420);
            this.buttonInputImage.Name = "buttonInputImage";
            this.buttonInputImage.Size = new System.Drawing.Size(114, 23);
            this.buttonInputImage.TabIndex = 1;
            this.buttonInputImage.Text = "Selecionar Imagem";
            this.buttonInputImage.UseVisualStyleBackColor = true;
            this.buttonInputImage.Click += new System.EventHandler(this.buttonInputImage_Click);
            // 
            // buttonRedimencionar
            // 
            this.buttonRedimencionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRedimencionar.Location = new System.Drawing.Point(392, 420);
            this.buttonRedimencionar.Name = "buttonRedimencionar";
            this.buttonRedimencionar.Size = new System.Drawing.Size(92, 23);
            this.buttonRedimencionar.TabIndex = 3;
            this.buttonRedimencionar.Text = "Redimencionar";
            this.buttonRedimencionar.UseVisualStyleBackColor = true;
            this.buttonRedimencionar.Click += new System.EventHandler(this.buttonRedimencionar_Click);
            // 
            // FormImagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(501, 450);
            this.Controls.Add(this.buttonRedimencionar);
            this.Controls.Add(this.buttonInputImage);
            this.Controls.Add(this.pictureBoxImagem);
            this.Name = "FormImagem";
            this.Text = "Redimencionador de Imagens";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImagem;
        private System.Windows.Forms.Button buttonInputImage;
        private System.Windows.Forms.Button buttonRedimencionar;
    }
}

