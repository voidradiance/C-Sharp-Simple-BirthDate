using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgungSetiawan_Exercise1_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Masukkan tanggal ulang anda :");
            int tanggal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukan bulan ulang tahun anda :");
            int bulan = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukan tahun ulang tahun anda :");
            int tahun = Convert.ToInt32(Console.ReadLine());

            DateTime birthDate = new DateTime(tahun,bulan,tanggal);

            TimeSpan umur = DateTime.Now - birthDate;
            int umurNow = Convert.ToInt32(umur.TotalDays) / 365;

            Console.WriteLine("Masukan nama anda :");
            string namaAnda = Console.ReadLine();

            Console.WriteLine("Menghitung umur {0}",namaAnda);
            Console.WriteLine("Umur anda adalah {0} tahun", umurNow);

        }
    }
}
