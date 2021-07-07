using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public class Author // clase publica, que se encarga de tener las propiedades de la tabla autores.
    {
        //public Author(string au_Id, string au_Lname, string au_Fname, string address, string city, string state, string phone, string zip, bool contract)
        //{
        //    Au_Id = au_Id;
        //    Au_Lname = au_Lname;
        //    Au_Fname = au_Fname;
        //    Address = address;
        //    City = city;
        //    State = state;
        //    Phone = phone;
        //    Zip = zip;
        //    Contract = contract;
        //}

        //---- Podemos definirlas asi, AUTOIMPLEMENTADAS ----
        public string Au_Id { get; set; }
        public string Au_Lname { get; set; }
        public string Au_Fname { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Phone { get; set; }
        public string Zip { get; set; }
        public Boolean Contract { get; set; }

        /*---- O asi, FULL PROPERTY ---- ES LO MISMO ----
         private string au_id;

        public string Au_id
        {
            get { return au_id; }
            set { au_id = value; }
        }

        private string au_lname;

        public string Au_lname
        {
            get { return au_lname; }
            set { au_lname = value; }
        }

        private string au_fname;

        public string Au_fname
        {
            get { return au_fname; }
            set { au_fname = value; }
        }

        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }
        private string state;

        public string State
        {
            get { return state; }
        }
         */
    }
}
