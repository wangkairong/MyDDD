using MyDDD.Domain.Interfaces;
using MyDDD.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyDDD.Infrastruct.Data.Repository
{
   public class CustomerRepository:Repository<Customer>, ICustomerRepository
    {

        
        public Customer GetByEmail(string email)
        {
            throw new System.NotImplementedException();
        }
    }
}
