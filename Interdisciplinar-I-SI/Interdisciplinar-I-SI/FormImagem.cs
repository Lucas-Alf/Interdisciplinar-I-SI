using System;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Interdisciplinar_I_SI
{
    public partial class FormImagem : Form
    {
        public FormImagem()
        {
            InitializeComponent();
        }

        private void labelPath_Click(object sender, EventArgs e)
        {

        }

        private void buttonInputImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (file.ShowDialog() == DialogResult.OK)
            {
                pictureBoxImagem.SizeMode = PictureBoxSizeMode.CenterImage;
                pictureBoxImagem.ImageLocation = file.FileName;
            }
        }

        private void buttonRedimencionar_Click(object sender, EventArgs e)
        {
            if (validaImagem())
            {
                Stopwatch bechmarkinson = new Stopwatch();
                bechmarkinson.Start();
                var imagem = new Redimencionador().RedimencionarParalelo(pictureBoxImagem.Image, Convert.ToInt32(textBoxPixeis.Text));
                bechmarkinson.Stop();
                labelTempoParalelo.Text = "Tempo paralelo: " + bechmarkinson.Elapsed.TotalSeconds + "s";
                pictureBoxImagem.Image = imagem;
            }
        }

        private void textBoxPorcento_TextChanged(object sender, EventArgs e)
        {
            int numero;
            if (Int32.TryParse(textBoxPixeis.Text, out numero))
            {
                if (numero < 0)
                {
                    textBoxPixeis.Text = "";
                }
                else
                {
                    labelProporcao.Text = numero + "x" + numero;
                }
            }
            else
            {
                textBoxPixeis.Text = "";
            }
        }

        private void textBoxPorcento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        public void backgroundWorkerProgressBar_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void progressBarRedimencionamento_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormImagem_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public bool validaImagem()
        {
            if (pictureBoxImagem.Image == null)
            {
                MessageBox.Show("Nenhuma imagem foi selecionada!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                if (pictureBoxImagem.Image.Height != pictureBoxImagem.Image.Width)
                {
                    MessageBox.Show("A imagem não é quadrada!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                {
                    if (String.IsNullOrEmpty(textBoxPixeis.Text) || Convert.ToInt32(textBoxPixeis.Text) <= 0)
                    {
                        MessageBox.Show("A proporção de pixeis não foi informada!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }

        private void buttonInverterCor_Click(object sender, EventArgs e)
        {
            if (pictureBoxImagem.Image == null)
            {
                MessageBox.Show("Nenhuma imagem foi selecionada!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (pictureBoxImagem.Image.Height != pictureBoxImagem.Image.Width)
                {
                    MessageBox.Show("A imagem não é quadrada!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var imagem = new Redimencionador().InverterCor(pictureBoxImagem.Image);
                    pictureBoxImagem.Image = imagem;
                }
            }
        }

        private void FormImagem_Load(object sender, EventArgs e)
        {

        }

        private void buttonAntiAliasing_Click(object sender, EventArgs e)
        {
            if (validaImagem())
            {
                var imagem = new Redimencionador().AntiAliasing(pictureBoxImagem.Image);
                pictureBoxImagem.Image = imagem;
                MessageBox.Show("Filtro aplicado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonSalvarImagem_Click(object sender, EventArgs e)
        {
            if (pictureBoxImagem.Image != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Images|*.png;*.bmp;*.jpg";
                ImageFormat format = ImageFormat.Png;
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string ext = System.IO.Path.GetExtension(sfd.FileName);
                    switch (ext)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                    }
                    pictureBoxImagem.Image.Save(sfd.FileName, format);
                }
            }
            else
            {
                MessageBox.Show("Nenhuma imagem foi selecionada!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonRedimencionarSequencial_Click(object sender, EventArgs e)
        {
            if (validaImagem())
            {
                Stopwatch bechmarkinson = new Stopwatch();
                bechmarkinson.Start();
                var imagem = new Redimencionador().RedimencionarSequencial(pictureBoxImagem.Image, Convert.ToInt32(textBoxPixeis.Text));
                bechmarkinson.Stop();
                labelTempoSequencial.Text = "Tempo sequencial: " + bechmarkinson.Elapsed.TotalSeconds + "s";
                pictureBoxImagem.Image = imagem;
            }
        }

        private void labelTempoSequencial_Click(object sender, EventArgs e)
        {

        }
    }
}
