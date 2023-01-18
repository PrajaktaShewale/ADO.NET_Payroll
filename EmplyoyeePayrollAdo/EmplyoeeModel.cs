using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmplyoyeePayrollAdo
{
    internal class EmplyoeeModel
    {
        /*Create Table EmployeeTable(id int primary key identity(1,1),Name varchar(200),Salary bigint, Startdate date,phone bigint," +
                    "Emp_Address varchar(200),Department varchar(200),Gender varchar(10), Basic_Pay bigint," +
                    "Deductions bigint,Taxable_Pay bigint,Income_Tax bigint,Net_Pay bigint )*/
        public int  id { get; set; }
        public string  name { get; set; }
        public long  Salary { get; set; }
        public DateTime  Startdate { get; set; }
        public long  phone { get; set; }
        public string  Emp_Address { get; set; }
        public string  Department { get; set; }
        public Char  Gender { get; set; }
        public long  Basic_Pay { get; set; }
        public long  Deduction { get; set; }
        public long  Taxable_Pay { get; set; }
        public long  Income_Tax { get; set; }
        public long  Net_Pay { get; set; }
    }
}
