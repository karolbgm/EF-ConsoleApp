using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Tutorial;
public class AppDbContext : DbContext
{
    //define what tables we can access
    public DbSet<User> Users { get; set;}
    //default constructor
    public AppDbContext() { }
    
    //configure how the context connects to the database
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "server=localhost\\sqlexpress;database=tqlprsdb;trusted_connection=true;trustServerCertificate=true";
        optionsBuilder.UseSqlServer(connectionString);
    }
}

//protected - for all other classes, the OnConfiguring is private, except for the base class is being inherited
//protected - derived classes can access it but no other class can