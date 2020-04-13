using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2650
{
    class Program
    {
        static void Main(string[] args)
        {

            Karyawan karyawan = new Karyawan(190302123, "Paijo", 3000000);
            Karyawan karyawan2 = new Karyawan(190302124, "Jono", 2000000);


            Console.WriteLine("NIK/Nama \t\t Gaji");
            Console.WriteLine("--------------------------");
            karyawan.showKaryawan();
            karyawan2.showKaryawan();

            Console.WriteLine("\n\n Asiqqq naik gaji nih");

            Console.WriteLine("NIK/Nama \t\t Gaji");
            Console.WriteLine("--------------------------");
            karyawan.naikgaji();
            karyawan2.naikgaji();

            Console.ReadKey();
        }
    }

    class Karyawan
    {
        public int nik { get; set; }
        public string nama { get; set; }
        public int gajiBulanan { get; set; }

        public Karyawan(int nik, string nama, int gaji)
        {
            this.nik = nik;
            this.nama = nama;

            if (gaji < 0)
            {
                this.gajiBulanan = 0;
            }
            else
            {
                this.gajiBulanan = gaji;
            }
        }

        public void showKaryawan()
        {
            Console.WriteLine("{0}/{1} \t\t {2}", nik, nama, gajiBulanan);
        }

        public void naikgaji()
        {
            double tmp = 0;
            tmp = 0.1 * gajiBulanan;
            gajiBulanan += Convert.ToInt32(tmp);
            Console.WriteLine("{0}/{1} \t\t {2}", nik, nama, gajiBulanan);
        }
    }
}
    
   

