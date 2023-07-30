using MongoDB.Bson.Serialization.Attributes;

namespace EmlakProject.WebUI.Models.Property
{
    public class PropertyViewModel
    {
        public string PropertName { get; set; }

        public string Adress { get; set; }

        public decimal Count { get; set; }

        public string Image { get; set; }

        public string Title { get; set; }

        public int BedCount { get; set; }

        public int BathCount { get; set; }

        public string Description { get; set; }
    }
}
