using System;
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
            file.Filter = "jpg|*.jpg";
            if (file.ShowDialog() == DialogResult.OK)
            {
                pictureBoxImagem.SizeMode = PictureBoxSizeMode.CenterImage;
                pictureBoxImagem.ImageLocation = file.FileName;
            }
        }

        private void buttonRedimencionar_Click(object sender, EventArgs e)
        {
            if (pictureBoxImagem.Image == null)
            {
                MessageBox.Show("Nenhuma imagem foi selecionada!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                if (pictureBoxImagem.Image.Height != pictureBoxImagem.Image.Width)
                {
                    MessageBox.Show("A imagem não é quadrada!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    if (String.IsNullOrEmpty(textBoxPorcento.Text))
                    {
                        MessageBox.Show("Informe um percentual!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        new Redimencionador().RedimencionarComMatriz(pictureBoxImagem.Image, Convert.ToInt32(textBoxPorcento.Text));
                    }
                }
            }
        }

        private void textBoxPorcento_TextChanged(object sender, EventArgs e)
        {

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
    }
}
