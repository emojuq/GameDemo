using GameDemo.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Manager
{
    class GamerManager
    {
        public void Add(IGamerService gamerService)
        {
            Console.WriteLine(gamerService.Name + " " + gamerService.LastName + " " + "adlı oyuncu sisteme eklenmiştir! " );
        }
        public void Update(IGamerService gamerService)
        {
            Console.WriteLine(gamerService.Name + " " + gamerService.LastName + " " + "adlı oyuncu sistemde güncellenmiştir! ");
        }
        public void Delete(IGamerService gamerService)
        {
            Console.WriteLine(gamerService.Name + " "  + gamerService.LastName + " "  + "adlı oyuncu sistemden silinmiştir! ");
        }
    }
}
