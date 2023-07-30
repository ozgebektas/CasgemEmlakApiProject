using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace EmlakProject.WebUI.Models.Customer
{
    public class CustomerViewModel
    {
        public string CustomerID { get; set; } 
    
        public string NameSurname { get; set; }
      
        public string Description { get; set; }
    }
}
