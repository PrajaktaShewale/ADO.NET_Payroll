
using EmplyoyeePayrollAdo;

namespace EmployeeTest

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            EmployeeRepository employee = new EmployeeRepository();
            string actual = employee.UpdateSalary();
            string Expected = "Data Updated";
            Assert.AreEqual(Expected, actual);  
        }
        [TestMethod]
        public void UpdateSalary_UsingStoreProcedure()
        {
            EmployeeRepository employee = new EmployeeRepository();
            EmplyoeeModel model = new EmplyoeeModel();
            model.Basic_Pay = 350000;
            model.id = 3;
            string actual = employee.UpdateSalaryStoredProcedure(300000,4);
            string Expected = "Data Updated";
            Assert.AreEqual(Expected, actual);
        }
    }
}