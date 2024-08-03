﻿using LojasMoveis.Models;
using Microsoft.EntityFrameworkCore;

namespace LojasMoveis.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Movel> Moveis { get; set; }

    }
}