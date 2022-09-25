using AutoMapper;
using MVCLearn.BAL.Interface;
using MVCLearn.DAL;
using MVCLearn.MAL;

namespace MVCLearn.BAL.Service
{
    public class EmployeeService : IEmployee
    {
        private readonly IMapper _mapper;
        public EmployeeService(IMapper mapper)
        {
            _mapper = mapper;
        }

        #region Get All Employee Lists
        /// <summary>
        /// Get All Employee Lists
        /// </summary>
        /// <returns></returns>
        public List<EmployeeModel> GetEmployees()
        {
            List<Employee> result = new();
            List<EmployeeModel> finalResult = new();
            result.Add(new Employee() { Id = 1, FirstName = "Rohit", LastName = "Joshi", Country = "India" });
            result.Add(new Employee() { Id = 2, FirstName = "Rohan", LastName = "Joshi", Country = "USA" });
            result.Add(new Employee() { Id = 3, FirstName = "Raushan", LastName = "Joshi", Country = "UK" });
            result.Add(new Employee() { Id = 4, FirstName = "Rahul", LastName = "Joshi", Country = "NZ" });
            try
            {
                finalResult = _mapper.Map<List<Employee>, List<EmployeeModel>>(result);
                return finalResult;
            }
            catch
            {
                throw;
            }
        }
        #endregion
    }
}
