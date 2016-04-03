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
    class Ortopedico : IVisitor
    {
        public void Visit(Element element)
        {
            Paziente p = element as Paziente;

            if (p.HaMalDiSchiena)
            {
                Console.WriteLine("{0} {1} ha mal di schiena e viene curato dall'ortopedico", p.GetType().Name, p.Nome);
            }
        }
    }
}
