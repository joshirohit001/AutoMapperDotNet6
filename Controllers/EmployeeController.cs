using Microsoft.AspNetCore.Mvc;
using MVCLearn.BAL.Interface;
using MVCLearn.MAL;

namespace MVCLearn.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployee _service;
        public EmployeeController(IEmployee service)
        {
            _service = service;
        }

        #region Get the list of Employee
        /// <summary>
        /// Get the list of Employee
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            List<EmployeeModel> finalResult = new();
            try
            {
                finalResult = _service.GetEmployees();
            }
            catch (Exception)
            {
                throw;
            }
            return View(finalResult);
        }
        #endregion
    }
}
