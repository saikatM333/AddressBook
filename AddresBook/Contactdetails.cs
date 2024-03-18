using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AddresBook
{
    public  class Contactdetails
    {
        private string firstName { get; set; }
        private string lastName{ get; set; }
        private string email { get; set; }
        private string phone { get; set; }
        private string address { get; set; }
        private string city { get; set; }
        private string state { get; set; }
        private string zip { get; set; }
        public Contactdetails(string firstName , string lastName ,  string email, string phone , string address , string city , string state , string zip)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phone = phone;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;

            
        }

        
    }
}
