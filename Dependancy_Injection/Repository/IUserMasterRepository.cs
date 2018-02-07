using Dependancy_Injection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependancy_Injection.Repository
{
    public interface IUserMasterRepository
    {
        IEnumerable<UserMaster> GetAll();
        UserMaster Get(int id);
        UserMaster Add(UserMaster item);
        bool Update(UserMaster item);
        bool Delete(int id);
    }
}
