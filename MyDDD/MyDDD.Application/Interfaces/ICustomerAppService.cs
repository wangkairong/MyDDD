using MyDDD.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyDDD.Application.Interfaces
{
   public interface ICustomerAppService:IDisposable
    {
        void Register(CustomerViewModel viewModel);
        IEnumerable<CustomerViewModel> GetAll();

        CustomerViewModel GetById(Guid id);
        void Update(CustomerViewModel viewModel);

        void Delete(Guid id);
    }
}
