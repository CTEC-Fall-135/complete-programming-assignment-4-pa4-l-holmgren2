using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneBook
{
    public class Address
    {
        #region Propeties
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }

        #endregion

        #region Constructor
        public Address(string streetAddress, string city, string state, string zip)
        { 
            this.streetAddress = streetAddress;
            this.city = city;
            this.state = state;
            this.zip = zip;
        }

        #endregion

        #region Methods
        public void PrintAddress()
        {
            Console.WriteLine($"{streetAddress}");
            Console.WriteLine($"{city}, {state} {zip}");
        }
        #endregion

    }
}