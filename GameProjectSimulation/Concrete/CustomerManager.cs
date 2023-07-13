using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectSimulation.Abstract;
using GameProjectSimulation.Entities;

namespace GameProjectSimulation.Concrete
{
    internal class CustomerManager : ICustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name +" "+ customer.Surname + " added.");

        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname + " deleted.");

        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname + " updated.");

        }
    }
}
