using GameDemo.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
    class SummerSale : IDıscountService
    {
        double discountprice;
        public void DıscountForGame(Games games)
        {
            discountprice = (games.GamePrice * (0.55));
            games.GamePrice = (int)(games.GamePrice - discountprice);
            Console.WriteLine("Tebrikler ürününüze yaz indirimi uygulandı" + " " + games.GameName + " " + "Adlı oyunun indirimli fiyatı " + "="  + " " +  games.GamePrice + " " + "TL");
        }

        public void FınıshtoDiscount(Games games)
        {
            games.GamePrice = (int)(games.GamePrice - discountprice);
            Console.WriteLine("Üzgünüz , yaz indirimi sona erdi!");
        }
    }
}
