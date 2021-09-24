using System;
using System.Collections.Generic;
using System.Text;

namespace Addressbooksystem
{
    class Address
    { 
        public string name;
        public string address;
        public string phonenumber;
        public string city;
        public string state;
        public string zip; 
        public string email;

    public Address(string name, string address, string phonenumber, string city, string state, string zip, string email)
    {
            this.name = name;
            this.address = address;
            this.phonenumber = phonenumber;
            this.city = city;
            
            this.state = state;
            this.zip = zip;
            this.email = email;
    }
    
    }
}
