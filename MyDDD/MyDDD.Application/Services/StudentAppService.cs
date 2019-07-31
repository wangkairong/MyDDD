using AutoMapper;
using AutoMapper.QueryableExtensions;
using MyDDD.Application.Interfaces;
using MyDDD.Application.ViewModels;
using MyDDD.Domain.Interfaces;
using MyDDD.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyDDD.Application.Services
{
    public class StudentAppService : IStudentAppService
    {
        ///IOC依赖注入 还未实现
        private readonly IStudentRepository _studentRepository;
        ///用来进行DTO
        private readonly IMapper _mapper;

        public StudentAppService(IStudentRepository studentRepository,IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }
        public void Delete(Guid id)
        {
            _studentRepository.Delete(id);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<StudentViewModel> GetAll()
        {
            return (_studentRepository.GetAll()).ProjectTo<StudentViewModel>();
        }

        public StudentViewModel GetById(Guid id)
        {
            return _mapper.Map<StudentViewModel>(_studentRepository.GetById(id));
        }

        public void Register(StudentViewModel viewModel)
        {
            //判断为空还未实现

            _studentRepository.Add(_mapper.Map<Student>(viewModel));
        }

        public void Update(StudentViewModel viewModel)
        {
            _studentRepository.Update(_mapper.Map<Student>(viewModel));
        }
    }
}
