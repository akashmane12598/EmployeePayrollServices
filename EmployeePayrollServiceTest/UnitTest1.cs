using EmployeePayrollService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmployeePayrollServiceTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UC3_CompareUpdatedSalary()
        {
            EmployeeModel model = new EmployeeModel();
            model.BasicPay = 3000000;
            EmployeeRepo repo = new EmployeeRepo();
            bool res = repo.UpdateEmployee(model.BasicPay);
            if (res)
            {

            }
        }
    }
}
