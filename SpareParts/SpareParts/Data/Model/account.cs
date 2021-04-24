using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpareParts.Data.Model
{
    public class account
    {
        public Guid new_account_id { get; set; }
        public string new_account_name { get; set; }
        public string new_account_mail { get; set; }
        public string new_account_phone { get; set; }
        public int new_account_role { get; set; }
        public string new_password { get; set; }
        public Guid new_department_id { get; set; }
        public department new_department { get; set; }
    }
}
