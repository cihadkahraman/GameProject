using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrate
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "kampanyası uygulandı." + "Kampanya yüzdesi "+ campaign.CampaignPercent +"olup" + campaign.CampaignDate + " tarihine kadar kampanyadan yararlanabilirsiniz.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "kampanyası silinmiştir.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "kampanyası güncellenmiştir.");
        }
    }
}
