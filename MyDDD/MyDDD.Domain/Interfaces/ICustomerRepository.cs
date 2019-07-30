using MyDDD.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyDDD.Domain.Interfaces
{
    public interface ICustomerRepository:IRepository<Customer>
    {

        Customer GetByEmail(string email);
    }
}
