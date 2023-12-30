using System;
using System.ComponentModel;
using System.Data;

namespace Stratgy_pattern.Cores
{
    public class loadData
    {
        public static List<Employee>GetData()
        {
            var result=new List<Employee>()
            {
                new Employee()
                {
                    id=1,
                    Name="Marwan Alsayed Ahmed",
                    PositionValue=nameof(Enum.Position.Employee),
                    Position=Enum.Position.Employee
                 },
                 new Employee()
                {
                    id=2,
                    Name="Saber Alsayed Ahmed",
                    PositionValue=nameof(Enum.Position.Supervisor),
                    Position=Enum.Position.Supervisor
                },
                  new Employee()
                {
                    id=3,
                    Name="Amira Alsayed Ahmed",
                    PositionValue=nameof(Enum.Position.Manager),
                    Position=Enum.Position.Manager
                }
            };
            return result;

        }
    }
}
