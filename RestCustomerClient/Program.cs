using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RestCustomerClient
{
    class Program
    {
        public static string CustomersUri = "http://localhost:3200/Service1.svc/Customers/";

        static void Main(string[] args)
        {
            IList<Customer> CustomerList = GetCustomersAsync().Result;
            foreach (Customer customer in CustomerList)
            {
                Console.WriteLine(customer);
            }
        }
        private static async Task<IList<Customer>> GetCustomersAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                string content = await client.GetStringAsync(CustomersUri);
                IList<Customer> cList = JsonConvert.DeserializeObject<IList<Customer>>(content);
                return cList;
            }
        }
    }
}
