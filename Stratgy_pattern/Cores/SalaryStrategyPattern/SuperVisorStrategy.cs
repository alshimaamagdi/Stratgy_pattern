using Stratgy_pattern.Cores.DiscoundStrategyPattern;

namespace Stratgy_pattern.Cores.SalaryStrategyPattern
{
    public class SuperVisorStrategy : ISalaryStrategy
    {
        public double CalculateSalary(double salary)
        {
            var result = salary * 20;
            return result;
        }
    }
}
