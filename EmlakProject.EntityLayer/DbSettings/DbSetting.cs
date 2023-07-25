using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakProject.EntityLayer.DbSettings
{
    public class DbSetting : IDbSetting
    {
        public string AdminCollectionName { get; set; } = string.Empty;
        public string AnnouncementCollectionName { get; set; } = string.Empty;
        public string ServiceCollectionName { get; set; } = string.Empty;
        public string CustomerCollectionName { get; set; } = string.Empty;
        public string BuildingImageCollectionName { get; set; } = string.Empty;
        public string LandCollectionName { get; set; } = string.Empty;
        public string CategoryCollectionName { get; set; } = string.Empty;
        public string OurTeamCollectionName { get; set; } = string.Empty;
        public string ContactCollectionName { get; set; } = string.Empty;
        public string ConnectionString { get; set; } = string.Empty;
        public string DatabaseName { get; set; } = string.Empty;
    }
}
