using Laba4EF.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laba4EF.DBContext;

namespace Laba4EF.DBContext
{
    internal class AppContext:DbContext
    {
        public DbSet<FirstTable> FirstTable { get; set; }
        public string DbPath { get; }
        public AppContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "lab4.db");
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer($"Data Source={DbPath}");
    }
}
