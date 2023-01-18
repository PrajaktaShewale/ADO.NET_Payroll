using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EmplyoyeePayrollAdo
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepository employee = new EmployeeRepository();
            // employee.CreateDatabase();
            //employee.CreateTable();
            employee.GetAllEmplyoee();
        }
    }
}