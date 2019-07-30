using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyDDD.UI.Web.Models
{
    /// <summary>
    /// 领域对象
    /// </summary>
    public class Customer
    {
        public Customer()
        {
        }

        public Customer(string  id,string name,string email,DateTime birthday)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthday;
        }
        public string  Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
