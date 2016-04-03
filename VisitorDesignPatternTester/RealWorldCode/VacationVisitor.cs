using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPatternTester.RealWorldCode
{
    /// <summary>
    /// A 'ConcreteVisitor' class
    /// </summary>
    class VacationVisitor : IVisitor
    {
        public void Visit(Element element)
        {
            Employee employee = element as Employee;

            // Provide three extra  vacation days
            employee.VacationDays += 3;
            Console.WriteLine("{0} {1}'s new vacation day: {2}", employee.GetType().Name, employee.Name, employee.VacationDays);
        }
    }
}
