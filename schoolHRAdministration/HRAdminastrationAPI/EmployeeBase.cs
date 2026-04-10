using System;
using System.Collections.Generic;
using System.Text;

namespace HRAdminastrationAPI
{
    public class EmployeeBase : IEmployee
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public virtual decimal Salary { get; set; }
    }
}
