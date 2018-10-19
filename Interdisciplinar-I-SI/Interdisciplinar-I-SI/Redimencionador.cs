using System.Drawing;
using System.Drawing.Drawing2D;
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

            int sizeNxM = bitmap.Width * pixeis;
            var newBitmap = new Bitmap(sizeNxM, sizeNxM);

            var progressBar = new ProgressBar();
            progressBar.progressBarRedimencionamento.Maximum = bitmap.Width;
            progressBar.Show();
            progressBar.progressBarRedimencionamento.Value = 0;


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
            var imagemRedimencionada = newBitmap.GetThumbnailImage(newBitmap.Width, newBitmap.Height, null, System.IntPtr.Zero);
            progressBar.Close();
            return imagemRedimencionada;
        }

        public Image Inverter(Image imagem)
        {
            var progressBar = new ProgressBar();
            progressBar.progressBarRedimencionamento.Maximum = imagem.Width;
            progressBar.progressBarRedimencionamento.Value = 0;
            progressBar.Show();
            var bitmap = new Bitmap(imagem);
            var newBitmap = new Bitmap(imagem.Width, imagem.Height);
            for (int y = 0; y < imagem.Height; y++)
            {
                Parallel.For(0, bitmap.Width, x =>
                {
                    lock (newBitmap)
                    {
                        Color originalColor = bitmap.GetPixel(x, y);
                        Color corEmNegativo = Color.FromArgb(255 - originalColor.R, 255 - originalColor.G, 255 - originalColor.B);
                        newBitmap.SetPixel(x, y, corEmNegativo);
                    }
                });
                progressBar.progressBarRedimencionamento.Value = y;
            }
            progressBar.Close();
            return newBitmap.GetThumbnailImage(newBitmap.Width, newBitmap.Height, null, System.IntPtr.Zero); ;
        }

        public Image AntiAliasing(Image imagem)
        {
            using (Graphics graph = Graphics.FromImage(imagem))
            {
                graph.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graph.CompositingQuality = CompositingQuality.HighQuality;
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                graph.DrawImage(imagem, new Rectangle(0, 0, imagem.Width, imagem.Height));
                return imagem;
            }
        }
    }
}
