using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1_UMS.Models
{
    public class user_context : DbContext
    {
        public user_context(DbContextOptions<user_context> options) : base(options) { }


        public DbSet<user> user { get; set; }

    }



}
