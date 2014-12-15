using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;


namespace FunBMP
{
    class Program
    {
        static void Main(string[] args)
        {
            Bitmap img = new Bitmap(@"C:\Users\Sekanaya\Desktop\junk\Untitled.bmp");
            int w = img.Width;
            int h = img.Height;

            int z = 0;

            using (StreamWriter pWriter = new StreamWriter(@"C:\Users\sekanaya\Desktop\junk\points.txt"),
                cWriter = new StreamWriter(@"C:\Users\sekanaya\Desktop\junk\clusters.txt"))
            {
                int count = 0;
                double k = Math.Sqrt(Math.Pow(h, 2) + Math.Pow(w, 2));
                double d = 0.01;
                double g = 0.1;
                for (int i = 0; i < h; i++)
                {
                    for (int j = 0; j < w; j++)
                    {
                        Color c = img.GetPixel(j, i);
//                        if (c.Name.Equals("ff000000"))
//                        if (!c.Name.Equals("ffffffff"))
                        if (!c.Name.Equals("00000000"))
                        {
                            pWriter.WriteLine(count + "\t" + (d*j/k) + "\t" + (-d*i/k) + "\t" + z + "\t" + 1);
                        }

                        ++count;
                    }
                }

                Console.WriteLine("Read " + count + " pixels");
            }
//            Console.Read();
        }
    }
}
