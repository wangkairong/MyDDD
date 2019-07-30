using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyDDD.UI.Web.Models;

namespace MyDDD.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        /// <summary>
        /// 保存顾客方法:add & update
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="birthday"></param>
        public void saveCustomer(string id,string name,string email,string birthday)
        {
            Customer customer = CustomerDao.GetCustomer(id);
            if (customer==null)
            {
                customer = new Customer();
                //customer.Id = id;
            }
            if (name!=null)
            {
                customer.Name = name;

            }
            if (email!=null)
            {
                customer.Email = email;
            }
            if (birthday!=null)
            {
                customer.BirthDate = Convert.ToDateTime( birthday);
            }

            CustomerDao.SaveCustomer(customer);
        }
    }
}
