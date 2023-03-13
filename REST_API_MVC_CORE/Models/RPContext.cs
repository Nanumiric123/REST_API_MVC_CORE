using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using REST_API_MVC_CORE.Models;



namespace REST_API_MVC_CORE.Data
{
    public class RPContext : DbContext
    {
        public RPContext(DbContextOptions<RPContext> options)
            : base(options)
        {
        }
        public DbSet<REST_API_MVC_CORE.Models.REEL_PHOTO> REEL_PHOTO { get; set; } = null;
    }
}
