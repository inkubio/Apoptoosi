using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace apoptoosi.models {
    public class Registeriration
    {

        
        [Key]
        public int RegisterationID { get; set; }
        public string name { get; set; }
        public string group { get; set; }
        public bool alcohol { get; set; }
        public string text { get; set; }

    }
    public class CookieQueTicket
    {
        [Key]
        public int CookieID { get; set; }
        public uint position {get; set;}

        public string cookie {get; set;}

        public uint expiration {get; set;}
    }

    public class RegisterirationContext : DbContext
    {
        public DbSet<Registeriration> Registerirations  {get; set; }

        public DbSet<CookieQueTicket> CookieQueTicket {get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=apoptoosi.db");
        }
    }
}