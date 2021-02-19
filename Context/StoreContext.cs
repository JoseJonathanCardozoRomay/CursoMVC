using Microsoft.EntityFrameworkCore;
using MVC1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC1.Context
{
    public class StoreContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
