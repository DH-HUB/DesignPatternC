using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternC;
using DesignPatternC.Strategy;
using DesignPatternC.Facade;
using DesignPatternC.Adapter;

namespace DesignPatternC.Bridge
{
    public abstract class FormulaireImmatriculation
    {
        protected IFormulaireImpl impl;

        public FormulaireImmatriculation(IFormulaireImpl impl)
        {
            this.impl = impl;
        }

        public abstract void Affiche();
        public abstract void GenereDocument();
        public abstract bool ControleSaisie(string plaque);
        public abstract void GereSaisie();
    }
}
