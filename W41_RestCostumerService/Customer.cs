namespace W41_RestCostumerService
{
    public class Customer
    {
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

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Year { get; set; }
    }
}