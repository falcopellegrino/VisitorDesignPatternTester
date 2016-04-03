using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPatternTester.MyCode
{
    /// <summary>
    /// The 'ObjectStructure' class
    /// </summary>
    class Pazienti
    {
        private List<Paziente> _pazienti = new List<Paziente>();

        public void Attach(Paziente paziente)
        {
            _pazienti.Add(paziente);
        }

        public void Detach(Paziente paziente)
        {
            _pazienti.Remove(paziente);
        }

        public void Accept(IVisitor medicoSpecialista)
        {
            foreach (Paziente p in _pazienti)
            {
                p.Accept(medicoSpecialista);
            }
            Console.WriteLine();
        }
    }
}
