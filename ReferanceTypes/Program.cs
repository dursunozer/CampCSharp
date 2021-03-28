using System;

namespace ReferanceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "Dursun";
            Person person2 = new Person();

            person2 = person1;
            person1.FirstName = "Kudret";

            Console.WriteLine(person1.FirstName);




            Customer customer = new Customer();
            customer.FirstName = "Hardrada";
            customer.CreditCardNumber = "122345678";
            Employee employee = new Employee();
            employee.FirstName = "Ahmed";

            Person person3 = customer;


            //Console.WriteLine(((Customer)person3).CreditCardNumber);
            PersonManager personManager = new PersonManager();
            personManager.Add(employee);



        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
    }
    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
