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

            Console.WriteLine("-------------------------------");

            DoorMachine doorMachine = new DoorMachine();

            doorMachine.getStatusPintu();   
            String input = "";
            while (input != "keluar")
            {
                Console.WriteLine("Perintah (bukaPintu / kunciPintu)");
                input = Console.ReadLine();
                if(Enum.TryParse(input, out kegiatan kegiatan))
                {
                    doorMachine.ubahPintu(kegiatan);
                }
                else
                {
                    Console.WriteLine("Perintah tidak valid");
                }
            }
            Console.WriteLine("-----------------------------");
        }
    }
}