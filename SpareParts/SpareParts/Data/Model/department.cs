using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpareParts.Data.Model
{
    public class department
    {
        public department()
        {
            new_account = new List<account>();
        }
        public Guid new_department_id { get; set; }
        public string new_department_name { get; set; }
        public string new_department_des { get; set; }
        public string new_department_func { get; set; }
        public Guid new_account_id { get; set; }
        public List<account> new_account { get; set; }
    }
}
