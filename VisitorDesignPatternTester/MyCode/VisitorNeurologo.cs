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
    class Neurologo : IVisitor
    {
        public void Visit(Element element)
        {
            Paziente p = element as Paziente;

            if (p.HaMalDiTesta)
            {
                Console.WriteLine("{0} {1} ha mal di testa e viene curato dal neurologo", p.GetType().Name, p.Nome);
            }
        }
    }
}
