using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.ModelBinding;

namespace EmployeeWcfServiceApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeService : IEmploeeService
    {
        EmployeeDbContext empDbContext = new EmployeeDbContext();

        public IEnumerable<Employee> GetEmployees()
        {
            return empDbContext.Employees.ToList();
        }

        public Employee GetEmployee(int id)
        {
            return empDbContext.Employees.Single(e => e.EmployeeId == id);
        }

        public void InsertEmployee(Employee emp)
        {
           
            empDbContext.Employees.Add(emp);
            empDbContext.SaveChanges();
        }

        public void UpdateEmployee(Employee emp)
        {
           //get the employee from database with matching id.
           Employee localEmp= empDbContext.Employees.Single(e=>e.EmployeeId==emp.EmployeeId);

          if(localEmp!=null)
            {
                localEmp.FirstName = emp.FirstName;
                localEmp.LastName = emp.LastName;
                localEmp.PhNo = emp.PhNo;
                localEmp.Status = emp.Status;
                localEmp.Email = emp.Email;
                localEmp.DateOfBirth = emp.DateOfBirth;
                localEmp.DateOfJoining = emp.DateOfJoining;
                localEmp.MarketingStartDate = emp.MarketingStartDate;
                localEmp.MarketedBy = emp.MarketedBy;
            }
          
            empDbContext.SaveChanges();
           

        }

        public void DeleteEmployee(int id)
        {
            Employee empToDelete = empDbContext.Employees.Single(e => e.EmployeeId == id);
            empDbContext.Employees.Remove(empToDelete);
            empDbContext.SaveChanges();
        } 
    }
}
