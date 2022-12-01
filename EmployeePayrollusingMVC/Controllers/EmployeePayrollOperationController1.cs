using EmployeePayrollusingMVC.Context;
using EmployeePayrollusingMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeePayrollusingMVC.Controllers
{
    public class EmployeePayrollOperationController1 : Controller
    {
        private readonly EmployeeContext employeeContext;

        public EmployeePayrollOperationController1(EmployeeContext empContext)
        {
            this.employeeContext = empContext;
        }

        public IActionResult Index()
        {
            IEnumerable<EmployeeModel> objEmployeeModel=employeeContext.ModelsEmployee;
            return View(objEmployeeModel);
        }
        //GET Method
        public IActionResult Create()
        {
            return View();
        }
        //Post Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(EmployeeModel obj)
        {
            if (ModelState.IsValid)
            {
                employeeContext.ModelsEmployee.Add(obj);
                employeeContext.SaveChanges();
                TempData["success"] = "Employee Data Added Successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET Method
        public IActionResult Edit(int? id)
        {
            if(id == null || id==0)
            {
                return NotFound();
            }
            var employeeDataFromDb=employeeContext.ModelsEmployee.Find(id);
            if(employeeDataFromDb==null)
            {
                return NotFound();
            }
            return View(employeeDataFromDb);
        }
        //Post Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(EmployeeModel obj)
        {
            if (ModelState.IsValid)
            {
                employeeContext.ModelsEmployee.Update(obj);
                employeeContext.SaveChanges();
                TempData["success"] = "Employee Data Edited Successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var employeeDataFromDb = employeeContext.ModelsEmployee.Find(id);
            if (employeeDataFromDb == null)
            {
                return NotFound();
            }
            return View(employeeDataFromDb);
        }
        //Post Method
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = employeeContext.ModelsEmployee.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            //Removing data to database
            employeeContext.ModelsEmployee.Remove(obj);
            //Saving data to database
            employeeContext.SaveChanges();
            TempData["success"] = "Employee Data Deleted Successfully";
            //navigating to index page
            return RedirectToAction("Index");
        }
    }
}
