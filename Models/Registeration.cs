using Microsoft.EntityFrameworkCore;


namespace apoptoosi.models {
    public class Registeriration
    {

        public string name { get; set; }
        public string group { get; set; }
        public bool alcohol { get; set; }
        public string text { get; set; }

    }
    public class CookieQueTicket
    {
        public uint position {get; set;}

        public string cookie {get; set;}

        public uint experation {get; set;}
    }
    public class RegisterirationContext : DbContext
    {
        public DbSet<Registeriration> Registerirations  {get; set; }

        public DbSet<CookieQueTicket> CookieQueTicket {get; set; }
    }
}