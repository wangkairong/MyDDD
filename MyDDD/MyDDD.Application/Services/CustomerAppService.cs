using MyDDD.Application.Interfaces;
using MyDDD.Application.ViewModels;
using MyDDD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyDDD.Application.Services
{
    /// <summary>
    /// CustomerAppService 服务接口实现类,继承 服务接口
    /// 通过 DTO 实现视图模型和领域模型的关系处理
    /// 作为调度者，协调领域层和基础层，
    /// 这里只是做一个面向用户用例的服务接口,不包含业务规则或者知识
    /// </summary>
    public class CustomerAppService : ICustomerAppService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerAppService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<CustomerViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public CustomerViewModel GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Register(CustomerViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public void Update(CustomerViewModel viewModel)
        {
            throw new NotImplementedException();
        }

    }
}
