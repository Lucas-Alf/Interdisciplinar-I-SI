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
                pictureBoxImagem.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBoxImagem.ImageLocation = file.FileName;
            }
        }

        private void buttonRedimencionar_Click(object sender, EventArgs e)
        {
            new Redimencionador().RedimencionarComMatriz(pictureBoxImagem.Image);
        }
    }
}
