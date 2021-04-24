using SpareParts.Data.AppDbContext;
using SpareParts.Data.Model;
using SpareParts.Helpers;
using SpareParts.Iservice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpareParts.Service
{
    public class RegisterService : IRegisterService
    {
        private readonly AppDbContext _myContext;

        public RegisterService(AppDbContext myContext)
        {
            _myContext = myContext;
        }
        public bool AddUser(account user)
        {
            user.new_password = MD5.MD5Str3(user.new_password);
            var _user = _myContext.new_account.Add(user);
            if (_user.Entity.ToString() == null)
                return false;
            return true;
        }

        public bool UserIsExist(string phoneNumber)
        {
            var _user = _myContext.new_account.Where(x => x.new_account_phone == phoneNumber).ToList();
            if (_user.Count != 0)
                return true;
            return false;
        }

        public bool UserNameIsExist(string name)
        {
            var user = _myContext.new_account.Where(x => x.new_account_name == name).ToList();
            if (user.Count != 0)
            {
                return true;
            }
            return false;
        }
    }
}
