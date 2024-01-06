﻿using Microsoft.EntityFrameworkCore;

namespace CRUDoperations.Models
{
    public class UserDbContext : DbContext
    {
       public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) 
        {

        }


        public DbSet<UserModel> Users { get; set; }
    }
}
