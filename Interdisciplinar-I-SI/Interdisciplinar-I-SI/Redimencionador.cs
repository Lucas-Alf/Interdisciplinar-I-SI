using System.Drawing;

namespace Interdisciplinar_I_SI
{
    public class Redimencionador
    {
        public Image RedimencionarComMatriz(Image imagem, int porcento)
        {
            var size = imagem.Size;
            var bitmap = new Bitmap(imagem);
            int[,] matriz = new int[bitmap.Size.Height, bitmap.Size.Width];
            for (int x = 0; x < bitmap.Size.Width; x++)
            {
                for (int y = 0; y < bitmap.Size.Height; y++)
                {
                    matriz[x, y] = bitmap.GetPixel(x, y).ToArgb();
                }
            }

            int newWidth = bitmap.Width + (porcento * bitmap.Width / 100);
            int newHeight = bitmap.Height + (porcento * bitmap.Height / 100);
            var newBitmap = new Bitmap(newWidth, newHeight);

            var progressBar = new ProgressBar();
            progressBar.progressBarRedimencionamento.Maximum = bitmap.Size.Height;
            progressBar.Show();
            progressBar.progressBarRedimencionamento.Value = 0;


            for (int y = 0; y < bitmap.Size.Height; y++)
            {
                for (int x = 0; x < bitmap.Size.Width; x++)
                {
                    for (int i = 0; i <= (porcento * bitmap.Width / 100); i++)
                    {
                        for (int j = 0; j <= (porcento * bitmap.Height / 100); j++)
                        {
                            newBitmap.SetPixel(x + i, y + j, Color.FromArgb(matriz[x, y]));
                        }
                    }
                }
                progressBar.progressBarRedimencionamento.Value = y;
            }

            progressBar.Close();

            var formResultado = new FormResultado();
            formResultado.pictureBoxResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            var imagem2 = newBitmap.GetThumbnailImage(newBitmap.Width, newBitmap.Height, null, System.IntPtr.Zero);
            formResultado.Height = newHeight + (porcento * newHeight / 100);
            formResultado.Width = newWidth + +(porcento * newWidth / 100);
            formResultado.Show();
            formResultado.pictureBoxResultado.Image = imagem2;
            return imagem;
        }
    }
}
