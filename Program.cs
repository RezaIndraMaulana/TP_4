using System;

namespace tpmodul4_103022300109
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Daftar Kelurahan");
            Console.WriteLine("Kelurahan\t |    Kode Pos");
            Console.WriteLine("-------------------------------");
            foreach (KodePos.kelurahan kelurahan in Enum.GetValues(typeof(KodePos.kelurahan)))
            {
                String namaKelurahan = kelurahan.ToString();
                Console.WriteLine($"{kelurahan}\t | {KodePos.getKodePos(kelurahan)}");
            }
        }
    }
}