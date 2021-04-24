using SpareParts.Data.AppDbContext;
using SpareParts.Helpers;
using SpareParts.Iservice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpareParts.Service
{
    public class LoginService : ILoginService
    {
        private readonly AppDbContext _myContext;

        public LoginService(AppDbContext myContext)
        {
            _myContext = myContext;
        }
        public bool Login(string querystring, string password)
        {
            if (!string.IsNullOrWhiteSpace(querystring))
            {
                var user = _myContext.new_account
                    .Where(x => x.new_account_mail.Contains(querystring) ||
                                        x.new_account_name.Contains(querystring) ||
                                        x.new_account_phone.Contains(querystring)).ToList().FirstOrDefault();
                if (user == null)
                    return false;
                else
                {
                    if (MD5.MD5Str3(password) == user.new_password)
                        return true;
                    return false;
                }
            }
            else
                return false;
        }
    }
}
