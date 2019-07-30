using System;
using System.Collections.Generic;
using System.Text;

namespace MyDDD.Domain.Models
{
   public class Customer
    {
        protected Customer() { }
        public Customer(Guid id, string name, string email, DateTime birthday)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthday;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
