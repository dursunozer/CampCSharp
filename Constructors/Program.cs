using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer {Id=1,FirstName="Dursun",LastName="Özer",City="Tohat" };

            Customer customer2 = new Customer(2, "Engin", "Demiroğ","Ankara") ;

            Console.WriteLine(customer2.FirstName);

            
            
        }
      
    }

    class Customer
    {
        public Customer()
        {
                
        }
        public Customer(int id,string firstname,string lastname,string city)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
