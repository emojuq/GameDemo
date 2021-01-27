using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Interface
{
    interface IDıscountService
    {
        void DıscountForGame(Games games);
        void FınıshtoDiscount(Games games);
    }
}
