using GameProjectSimulation.Abstract;
using GameProjectSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectSimulation.Concrete
{
    internal class UserValidationManager : IUserValidationService
    {
        public bool Validate(Customer customer)
        {
            if (customer.BirthYear == 2002 && customer.Name == "Kübra" 
                && customer.Surname == "Orhhan" && customer.Id == 12345)
            {
                return true;
            }
            else
            {  return false; }

        }
    }
}
