using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectSimulation.Entities;

namespace GameProjectSimulation.Abstract
{
    internal interface ISaleManager
    {
        public void Sale (Customer customer,Campaign campaign, Sale sale);
    }
}
