using System;
using GameProjectSimulation.Entities;
using GameProjectSimulation.Concrete;

namespace GamePRojectSimulation 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 12345;
            customer1.Name = "Kübra";
            customer1.Surname = "Orhan";
            customer1.BirthYear = 2002;

            Campaign campaign1 = new Campaign();
            campaign1.CampaignName = "30% indirim";
            campaign1.DiscountRate = 30;

            Sale sale1 = new Sale();
            sale1.GameName = "Sims4";
            sale1.Price = 300;

            CustomerManager customerManager1 = new CustomerManager(new UserValidationManager());
            customerManager1.Add(customer1);

            CampaignManager campaignManager1 = new CampaignManager();
            campaignManager1.Update(campaign1);

            SaleManager saleManager = new SaleManager();
            saleManager.Sale(customer1,campaign1,sale1);

        }
    }
}