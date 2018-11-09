using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apoptoosi.utils;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace apoptoosi.Models
{
    public class ShirtOrder
    {
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        [Key]
        public int ShirtOrderID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string size { get; set; }
        private RegexUtilities regexUtils  = new RegexUtilities();

        public bool Validate()
        {
            if (firstName.Length > 125 || string.IsNullOrEmpty(firstName))
            {
                return false;
            }
            else if (lastName.Length > 125 || string.IsNullOrEmpty(lastName))
            {
                return false;
            }
            else if (!regexUtils.IsValidEmail(email))
            {
                return false;
            }
            else if (regexUtils.IsValidShirtSize(size))
            {
                return false;
            }
            return true;
        }
    }
    public class ShirtOrderContext : DbContext
    {
        public DbSet<ShirtOrder> ShirtOrders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=apoptoosi.db");
        }
    }
}
