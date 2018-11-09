using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;

namespace Interdisciplinar_I_SI
{
    public class Redimencionador
    {
        public Image RedimencionarParalelo(Image imagem, int pixeis)
        {
            var bitmap = new Bitmap(imagem);
            var progressBar = new ProgressBar();
            progressBar.progressBarRedimencionamento.Maximum = bitmap.Size.Width + bitmap.Height + (bitmap.Width * pixeis);
            progressBar.Show();

            Color[,] matriz = new Color[bitmap.Size.Height, bitmap.Size.Width];
            for (int x = 0; x < bitmap.Size.Width; x++)
            {
                for (int y = 0; y < bitmap.Size.Height; y++)
                {
                    matriz[x, y] = bitmap.GetPixel(x, y);
                }
                progressBar.progressBarRedimencionamento.Value += 1;
            }

            Color[,] novaMatriz = new Color[bitmap.Width * pixeis, bitmap.Height * pixeis];
            for (int y = 0; y < bitmap.Height; y++)
            {
                Parallel.For(0, bitmap.Width, x =>
                {
                    for (int i = 0; i < pixeis; i++)
                    {
                        for (int j = 0; j < pixeis; j++)
                        {
                            novaMatriz[i + (x + ((x * pixeis) - x)), j + (y + ((y * pixeis) - y))] = matriz[x, y];
                        }
                    }
                });
                progressBar.progressBarRedimencionamento.Value += 1;
            }

            var newBitmap = new Bitmap(bitmap.Width * pixeis, bitmap.Height * pixeis);
            for (int x = 0; x < bitmap.Width * pixeis; x++)
            {
                for (int y = 0; y < bitmap.Height * pixeis; y++)
                {
                    newBitmap.SetPixel(x, y, novaMatriz[x, y]);
                }
                progressBar.progressBarRedimencionamento.Value += 1;
            }

            var imagemRedimencionada = newBitmap.GetThumbnailImage(newBitmap.Width, newBitmap.Height, null, System.IntPtr.Zero);
            progressBar.Close();
            return imagemRedimencionada;
        }

        public Image RedimencionarSequencial(Image imagem, int pixeis)
        {
            var bitmap = new Bitmap(imagem);
            var progressBar = new ProgressBar();
            progressBar.progressBarRedimencionamento.Maximum = bitmap.Size.Width + bitmap.Height + (bitmap.Width * pixeis);
            progressBar.Show();

            Color[,] matriz = new Color[bitmap.Size.Height, bitmap.Size.Width];
            for (int x = 0; x < bitmap.Size.Width; x++)
            {
                for (int y = 0; y < bitmap.Size.Height; y++)
                {
                    matriz[x, y] = bitmap.GetPixel(x, y);
                }
                progressBar.progressBarRedimencionamento.Value += 1;
            }

            Color[,] novaMatriz = new Color[bitmap.Width * pixeis, bitmap.Height * pixeis];
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    for (int i = 0; i < pixeis; i++)
                    {
                        for (int j = 0; j < pixeis; j++)
                        {
                            novaMatriz[i + (x + ((x * pixeis) - x)), j + (y + ((y * pixeis) - y))] = matriz[x, y];
                        }
                    }
                }
                progressBar.progressBarRedimencionamento.Value += 1;
            }

            var newBitmap = new Bitmap(bitmap.Width * pixeis, bitmap.Height * pixeis);
            for (int x = 0; x < bitmap.Width * pixeis; x++)
            {
                for (int y = 0; y < bitmap.Height * pixeis; y++)
                {
                    newBitmap.SetPixel(x, y, novaMatriz[x, y]);
                }
                progressBar.progressBarRedimencionamento.Value += 1;
            }

            var imagemRedimencionada = newBitmap.GetThumbnailImage(newBitmap.Width, newBitmap.Height, null, System.IntPtr.Zero);
            progressBar.Close();
            return imagemRedimencionada;
        }

        public Image InverterCor(Image imagem)
        {
            var progressBar = new ProgressBar();
            progressBar.progressBarRedimencionamento.Maximum = imagem.Width * 3;
            progressBar.progressBarRedimencionamento.Value = 0;
            progressBar.Show();

            var bitmap = new Bitmap(imagem);
            Color[,] matriz = new Color[bitmap.Size.Height, bitmap.Size.Width];
            for (int x = 0; x < bitmap.Size.Width; x++)
            {
                for (int y = 0; y < bitmap.Size.Height; y++)
                {
                    matriz[x, y] = bitmap.GetPixel(x, y);
                }
                progressBar.progressBarRedimencionamento.Value += 1;
            }

            Color[,] novaMatriz = new Color[bitmap.Width, bitmap.Height];
            for (int y = 0; y < bitmap.Height; y++)
            {
                Parallel.For(0, bitmap.Width, x =>
                {
                    novaMatriz[x, y] = Color.FromArgb(255 - matriz[x, y].R, 255 - matriz[x, y].G, 255 - matriz[x, y].B);
                });
                progressBar.progressBarRedimencionamento.Value += 1;
            }

            var newBitmap = new Bitmap(imagem.Width, imagem.Height);
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    newBitmap.SetPixel(x, y, novaMatriz[x, y]);
                }
                progressBar.progressBarRedimencionamento.Value += 1;
            }

            progressBar.Close();
            return newBitmap.GetThumbnailImage(newBitmap.Width, newBitmap.Height, null, System.IntPtr.Zero);
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
