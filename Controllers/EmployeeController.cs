using CRUDapplication.Data;
using CRUDapplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Xml.Linq;

namespace CRUDapplication.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationContext _context;
        public EmployeeController(ApplicationContext context)
        {
            this._context = context;

        }
        [HttpGet]
        public IActionResult Index()
        {
            var employees = _context.Employees.ToList();
            List<EmployeeViewModel> employeeList = new List<EmployeeViewModel>();
            if (employees != null)
            {

                foreach (var employee in employees)
                {
                    var EmployeeViewModel = new EmployeeViewModel()
                    {
                        Id = employee.Id,
                        Name = employee.Name,
                        Email = employee.Email,
                        Address = employee.Address,
                        Phone = employee.Phone
                    };
                    employeeList.Add(EmployeeViewModel);
                }
                return View(employeeList);
            }
            return View(employeeList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(EmployeeViewModel employeeData)
        {
           
                if (ModelState.IsValid)
                {
                    var Employee = new Employee()
                    {
                        Name = employeeData.Name,
                        Email = employeeData.Email,
                        Address = employeeData.Address,
                        Phone = employeeData.Phone

                    };
                    _context.Employees.Add(Employee);
                    _context.SaveChanges();
                    TempData["successMessage"] = "Employee Created Successfully";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["errorMessage"] = "Model data is not valid";
                    return View();
                }

            
        }
    }
}