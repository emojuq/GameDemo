using GameDemo.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
   public class Gamer : IGamerService
    {
      
        public int GamerId { get; set; }
        public string Name { get; set ; }
        public string LastName { get ; set; }
        public int DateOfBirth { get; set; }
        public string TCNo { get; set ; }
    }
}
