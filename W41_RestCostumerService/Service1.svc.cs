using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace W41_RestCostumerService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private static List<Customer> cList = new List<Customer>() { new Customer(1, "Nicki", "Feldt", 1989) };

        public string GetData()
        {
            return "Hi my name is REST";
        }

        public IList<Customer> GetCustomers()
        {
            return cList;
        }

        public Customer GetCustomer(string id)
        {
	        return cList.Find(x => x.ID.ToString() == id);
        }
		
        public void DeleteCustomer(string id)
        {
	        cList.RemoveAll(x => x.ID.ToString() == id);
        }

        public void InsertCustomer(Customer c, string id)
        {
	        c.ID = cList.Last().ID + 1;
			cList.Add(c);
        }

        public void UpdateCustomer(Customer c, string id)
        {
	        c.ID = cList.Find(x => x.ID.ToString() == id).ID;
			DeleteCustomer(id);
			cList.Add(c);
        }
    }
}
