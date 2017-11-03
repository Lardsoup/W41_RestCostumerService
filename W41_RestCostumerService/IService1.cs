using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace W41_RestCostumerService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebInvoke(Method = "GET", 
			ResponseFormat = WebMessageFormat.Json, 
			UriTemplate = "data/")]
        string GetData();

        [OperationContract]
        [WebInvoke(Method = "GET", 
			ResponseFormat = WebMessageFormat.Json, 
			UriTemplate = "customers/")]
        IList<Customer> GetCustomers();

	    [OperationContract]
	    [WebInvoke(Method = "GET", 
			ResponseFormat = WebMessageFormat.Json, 
			UriTemplate = "customer/{id}")]
		Customer GetCustomer(string id);

	    [OperationContract]
	    [WebInvoke(Method = "DELETE", 
			ResponseFormat = WebMessageFormat.Json, 
			UriTemplate = "customer/{id}")]
		void DeleteCustomer(string id);

	    [OperationContract]
	    [WebInvoke(Method = "POST", 
			RequestFormat = WebMessageFormat.Json, 
			ResponseFormat = WebMessageFormat.Json, 
			UriTemplate = "customer/{id}")]
		void InsertCustomer(Customer c, string id);

	    [OperationContract]
	    [WebInvoke(Method = "PUT", 
			RequestFormat = WebMessageFormat.Json, 
			ResponseFormat = WebMessageFormat.Json, 
			UriTemplate = "customer/{id}")]
		void UpdateCustomer(Customer c, string id);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    //[DataContract]
    //public class CompositeType
    //{
    //    bool boolValue = true;
    //    string stringValue = "Hello ";

    //    [DataMember]
    //    public bool BoolValue
    //    {
    //        get { return boolValue; }
    //        set { boolValue = value; }
    //    }

    //    [DataMember]
    //    public string StringValue
    //    {
    //        get { return stringValue; }
    //        set { stringValue = value; }
    //    }
    //}
}
