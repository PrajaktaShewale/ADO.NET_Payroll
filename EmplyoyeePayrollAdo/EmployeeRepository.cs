using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EmplyoyeePayrollAdo
{
    public class EmployeeRepository
    {
        //create connection between mssql and visual studio program
        SqlConnection connection = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = EmpPayroll;Integrated Security = true;");
        //UC1 
        public void CreateDatabase()
        {
            SqlCommand cmd = new SqlCommand("Create database EmpPayroll",connection);//create database
            connection.Open();
            cmd.ExecuteNonQuery();
            WriteLine("Database Created Successfully");
        }
        public void CreateTable()
        {
            SqlCommand cmd = new SqlCommand("Create Table EmployeeTable(id int primary key identity(1,1),Name varchar(200),Salary bigint,Startdate date,phone bigint," +
                    "Emp_Address varchar(200),Department varchar(200),Gender varchar(10), Basic_Pay bigint," +
                    "Deductions bigint,Taxable_Pay bigint,Income_Tax bigint,Net_Pay bigint )", connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            WriteLine("Table Created Successfully");
        }
        public void GetAllEmplyoee()
        {
            EmplyoeeModel empmodel = new EmplyoeeModel();
            try
            {
                using (connection)
                {
                    string Query = @"select * from EmployeeTable";
                    SqlCommand cmd = new SqlCommand(Query, connection);
                    connection.Open();
                  // cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlDataReader datareader = cmd.ExecuteReader();
                    if (datareader.HasRows)
                    {
                        while (datareader.Read())
                        {
                           empmodel.id = datareader.GetInt32(0);
                            empmodel.name = datareader.GetString(1);
                            WriteLine(empmodel.id +" "+ empmodel.name);
                        }
                        WriteLine("Connection Established with database");
                    }
                }
            }
            catch(Exception e)
            {
                WriteLine("Connection is not Established with database");

            }
            finally { connection.Close(); }
        }
        public string UpdateSalary()
        {
            try
            {
                using (connection)
                {
                    SqlCommand cmd = new SqlCommand(@"Update EmployeeTable set Salary=300000 where id=4", connection);
                    connection.Open();
                    var objreader = cmd.ExecuteNonQuery();
                    if (objreader >= 1)
                    {
                        Console.WriteLine("Data Updated");
                        return "Data Updated";
                    }
                    else
                    {
                        Console.WriteLine("Data not updated");
                        return "Data not Updated";
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally { connection.Close(); }
        }
    }
}
