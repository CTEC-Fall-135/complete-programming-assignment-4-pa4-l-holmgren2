using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneBook
{
    public class PhoneBook
    {
        #region Fields
        private Entity[] entries;

        #endregion

        #region Constructor
        public PhoneBook()
        {
            entries = new Entity[10];
        }

        #endregion

        #region Methods
        //adds Entity entry to the first null element
        public void AddEntity(Entity entry)
        {
            for (int i = 0; i < entries.Length; i++)
            {
                if (entries[i] == null)
                {
                    entries[i] = entry;
                    break;
                }
            }
        }
        
        //create new Business and add it as an entry
        public void AddBusinessEntity(string streetAddress, string city, string state, string zip, string phoneNumber, string businessName)
        {
            AddEntity(new Business(streetAddress, city, state, zip, phoneNumber, businessName));
        }

        //create new Person and add it as an entry
        public void AddPersonEntity(string streetAddress, string city, string state, string zip, string phoneNumber, string firstName, string lastName)
        {
            AddEntity(new Person(streetAddress, city, state, zip, phoneNumber, firstName, lastName));
        }

        //print all entries in the phonebook
        public void PrintPhonebook()
        {
            foreach (Entity entry in entries)
            {
                if (entry != null)
                {
                    entry.PrintAddress();
                    Console.WriteLine();
                }
            }
        }

        #endregion
    }
}