using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyDDD.UI.Web.Models
{
    /// <summary>
    /// 领域对象持久化层
    /// </summary>
    public class CustomerDao
    {
        public static Customer GetCustomer(string id)
        {
            return new Customer() { Id="1",  Name = "zhangsan", Email = "zhangsan@163.com" };
        }

        public static string SaveCustomer(Customer customer)
        {
            return "保存成功";
        }
    }
}
