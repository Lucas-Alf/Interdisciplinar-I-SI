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
            this.buttonRedimencionarParalelo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPixeis = new System.Windows.Forms.TextBox();
            this.buttonRedimencionarEInverter = new System.Windows.Forms.Button();
            this.labelProporcao = new System.Windows.Forms.Label();
            this.buttonSalvarImagem = new System.Windows.Forms.Button();
            this.buttonRedimencionarSequencial = new System.Windows.Forms.Button();
            this.labelTempoSequencial = new System.Windows.Forms.Label();
            this.labelTempoParalelo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxImagem
            // 
            this.pictureBoxImagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxImagem.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxImagem.Location = new System.Drawing.Point(187, -3);
            this.pictureBoxImagem.Name = "pictureBoxImagem";
            this.pictureBoxImagem.Size = new System.Drawing.Size(650, 530);
            this.pictureBoxImagem.TabIndex = 0;
            this.pictureBoxImagem.TabStop = false;
            // 
            // buttonInputImage
            // 
            this.buttonInputImage.Location = new System.Drawing.Point(12, 12);
            this.buttonInputImage.Name = "buttonInputImage";
            this.buttonInputImage.Size = new System.Drawing.Size(164, 23);
            this.buttonInputImage.TabIndex = 1;
            this.buttonInputImage.Text = "Selecionar Imagem";
            this.buttonInputImage.UseVisualStyleBackColor = true;
            this.buttonInputImage.Click += new System.EventHandler(this.buttonInputImage_Click);
            // 
            // buttonRedimencionarParalelo
            // 
            this.buttonRedimencionarParalelo.Location = new System.Drawing.Point(11, 125);
            this.buttonRedimencionarParalelo.Name = "buttonRedimencionarParalelo";
            this.buttonRedimencionarParalelo.Size = new System.Drawing.Size(164, 23);
            this.buttonRedimencionarParalelo.TabIndex = 3;
            this.buttonRedimencionarParalelo.Text = "Redimencionar (Paralelo)";
            this.buttonRedimencionarParalelo.UseVisualStyleBackColor = true;
            this.buttonRedimencionarParalelo.Click += new System.EventHandler(this.buttonRedimencionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Proporção de pixeis:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxPixeis
            // 
            this.textBoxPixeis.Location = new System.Drawing.Point(113, 43);
            this.textBoxPixeis.Name = "textBoxPixeis";
            this.textBoxPixeis.Size = new System.Drawing.Size(31, 20);
            this.textBoxPixeis.TabIndex = 4;
            this.textBoxPixeis.TextChanged += new System.EventHandler(this.textBoxPorcento_TextChanged);
            this.textBoxPixeis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPorcento_KeyPress);
            // 
            // buttonRedimencionarEInverter
            // 
            this.buttonRedimencionarEInverter.Location = new System.Drawing.Point(11, 154);
            this.buttonRedimencionarEInverter.Name = "buttonRedimencionarEInverter";
            this.buttonRedimencionarEInverter.Size = new System.Drawing.Size(164, 23);
            this.buttonRedimencionarEInverter.TabIndex = 6;
            this.buttonRedimencionarEInverter.Text = "Inverter cor";
            this.buttonRedimencionarEInverter.UseVisualStyleBackColor = true;
            this.buttonRedimencionarEInverter.Click += new System.EventHandler(this.buttonInverterCor_Click);
            // 
            // labelProporcao
            // 
            this.labelProporcao.AutoSize = true;
            this.labelProporcao.Location = new System.Drawing.Point(145, 47);
            this.labelProporcao.Name = "labelProporcao";
            this.labelProporcao.Size = new System.Drawing.Size(24, 13);
            this.labelProporcao.TabIndex = 7;
            this.labelProporcao.Text = "0x0";
            // 
            // buttonSalvarImagem
            // 
            this.buttonSalvarImagem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSalvarImagem.Location = new System.Drawing.Point(15, 488);
            this.buttonSalvarImagem.Name = "buttonSalvarImagem";
            this.buttonSalvarImagem.Size = new System.Drawing.Size(161, 23);
            this.buttonSalvarImagem.TabIndex = 9;
            this.buttonSalvarImagem.Text = "Salvar Imagem";
            this.buttonSalvarImagem.UseVisualStyleBackColor = true;
            this.buttonSalvarImagem.Click += new System.EventHandler(this.buttonSalvarImagem_Click);
            // 
            // buttonRedimencionarSequencial
            // 
            this.buttonRedimencionarSequencial.Location = new System.Drawing.Point(12, 96);
            this.buttonRedimencionarSequencial.Name = "buttonRedimencionarSequencial";
            this.buttonRedimencionarSequencial.Size = new System.Drawing.Size(163, 23);
            this.buttonRedimencionarSequencial.TabIndex = 10;
            this.buttonRedimencionarSequencial.Text = "Redimencionar (Sequencial)";
            this.buttonRedimencionarSequencial.UseVisualStyleBackColor = true;
            this.buttonRedimencionarSequencial.Click += new System.EventHandler(this.buttonRedimencionarSequencial_Click);
            // 
            // labelTempoSequencial
            // 
            this.labelTempoSequencial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTempoSequencial.AutoSize = true;
            this.labelTempoSequencial.Location = new System.Drawing.Point(15, 441);
            this.labelTempoSequencial.Name = "labelTempoSequencial";
            this.labelTempoSequencial.Size = new System.Drawing.Size(97, 13);
            this.labelTempoSequencial.TabIndex = 11;
            this.labelTempoSequencial.Text = "Tempo sequencial:";
            this.labelTempoSequencial.Click += new System.EventHandler(this.labelTempoSequencial_Click);
            // 
            // labelTempoParalelo
            // 
            this.labelTempoParalelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTempoParalelo.AutoSize = true;
            this.labelTempoParalelo.Location = new System.Drawing.Point(15, 458);
            this.labelTempoParalelo.Name = "labelTempoParalelo";
            this.labelTempoParalelo.Size = new System.Drawing.Size(83, 13);
            this.labelTempoParalelo.TabIndex = 12;
            this.labelTempoParalelo.Text = "Tempo paralelo:";
            // 
            // FormImagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(834, 523);
            this.Controls.Add(this.labelTempoParalelo);
            this.Controls.Add(this.labelTempoSequencial);
            this.Controls.Add(this.buttonRedimencionarSequencial);
            this.Controls.Add(this.buttonSalvarImagem);
            this.Controls.Add(this.pictureBoxImagem);
            this.Controls.Add(this.labelProporcao);
            this.Controls.Add(this.buttonRedimencionarEInverter);
            this.Controls.Add(this.textBoxPixeis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRedimencionarParalelo);
            this.Controls.Add(this.buttonInputImage);
            this.Name = "FormImagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Redimencionador de Imagens";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormImagem_FormClosed);
            this.Load += new System.EventHandler(this.FormImagem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxImagem;
        private System.Windows.Forms.Button buttonInputImage;
        private System.Windows.Forms.Button buttonRedimencionarParalelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPixeis;
        private System.Windows.Forms.Button buttonRedimencionarEInverter;
        private System.Windows.Forms.Label labelProporcao;
        private System.Windows.Forms.Button buttonSalvarImagem;
        private System.Windows.Forms.Button buttonRedimencionarSequencial;
        private System.Windows.Forms.Label labelTempoSequencial;
        private System.Windows.Forms.Label labelTempoParalelo;
    }
}

