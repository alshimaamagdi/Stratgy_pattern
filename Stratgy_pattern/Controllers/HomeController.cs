using Microsoft.AspNetCore.Mvc;
using Stratgy_pattern.Cores;
using Stratgy_pattern.Cores.DiscoundStrategyPattern;
using Stratgy_pattern.Cores.SalaryStrategyPattern;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Stratgy_pattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
 
        [HttpGet("calculateSalary")]
        public IActionResult calculateSalary(int id,double salary)
        {
            //var loadedData = loadData.GetData();
            //Make object From EmployeeManager 
            var EmployeeManagerObject = new EmployeeManager();
            //GetData By Id
            var loadedDataById= EmployeeManagerObject.GetDataById(id);

            //Do this To select And set object at RunTime 
            ISalaryStrategy ISalaryStrategy =null;
            if (loadedDataById.Position==Enum.Position.Employee)
            {
                ISalaryStrategy = new EmployeeStrategy();
            }
            if (loadedDataById.Position == Enum.Position.Supervisor)
            {
                ISalaryStrategy = new SuperVisorStrategy();
            }
            if (loadedDataById.Position == Enum.Position.Manager)
            {
                ISalaryStrategy = new ManagerStrategy();
            }
            EmployeeManagerObject.setSalaryStrategy(ISalaryStrategy);
            var result= EmployeeManagerObject.GetUpdatedData(id, salary);
            return Ok(result);
        }

   
    }
}
