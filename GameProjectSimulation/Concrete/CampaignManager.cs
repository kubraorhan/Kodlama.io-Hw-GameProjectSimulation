using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectSimulation.Abstract;
using GameProjectSimulation.Entities;

namespace GameProjectSimulation.Concrete
{
    internal class CampaignManager : ICampaignManager
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " added.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " deleted.");

        }
        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " updated.");

        }
    }
}
