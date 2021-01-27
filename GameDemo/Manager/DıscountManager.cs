using GameDemo.Entities;
using GameDemo.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Manager
{
    class DıscountManager
    {
        public void Dıscount(Games games , IGamerService gamerService)
        {
            Console.WriteLine(gamerService.Name + " " + gamerService.LastName + " " + "adlı oyuncu" + " " + games.GameName + " " + "Adlı oyunu" + " " + games.GamePrice + " " + "Tl'ye satın aldı" );
        }

        public void Add(Campaign campaign)
        {
            Console.Write("Tebrikler "+ " " + campaign.CampaignName + " " + "adlı yeni kampanyamız sisteme eklendi ");
        }

        public void Update(Campaign campaign)
        {
            Console.Write("Tebrikler " + " " + campaign.CampaignName + " " + "adlı yeni kampanyamız sistemde güncellendi ");
        }

        public void Delete(Campaign campaign)
        {
            Console.Write("Tebrikler " + " " + campaign.CampaignName + " " + "adlı yeni kampanyamız sistemden silindi ");
        }
    }
}
