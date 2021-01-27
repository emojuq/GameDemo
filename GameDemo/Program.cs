using GameDemo.Entities;
using GameDemo.Manager;
using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.Name = "Emre";
            gamer1.LastName = "Aydın";
            gamer1.TCNo = "1234567890";
            gamer1.DateOfBirth = 2002;
            gamer1.GamerId = 1;

            Gamer gamer2 = new Gamer();
            gamer2.Name = "Ahmet";
            gamer2.LastName = "Keleş";
            gamer2.TCNo = "3216549870";
            gamer2.DateOfBirth = 2007;
            gamer2.GamerId = 2;

            Gamer gamer3 = new Gamer();
            gamer3.Name = "Yunus";
            gamer3.LastName = "Öz";
            gamer3.TCNo = "543219876";
            gamer3.DateOfBirth = 1995;
            gamer3.GamerId = 3;

            Games games1 = new Games();
            games1.GameId = 1;
            games1.GameName = "PUBG";
            games1.GamePrice = 50;

            Games games2 = new Games();
            games2.GameId = 2;
            games2.GameName = "Counter Strike Global Offensive";
            games2.GamePrice = 40;

            Games games3 = new Games();
            games3.GameId = 3;
            games3.GameName = "Cyberpunk 2077";
            games3.GamePrice = 250;



            GamerManager gamerManager = new GamerManager();
            gamerManager.Add(new Gamer { GamerId=4, Name="Emir", LastName="Aras", TCNo="456789123", DateOfBirth=2017 });
            gamerManager.Update(gamer1);
            gamerManager.Delete(gamer1);

            GameManager gameManager = new GameManager();
            gameManager.Add(new Games { GameId = 4, GameName = "League Of Legends", GamePrice = 20 });
            gameManager.Update(games1);
            gameManager.Delete(games1);


            SummerSale summerSale = new SummerSale();
            summerSale.DıscountForGame(games1);

            WinterSale winterSale = new WinterSale();
            winterSale.DıscountForGame(games2);

            SummerSale summerSale1 = new SummerSale();
            summerSale.FınıshtoDiscount(games3);

            DıscountManager dıscountManager = new DıscountManager();
            dıscountManager.Dıscount(games1 , gamer1);

            Campaign campaign1 = new Campaign();
            campaign1.CampaignName = "Black Friday";
            campaign1.CampaignId = 1;
            campaign1.CampaignPercentage = 25;

            DıscountManager dıscountManager1 = new DıscountManager();
            dıscountManager1.Add(campaign1);

            
            

            
             




        }
    }
}
