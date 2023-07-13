﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectSimulation.Entities;

namespace GameProjectSimulation.Abstract
{
    internal interface ICampaignManager
    {
        public void Add(Campaign campaign);

        public void Delete(Campaign campaign);

        public void Update(Campaign campaign);
    }
}
