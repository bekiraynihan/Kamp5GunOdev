using System;
using System.Collections.Generic;
using System.Text;

namespace Kamp5GunOdev
{
    class SupperCampaing : ICampaignsManeger
    {
        public void Condition()
        {
            Console.WriteLine("Süper kampanya Aktif");
        }

        public void DiscountPercent()
        {
            Console.WriteLine("%60 süper indirim ");
        }

        public double GamePrice(double fiyat)
        {
            Double sonuc = (fiyat * (0.4)); 
            Console.WriteLine("Bu kampanya ile ürün fiyat " + sonuc);
            return sonuc;
        }

    }
}
