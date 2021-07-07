using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public class Publisher
    {
        public Publisher(string id, string pub_name, string city, string state, string country)
        {
            Id = id;
            this.Pub_name = pub_name;
            this.City = city;
            this.State = state;
            this.Country = country;
        }

        public string Id { get; set; }
        public string Pub_name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}
