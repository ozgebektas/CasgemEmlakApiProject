using EmlakProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakProject.DataAccessLayer.Abstract
{
    public interface IAnnouncementService
    {
        List<Announcement> GetList();
        Announcement GetById(string id);
        Announcement AddAnnouncement(Announcement announcement);

        void DeleteAnnouncement(string id);
        void UpdateAnnouncement(string id,Announcement announcement);

    }
}
