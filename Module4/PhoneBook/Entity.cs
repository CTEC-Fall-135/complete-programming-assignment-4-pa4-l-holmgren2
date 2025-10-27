using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneBook
{
    public abstract class Entity
    {
        #region Properties
        public Address address { get; set; }
        public string phoneNumber { get; set; }

        #endregion

        #region Constructor
        public Entity(string streetAddress, string city, string state, string zip, string phoneNumber)
        {
            this.address = new Address(streetAddress, city, state, zip);
            this.phoneNumber = phoneNumber;
        }

        #endregion

        #region Methods
        public abstract void PrintAddress();

        #endregion
    }

    public class Business : Entity
    {
        #region Properties
        public string businessName { get; set; }
        #endregion

        #region Constructor
        public Business(string streetAddress, string city, string state, string zip, string phoneNumber, string businessName)
            : base(streetAddress, city, state, zip, phoneNumber)
        {
            this.businessName = businessName;
        }
        #endregion

        #region Methods
        public override void PrintAddress()
        {
            Console.WriteLine($"{businessName}");
            address.PrintAddress();
        }
        #endregion
    }

    public class Person : Entity
    {
        #region Properties
        public string firstName { get; set; }
        public string lastName { get; set; }

        #endregion

        #region Constructor
        public Person (string streetAddress, string city, string state, string zip, string phoneNumber, string firstName, string lastName)
            : base(streetAddress, city, state, zip, phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        #endregion

        #region Methods
        public override void PrintAddress()
        {
            Console.WriteLine($"{firstName} {lastName}");
            address.PrintAddress();
        }
        #endregion
    }
}