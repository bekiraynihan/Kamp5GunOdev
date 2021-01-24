using System;
using System.Collections.Generic;
using System.Text;

namespace Kamp5GunOdev
{
    class NormalCampaing : ICampaignsManeger
    {
        public void Condition()
        {
            Console.WriteLine("Normal kampanya Aktif");
        }

        public void DiscountPercent()
        {
            Console.WriteLine("%40 normal indirim ");
        }

        public double GamePrice(double fiyat)
        {
            Double sonuc = (fiyat * (0.6)); 
            Console.WriteLine("Bu kampanya ile ürün fiyat " + sonuc);
            return sonuc;
        }
    }
}
