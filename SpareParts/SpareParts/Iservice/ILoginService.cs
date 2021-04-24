using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpareParts.Iservice
{
    public interface ILoginService
    {
        bool Login(string querystring, string password);

    }
}
