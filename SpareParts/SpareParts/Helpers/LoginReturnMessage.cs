using SpareParts.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpareParts.Helpers
{
    public class LoginReturnMessage
    {
        public int Success { get; set; }
        public string Message { get; set; }
        public account  user { get; set; }

    }
}
