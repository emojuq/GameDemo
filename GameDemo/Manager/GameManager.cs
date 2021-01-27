using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Manager
{
    class GameManager
    {
        public void Add(Games games)
        {
            Console.WriteLine(games.GameName + " " +  "adlı oyun sisteme eklenmiştir!" );
        }

        public void Update(Games games)
        {
            Console.WriteLine(games.GameName + " " + "adlı oyun sistemde güncellenmiştir!");
        }

        public void Delete(Games games)
        {
            Console.WriteLine(games.GameName + " " + "adlı oyun sistemden silinmiştir!");
        }
    }
}
