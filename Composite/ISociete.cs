using DesignPatternC.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternC.Composite
{
    interface ISociete
    {
        void calculCoutEntretien();
        void ajouterVehicule(Vehicule vehicule);
    }
}
