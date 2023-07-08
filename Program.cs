using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myApps
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();

            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.nim = "1234";
            mhs1.namaMahasiswa = "erik";

            Mahasiswa mhs2 = new Mahasiswa();
            mhs2.nim = "4849";
            mhs2.namaMahasiswa = "linggar";

            Dosen dosen = new Dosen();
            dosen.nik = "0043";
            dosen.namaDosen = "Jhono";

            List<Mahasiswa> listMhs = new List<Mahasiswa>();

            listMhs.Add(mhs1);
            listMhs.Add(mhs2);

            Console.WriteLine();
            Console.WriteLine("Nim\tNama");
            Console.WriteLine("=============");

            foreach (Mahasiswa list in listMhs) Console.WriteLine($"{list.nim}\t{list.namaMahasiswa}");

            // Console.ReadKey();
        }
    }
}