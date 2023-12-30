using Stratgy_pattern.Cores.DiscoundStrategyPattern;

namespace Stratgy_pattern.Cores.SalaryStrategyPattern
{
    public class ManagerStrategy : ISalaryStrategy
    {
        public double CalculateSalary(double salary)
        {
            var result = salary * 10;
            return result;
        }
    }
}
