using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using web_api.Models;

namespace web_api.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {   
            
        }

        public DbSet<Stock> Stocks {get; set;}
        public DbSet<Comment> Comments {get; set;}
    }
}