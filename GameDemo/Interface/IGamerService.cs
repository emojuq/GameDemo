using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Interface
{
   public interface IGamerService
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int DateOfBirth { get; set; }
        public string TCNo { get; set; }
    }
}
