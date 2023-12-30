using Stratgy_pattern.Cores.DiscoundStrategyPattern;

namespace Stratgy_pattern.Cores.SalaryStrategyPattern
{
    public class EmployeeStrategy : ISalaryStrategy
    {
        public double CalculateSalary(double salary)
        {
          var result = salary * 5;
          return result;

        }
    }
}
