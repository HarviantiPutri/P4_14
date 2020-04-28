using System;

namespace PRG2_20192_P1_4_14
{
    class Program
    {
        static void Main(string[] args)
        {
            float alas, tinggi, luas;
            double hipotenusa;
            double keliling;
            int pilihan;
            pilih: 

            Console.WriteLine("MENU SEGITIGA SIKU-SIKU");
            Console.WriteLine("a. Hitung Luas");
            Console.WriteLine("b. Hitung Hipotenusa");
            Console.WriteLine("c. Hitung Keliling");
            Console.WriteLine("d. Keluar");
            Console.Write("Masukkan Pilihan Menu [a, b, c, d] : ");

            pilihan = Convert.ToInt16(Console.ReadLine());

            switch (pilihan)
            {
                case 1 :
                    Console.Clear();

                    Console.WriteLine("PROGRAM LUAS SEGITIGA");
                    Console.WriteLine("=======================");

                    Console.Write("Masukkan alas : ");

                    alas = Convert.ToSingle(Console.ReadLine());

                    Console.Write("Masukkan tinggi : ");

                    tinggi = Convert.ToSingle(Console.ReadLine());

                    luas = alas * tinggi / 2;

                    Console.WriteLine("Luas Segitiga dengan alas " + alas + " dan " + tinggi + " adalah " + luas + " satuan ");
               
                    goto pilih; break;


                case 2:
                    Console.Clear();
                    Console.WriteLine("PROGRAM HIPOTENUSA");
                    Console.WriteLine("=======================");

                    Console.Write("Masukkan alas : ");
                    alas = Convert.ToSingle(Console.ReadLine());

                    Console.Write("Masukkan tinggi : ");
                    tinggi = Convert.ToSingle(Console.ReadLine());

                    hipotenusa = Math.Sqrt( alas * alas + tinggi * tinggi );

                    Console.Write("Hipotenusanya adalah " + hipotenusa);
                    Console.ReadKey();
                    Console.Clear();
                    goto pilih; break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("PROGRAM KELILING SEGITIGA");
                    Console.WriteLine("=======================");
                    Console.Write("Masukkan alas : ");
                    alas = Convert.ToSingle(Console.ReadLine());

                    Console.Write("masukkan tinggi : ");
                    tinggi = Convert.ToSingle(Console.ReadLine());

                    hipotenusa = Math.Sqrt(alas *alas  + tinggi * tinggi);
                    keliling = alas + tinggi + hipotenusa;

                    Console.Write("Hipotenusa " + hipotenusa);
                    Console.Write("keliling nya adalah " + keliling);
                    Console.ReadKey();
                    Console.Clear();
                    goto pilih; break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("TERIMAKASIH TELAH MENGGUNAKAN PROGRAM INI");
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Inputan anda salah");
                    Console.ReadKey();
                  
                    break;

            }
        }
    }
}

