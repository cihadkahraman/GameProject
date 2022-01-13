using GameProject.Entities;
using GameProject.Abstract;
using GameProject.Concrate;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer();
            gamer.Name_Surname = "Cihad Kahraman";
            gamer.Identity = "52352452552";
            gamer.BirthYear = 1995;

            GamerManager gamerManager = new GamerManager(new VerifyManager() );

            gamerManager.Add(gamer);

            Games game = new Games();
            game.GameName = "Tsubasa";
            game.GameNo = 10;
            game.GamePrice = 20;

            GameManager gameManager = new GameManager();

            gameManager.Add(game);

            Campaign campaign = new Campaign();
            campaign.CampaignDate = new DateTime(2022, 12, 31);
            campaign.CampaignName = "Kış Fırsatı";
            campaign.CampaignPercent = 40;

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);

            GameSaleManager gameSaleManager = new GameSaleManager();
            gameSaleManager.Sale(gamer, game, campaign);

        }
    }
}
