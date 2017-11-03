﻿namespace RestCustomerClient
{
    public class Customer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Year { get; set; }

        public Customer(int id, string firstName, string lastName, int year)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Year = year;
        }
        public Customer()
        {
        
        }

        public override string ToString()
        {
            return $"{nameof(ID)}: {ID}, {nameof(FirstName)}: {FirstName}, {nameof(LastName)}: {LastName}, {nameof(Year)}: {Year}";
        }
    }
}