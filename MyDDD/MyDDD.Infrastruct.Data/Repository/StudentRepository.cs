using Microsoft.EntityFrameworkCore;
using MyDDD.Domain.Interfaces;
using MyDDD.Domain.Models;
using MyDDD.Infrastruct.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyDDD.Infrastruct.Data.Repository
{
   public class StudentRepository: Repository<Student>,IStudentRepository
    {
        public StudentRepository(StudyContext context)
        : base(context)
        {

        }
        //对特例接口进行实现
        public Student GetByEmail(string email)
        {
            return DbSet.AsNoTracking().FirstOrDefault(c => c.Email == email);
        }
    }
}
