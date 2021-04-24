using SpareParts.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpareParts.Iservice
{
    public interface IRegisterService
    {
        bool UserIsExist(string phoneNumber);
        bool AddUser(account user);
        bool UserNameIsExist(string name);
    }
}
