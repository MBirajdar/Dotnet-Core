using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Department_MVCEF.Models
{
    public class Department
    {
        public int ID { get; set; }
        public string DeptName { get; set; }
        public string DeptLocation { get; set; }
        public string Branch { get; set; }
    }
}
