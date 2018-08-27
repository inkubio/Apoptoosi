using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System;
using System.Globalization;
using apoptoosi.utils;

namespace apoptoosi.models {
    public class Registration
    {

        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        [Key]
        public int RegistrationID { get; set; }
        public string firstName { get; set; }
        public string lastName {get; set;}
        public string email {get;set;}
        public string seatingGroup { get; set; }
        public bool alcohol { get; set; }
        public string text { get; set; }

        private RegexUtilities regexUtils = new RegexUtilities();

        public bool validate()
        {
            if (firstName.Length > 125 || string.IsNullOrEmpty(firstName)) {
                return false;
            }
            else if(lastName.Length > 125 || string.IsNullOrEmpty(lastName)){
                return false;
            }
            else if (!regexUtils.IsValidEmail(email)){
                return false;
            }
            else if (seatingGroup.Length > 125 ||string.IsNullOrEmpty(seatingGroup)) {
                return false;
            }
            else if (text.Length > 255) {
                return false;
            }
            return true;
        }

    }
    public class CookieQueTicket
    {
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        [Key]
        public int cookieID { get; set; }

        public uint position {get; set;}

        public string cookie {get; set;}

        public uint expiration {get; set;}
    }

    public class RegistrationContext : DbContext
    {
        public DbSet<Registration> Registerirations  {get; set; }

        public DbSet<CookieQueTicket> CookieQueTicket {get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=apoptoosi.db");
        }

    }
}