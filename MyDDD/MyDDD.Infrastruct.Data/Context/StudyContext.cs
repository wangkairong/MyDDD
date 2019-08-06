using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MyDDD.Domain.Models;
using Microsoft.Extensions.Configuration;
using System.IO;
using MyDDD.Infrastruct.Data.Mappings;

namespace MyDDD.Infrastruct.Data.Context
{
    /// <summary>
    /// 定义核心子领域--学习上下文
    /// </summary>
    public class StudyContext:DbContext
    {
        public DbSet<Student> Students { get; set; }

        /// <summary>
        /// 重新自定义Map配置
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentMap());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // 从 appsetting.json 中获取配置信息
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetings.json")
                .Build();
            //定义要使用的数据库
            //正确的是这样，直接连接字符串即可
            //optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            //我是读取的文件内容，为了数据安全
            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }
    }
}
