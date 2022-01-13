using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrate
{
    public class GameSaleManager : IGameSaleService
    {
        public void Sale(Gamer gamer, Games games, Campaign campaign)
        {
            Console.WriteLine(games.GameName + " oyunu " + gamer.Name_Surname + " adlı kullanıcıya satıldı. " + "Yararlanılan kampanya " + campaign.CampaignName +".");
        }
    }
}
