using Demo_web.Models;
using Microsoft.EntityFrameworkCore;
using Demo_web;
//using System.Data.Entity;

namespace Demo_web
{
    public class WebStoreContext: DbContext
    {
        public WebStoreContext(DbContextOptions options) : base(options)
            { }

        public DbSet<Product> Products { get; set; }
    }
}
