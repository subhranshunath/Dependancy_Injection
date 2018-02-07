using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dependancy_Injection.Models;

namespace Dependancy_Injection.Repository
{
    public class UserMasterRepository : IUserMasterRepository
    {
        private List<UserMaster> users = new List<UserMaster>();
        private int _nextid = 1;
        public UserMasterRepository()
        {
            Add(new UserMaster { Name = "User1", EmailID = "user1@test.com", MobileNo = "1234567890" });
            Add(new UserMaster { Name = "User2", EmailID = "user@test.com", MobileNo = "1234567890" });
            Add(new UserMaster { Name = "User3", EmailID = "user3@test.com", MobileNo = "1234567890" });
        }
        public UserMaster Add(UserMaster item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.ID = _nextid++;
            users.Add(item);
            return item;
        }

        public bool Delete(int id)
        {
            users.RemoveAll(p => p.ID == id);
            return true;
        }

        public UserMaster Get(int id)
        {
            return users.FirstOrDefault(p => p.ID == id);
        }

        public IEnumerable<UserMaster> GetAll()
        {
            return users;
        }

        public bool Update(UserMaster item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            int index = users.FindIndex(p => p.ID == item.ID);
            if (index == -1)
            {
                return false;
            }
            users.RemoveAt(index);
            users.Add(item);
            return true;
        }
    }
}