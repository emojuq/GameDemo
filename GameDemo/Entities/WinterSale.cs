using GameDemo.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
    class WinterSale : IDıscountService
    {
        double discountprice;


        public void DıscountForGame(Games games)
        {
            discountprice = (games.GamePrice * (0.75));
            games.GamePrice = (int)(games.GamePrice - discountprice);
            Console.WriteLine("Tebrikler, kış indirimi uygulandı"+ " " + games.GameName + " " + "Adlı oyunun İndirimli fiyatı  " + "=" + " " + games.GamePrice + " "+ "TL");
        }

        public void FınıshtoDiscount(Games games)
        {
            games.GamePrice = (int)(games.GamePrice + discountprice);
            Console.WriteLine("Üzgünüz , kış indiriminin süresi sona erdi");
        }
    }
}
