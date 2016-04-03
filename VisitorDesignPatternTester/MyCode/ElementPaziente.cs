using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDesignPatternTester.MyCode
{
    /// <summary>
    /// The 'ConcreteElement' class
    /// </summary>
    class Paziente : Element
    {
        private string _nome;
        private bool _haMalDiTesta;
        private bool _haMalDiPancia;
        private bool _haMalDiSchiena;

        // Constructor
        public Paziente(string nome, bool haMalDiTesta, bool haMalDiPancia, bool haMalDiSchiena)
        {
            this._nome = nome;
            this._haMalDiTesta = haMalDiTesta;
            this._haMalDiPancia = haMalDiPancia;
            this._haMalDiSchiena = haMalDiSchiena;
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public bool HaMalDiTesta
        {
            get { return _haMalDiTesta; }
            set { _haMalDiTesta = value; }
        }
        public bool HaMalDiPancia
        {
            get { return _haMalDiPancia; }
            set { _haMalDiPancia = value; }
        }
        public bool HaMalDiSchiena
        {
            get { return _haMalDiSchiena; }
            set { _haMalDiSchiena = value; }
        }

        public override void Accept(IVisitor medicoSpecialista)
        {
            medicoSpecialista.Visit(this);
        }
    }
}
