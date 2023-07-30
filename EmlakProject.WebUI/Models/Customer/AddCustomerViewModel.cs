using MongoDB.Bson.Serialization.Attributes;

namespace EmlakProject.WebUI.Models.Customer
{
    public class AddCustomerViewModel
    {
        public string NameSurname { get; set; }
        public string Description { get; set; }
    }
}
