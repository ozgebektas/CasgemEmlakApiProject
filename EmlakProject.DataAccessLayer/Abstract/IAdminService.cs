using EmlakProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakProject.DataAccessLayer.Abstract
{
	public interface IAdminService
	{
		List<Admin> GetList();

		Admin GetById(string id);
		Admin Add(Admin admin);

		void Deletet(string id);
		void Update(string id, Admin admin);
	}
}
