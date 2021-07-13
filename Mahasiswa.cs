using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    public class Mahasiswa
    {
        public string nim { get; set; }
        public string nama { get; set; }
        public string kelamin { get; set; }
        public string ipk { get; set; }

        public void tambah()
        {
            Console.Write("\nNIM: ");
            Mahasiswa.nim = nim = Console.ReadLine();
            Console.Write("\nNama: ");
            Mahasiswa.nama = nama = Console.ReadLine();
            Console.Write("\nJenis Kelamin : ");
            Mahasiswa.kelamin = kelamin = Console.ReadLine();
            Console.Write("\nIPK : ");
            Mahasiswa.ipk = ipk = Console.ReadLine();

            daftarMahasiswa.Add(Mahasiswa);
        }

        public void tampil()
        {
            Console.WriteLine("\nData Mahasiswa");
            foreach (Mahasiswa mahasiswa in list)
            {
                Console.WriteLine("1. {0}, {1}, {2}, {3}, {4}, {5}", mahasiswa.nim, mahasiswa.nama, mahasiswa.kelamin, mahasiswa.ipk);
                Console.WriteLine("\n");
            }
        }
    }
}
