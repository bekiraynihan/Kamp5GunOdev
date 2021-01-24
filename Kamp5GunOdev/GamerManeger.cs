using System;
using System.Collections.Generic;
using System.Text;

namespace Kamp5GunOdev
{
    class GamerManeger
    {
        public void Add(Gamers gamer)
        {
            Console.WriteLine("Eklendi");
        }
        public void Update(Gamers gamer)
        {
            Console.WriteLine("Güncellendi");
        }

        public void Delete(Gamers gamer)
        {
            Console.WriteLine("Silindi");
        }
    }
}
