using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWebApp.Shared
{
    public class EmployeeModel
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }
        public DateTime EmploymentDate { get; set; }
        public int Salary { get; set; }
    }
}
