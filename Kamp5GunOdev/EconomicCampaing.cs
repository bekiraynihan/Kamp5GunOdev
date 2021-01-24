using System;
using System.Collections.Generic;
using System.Text;

namespace Kamp5GunOdev
{
    class EconomicCampaing : ICampaignsManeger
    {
        public void Condition()
        {
            Console.WriteLine("Ekonomik kampanya Aktif");
        }

        public void DiscountPercent()
        {
            Console.WriteLine("%20 ekonomik indirim ");
        }

        public double GamePrice(double fiyat)
        {
            Double sonuc = (fiyat * (0.8));  
            Console.WriteLine("Bu kampanya ile ürün fiyat " + sonuc);
            return sonuc;
        }
    }
}
