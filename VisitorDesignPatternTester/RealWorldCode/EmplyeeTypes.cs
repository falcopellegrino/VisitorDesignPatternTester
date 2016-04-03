using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPatternTester.RealWorldCode
{
    // Three employee types

    class Clerk: Employee
    {
        // Constructor
        public Clerk()
            :base("Hank", 25000, 14)
        {
        }
    }

    class Director : Employee
    {
        // Constructor
        public Director()
            : base("Elly", 35000, 16)
        {
        }
    }

    class President : Employee
    {
        // Constructor
        public President()
            : base("Dick", 45000, 21)
        {
        }
    }
}
