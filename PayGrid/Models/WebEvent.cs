using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PayGrid.Models
{
    public class WebEvent
    {
        public int ID { get; set; }
        public string Json { get; set; }
        //public DateTime ReleaseDate { get; set; }
        //public string Genre { get; set; }
        //public decimal Price { get; set; }
    }

    public class WebEventDBContext : DbContext
    {
        public DbSet<WebEvent> WebEvent { get; set; }
    }

}