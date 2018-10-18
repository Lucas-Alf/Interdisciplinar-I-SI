using System.Drawing;
using System.Threading.Tasks;

namespace Interdisciplinar_I_SI
{
    public class Redimencionador
    {
        public Image RedimencionarComMatriz(Image imagem, int pixeis)
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

            int sizeNxM = bitmap.Width * pixeis; //bitmap.Width + (porcento * bitmap.Width / 100);
            var newBitmap = new Bitmap(sizeNxM, sizeNxM);

            var progressBar = new ProgressBar();
            progressBar.progressBarRedimencionamento.Maximum = bitmap.Width;
            progressBar.Show();
            progressBar.progressBarRedimencionamento.Value = 0;


            //Color CorEmNegativo = Color.FromArgb(255 - originalColor.R, 255 - originalColor.G, 255 - originalColor.B);
            for (int y = 0; y < bitmap.Height; y++)
            {
                Parallel.For(0, bitmap.Width, x =>
                {
                    lock (newBitmap)
                    {
                        for (int i = 0; i < pixeis; i++)
                        {
                            for (int j = 0; j < pixeis; j++)
                            {
                                Color originalColor = bitmap.GetPixel(x, y);
                                newBitmap.SetPixel(i + (x + ((x * pixeis) - x)), j + (y + ((y * pixeis) - y)), originalColor);
                            }
                        }
                    }
                });
                progressBar.progressBarRedimencionamento.Value = y;
            }
            var formResultado = new FormResultado();
            formResultado.pictureBoxResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            formResultado.Height = newBitmap.Height;
            formResultado.Width = newBitmap.Width;
            var imagem2 = newBitmap.GetThumbnailImage(newBitmap.Width, newBitmap.Height, null, System.IntPtr.Zero);
            formResultado.pictureBoxResultado.Image = imagem2;
            formResultado.Show();
            progressBar.Close();
            return imagem2;
        }
    }
}
