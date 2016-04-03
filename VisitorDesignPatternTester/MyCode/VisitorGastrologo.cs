using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPatternTester.MyCode
{
    /// <summary>
    /// A 'ConcreteVisitor' class
    /// </summary>
    class Gastrologo : IVisitor
    {
        public void Visit(Element element)
        {
            Paziente p = element as Paziente;

            if (p.HaMalDiPancia)
            {
                Console.WriteLine("{0} {1} ha mal di pancia e viene curato dal gastrologo", p.GetType().Name, p.Nome);
            }
        }
    }
}
