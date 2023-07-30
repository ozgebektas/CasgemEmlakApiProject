using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace EmlakProject.WebUI.Models.Contact
{
    public class ContactViewModel
    {
        public string ContactID { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
