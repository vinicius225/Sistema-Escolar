using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sistema_Escolar.DTO.Entities;

namespace Sistema_Escolar.DTO
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        //Entyties
        public DbSet<Student> Students {get; set;}
    }
}