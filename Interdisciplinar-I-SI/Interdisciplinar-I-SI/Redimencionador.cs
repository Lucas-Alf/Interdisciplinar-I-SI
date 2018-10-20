using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;

namespace Interdisciplinar_I_SI
{
    public class Redimencionador
    {
        public Image RedimencionarComMatriz(Image imagem, int pixeis)
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

        // static void MultiplyMatricesParallel(double[,] matA, double[,] matB, double[,] result)
        // {
        //   int matACols = matA.GetLength(1);
        //   int matBCols = matB.GetLength(1);
        //   int matARows = matA.GetLength(0);
        //
        ////   // A basic matrix multiplication.
        ////   // Parallelize the outer loop to partition the source array by rows.
        //   Parallel.For(0, matARows, i =>
        //   {
        //       for (int j = 0; j < matBCols; j++)
        //       {
        //           double temp = 0;
        //           for (int k = 0; k < matACols; k++)
        //           {
        //               temp += matA[i, k] * matB[k, j];
        //           }
        //           result[i, j] = temp;
        //      }
        //  }); // Parallel.For
        //}
    }
}
