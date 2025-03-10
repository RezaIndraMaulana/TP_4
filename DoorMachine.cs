using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_103022300109
{
    public enum pintu { terkunci, terbuka };
    public enum kegiatan { bukaPintu, kunciPintu };
    class DoorMachine
    {
        private pintu state;
        public DoorMachine()
        {
            state = pintu.terkunci;
        }

        public void ubahPintu(kegiatan option) {
            switch (state) {
                case pintu.terkunci:
                    if (option == kegiatan.bukaPintu)
                    {
                        Console.WriteLine("Pintu tidak terkunci");
                        state = pintu.terbuka;
                    }
                    else
                    {
                        Console.WriteLine("Pintu sudah terkunci");
                    }
                    break;
                case pintu.terbuka:
                    if (option == kegiatan.kunciPintu)
                    {
                        Console.WriteLine("Pintu terkunci");
                        state = pintu.terkunci;
                    }
                    else
                    {
                        Console.WriteLine("Pintu sudah terbuka");
                    }
                    break;
            }
        }
        public void getStatusPintu()
        {
            Console.WriteLine("Status Pintu: " + state);
        }
    }
}
