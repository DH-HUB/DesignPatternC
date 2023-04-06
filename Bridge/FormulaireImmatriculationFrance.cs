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
    public class FormulaireImmatriculationFrance : FormulaireImmatriculation
    {
        public FormulaireImmatriculationFrance(IFormulaireImpl impl) : base(impl)
        {
        }

        public override void Affiche()
        {
            impl.DessineText("Numéro d'immatriculation : ");
        }

        public override void GenereDocument()
        {
            Console.WriteLine("Document d'immatriculation (France) généré.");
        }

        public override bool ControleSaisie(string plaque)
        {
            return plaque.Length == 7;
        }

        public override void GereSaisie()
        {
            string plaque = impl.GereZoneSaisie();
            if (ControleSaisie(plaque))
            {
                GenereDocument();
            }
            else
            {
                Console.WriteLine("La plaque d'immatriculation n'est pas valide.");
            }
        }
    }
}