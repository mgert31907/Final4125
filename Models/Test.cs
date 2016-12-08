using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Final4125.Models
{
    public class Test
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
    }

    public class TestDBcontext : DbContext
    {
        public DbSet<Test> Movies {get; set;}
    }
}