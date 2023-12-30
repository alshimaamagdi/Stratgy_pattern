using Stratgy_pattern.Cores.DiscoundStrategyPattern;

namespace Stratgy_pattern.Cores
{
    public class EmployeeManager
    {
        private ISalaryStrategy _ISalaryStrategy;
        public void setSalaryStrategy(ISalaryStrategy ISalaryStrategy)
        {
            _ISalaryStrategy = ISalaryStrategy;
        }

        public Employee GetUpdatedData(int id,double salary)
        {
            var getDataById = loadData.GetData().Where(a => a.id == id).FirstOrDefault();
            getDataById.Salary = _ISalaryStrategy.CalculateSalary(salary);
            return getDataById; 
        }
        public Employee GetDataById(int id)
        {
            var getDataById = loadData.GetData().Where(a => a.id == id).FirstOrDefault();
            return getDataById;
        }
    }
}
