using MyDDD.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyDDD.Application.Interfaces
{
   public interface IStudentAppService:IDisposable
    {
        void Register(StudentViewModel viewModel);
        IEnumerable<StudentViewModel> GetAll();

        StudentViewModel GetById(Guid id);
        void Update(StudentViewModel viewModel);

        void Delete(Guid id);
    }
}
