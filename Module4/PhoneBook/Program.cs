/*
Author: Lauren Holmgren
Date: 10/26/2025
Assignment: PA4
 */

namespace PhoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //test address class
            Console.WriteLine("\nTest Address class");
            Address address1 = new Address("1234 First St", "Vancouver", "WA", "12345");
            address1.PrintAddress();

            //test business class
            Console.WriteLine("\nTest Business class");
            Business business1 = new Business("1234 First St", "Vancouver", "WA", "12345", "(123) 456-7890", "Sam's Store");
            business1.PrintAddress();

            //test person class
            Console.WriteLine("\nTest Person class");
            Person person1 = new Person("1234 First St", "Vancouver", "WA", "12345", "(123) 456-7890", "Sam", "Smith");
            person1.PrintAddress();

            //test phonebook
            Console.WriteLine("\nTest phonebook");
            PhoneBook phoneBook1 = new PhoneBook();
            phoneBook1.AddBusinessEntity("1234 First St", "Vancouver", "WA", "12345", "(123) 456-7890", "Sam's Store");
            phoneBook1.AddPersonEntity("1234 First St", "Vancouver", "WA", "12345", "(123) 456-7890", "Sam", "Smith");
            phoneBook1.PrintPhonebook();
        }
    }
}
