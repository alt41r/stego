using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using crypto1;


namespace crypto1
{
    static class Program
    {

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void StartR(int width, int height, Bitmap image)
        {
            string file = Form1.filename;
            image = new Bitmap($"{file}");
            width = image.Width;
            height = image.Height;
            byte[] strBytes = Encoding.Unicode.GetBytes(Form1.str);
            byte[] bits = new byte[strBytes.Length];
            int idx = 0;
            for (int i = 0; i < width; i++)
            {
                if (idx < bits.Length)
                {
                    for (int j = 0; j < height; j++)
                    {
                        if (idx < bits.Length)
                        {
                            Color pixel = image.GetPixel(i, j);
                            if (bits[idx] == 0)
                            {
                                int a = pixel.A;
                                int g = pixel.G;
                                int b = pixel.B;
                                int r = pixel.R & 1;
                                Form1.nov = Color.FromArgb(a, r, g, b);

                            }
                            else
                            {
                                int a = pixel.A;
                                int g = pixel.G;
                                int b = pixel.B;
                                int r = pixel.R | 254;
                                Form1.nov = Color.FromArgb(a, r, g, b);
                            }

                            image.SetPixel(i, j, Form1.nov);
                            idx += 1;
                        }
                        else
                            break;
                    }
                }
                else
                    break;

            }
            image.Save($"{file}.crypt");
            Application.Exit();
        }
        public static void StartG(int width, int height, Bitmap image)
        {

            string file = Form1.filename;
            image = new Bitmap($"{file}");
            width = image.Width;
            height = image.Height;
            byte[] strBytes = Encoding.Unicode.GetBytes(Form1.str);
            byte[] bits = new byte[strBytes.Length];
            int idx = 0;
            for (int i = 0; i < width; i++)
            {
                if (idx < bits.Length)
                {
                    for (int j = 0; j < height; j++)
                    {
                        if (idx < bits.Length)
                        {
                            Color pixel = image.GetPixel(i, j);
                            if (bits[idx] == 0)
                            {
                                int a = pixel.A;
                                int g = pixel.G & 254;
                                int b = pixel.B;
                                int r = pixel.R ;
                                Form1.nov = Color.FromArgb(a, r, g, b);

                            }
                            else
                            {
                                int a = pixel.A;
                                int g = pixel.G | 1;
                                int b = pixel.B;
                                int r = pixel.R;
                                Form1.nov = Color.FromArgb(a, r, g, b);
                            }

                            image.SetPixel(i, j, Form1.nov);
                            idx += 1;
                        }
                        else
                            break;
                    }
                }
                else
                    break;

            }
            image.Save($"{file}.crypt");
            Application.Exit();
        }    

        public static void StartB(int width, int height, Bitmap image)
        {
            string file = Form1.filename;
            image = new Bitmap($"{file}");
            width = image.Width;
            height = image.Height;
            byte[] strBytes = Encoding.Unicode.GetBytes(Form1.str);
            byte[] bits = new byte[strBytes.Length];
            int idx = 0;
            for (int i = 0; i < width; i++)
            {
                if (idx < bits.Length )
                {
                    for (int j = 0; j < height; j++)
                    {
                        if (idx < bits.Length)
                        {
                            Color pixel = image.GetPixel(i, j);
                            if (bits[idx] == 0)
                            {
                                int a = pixel.A;
                                int g = pixel.G;
                                int b = pixel.B & 254;
                                int r = pixel.R;
                                Form1.nov = Color.FromArgb(a, r, g, b);
                                
                            }
                            else
                            {
                                int a = pixel.A;
                                int g = pixel.G;
                                int b = pixel.B | 1;
                                int r = pixel.R;
                                Form1.nov = Color.FromArgb(a, r, g, b);
                            }

                            image.SetPixel(i, j, Form1.nov);
                            idx += 1;
                        }
                        else
                            break;
                    }
                }
                else
                    break;

            }
            image.Save($"{file}.crypt");
            Application.Exit();
        }
    }
}
