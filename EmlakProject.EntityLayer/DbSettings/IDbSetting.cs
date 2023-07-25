using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakProject.EntityLayer.DbSettings
{
    public interface IDbSetting
    {
        public string AdminCollectionName { get; set; }
        public string AnnouncementCollectionName { get; set; }
        public string ServiceCollectionName { get; set; }
        public string CustomerCollectionName { get; set; }
        public string BuildingImageCollectionName { get; set; }
        public string LandCollectionName { get; set; }
        public string CategoryCollectionName { get; set; }
        public string OurTeamCollectionName { get; set; }
        public string ContactCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
