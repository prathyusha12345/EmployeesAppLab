using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeMVCProj.EmployeeService;

namespace EmployeeMVCProj.Controllers
{
    public class EmployeeController : Controller
    {
        private EmploeeServiceClient employeeServiceClient = new EmploeeServiceClient(); 
        // GET: Employee
        public ActionResult Index()
        {
            
            return View(employeeServiceClient.GetEmployees());
        }


        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            Employee empFromDb = employeeServiceClient.GetEmployee(id);
            if (empFromDb != null)
            {
                return View(empFromDb);
            }
            return null;
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            try
            {
                // TODO: Add insert logic here
                employeeServiceClient.InsertEmployee(emp);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            Employee empFromDb = employeeServiceClient.GetEmployee(id);
            if (empFromDb == null)
            {
                return HttpNotFound();
            }
                return View(empFromDb);
            
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(Employee e)
        {
            try
            {
                // TODO: Add update logic here
                
                    employeeServiceClient.UpdateEmployee(e);
                    return RedirectToAction("Index");
                
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            Employee empFromDb=employeeServiceClient.GetEmployee(id);   
            return View(empFromDb);
        }

        // POST: Employee/Delete/5
        [HttpPost,ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                // TODO: Add delete logic here
                employeeServiceClient.DeleteEmployee(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
