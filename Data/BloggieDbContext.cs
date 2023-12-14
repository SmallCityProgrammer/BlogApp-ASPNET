using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog_App.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Blog_App.Data
{
    public class BloggieDbContext : DbContext
    {
        public BloggieDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }

    }
}