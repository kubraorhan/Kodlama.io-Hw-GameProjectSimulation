﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectSimulation.Abstract;
using GameProjectSimulation.Entities;


namespace GameProjectSimulation.Concrete
{
    internal class SaleManager : ISaleManager
    {
        public void Sale(Customer customer, Campaign campaign, Sale sale)
        {
            int discount = campaign.DiscountRate;
            sale.Price = sale.Price * discount/100 ;  
            Console.WriteLine(customer.Name + " " + customer.Surname + " adlı kullanıcıya " 
                + sale.GameName+ " oyunu için " + campaign.CampaignName + " uygulanmıştır. Fiyatı " +sale.Price +" TL."  );
        }
    }
}