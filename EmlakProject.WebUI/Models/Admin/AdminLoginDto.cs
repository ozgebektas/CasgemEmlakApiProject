using MongoDB.Bson.Serialization.Attributes;

namespace EmlakProject.WebUI.Models.Admin
{
    public class AdminLoginDto
    {
       
        public string Username { get; set; }
        
        public int Password { get; set; }
        public string Email { get; set; }
    }
}
