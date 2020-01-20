using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ab_Kiros_ROM.Models;
namespace Ab_Kiros_ROM.DAL
{
    public class abContext : DbContext
    {
        public abContext(DbContextOptions<abContext> options) : base(options)
        {

        }
        public DbSet<Person> persons { get; set; }
        
        public DbSet<Client> clients
        { get; set; }
        public DbSet<Doctor> doctors
        { get; set; }
        public DbSet<Visits> visits
        { get; set; }
        public DbSet<Illness> illenses
           { get; set; }
           
    }
}
