using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternC.Facade;
using DesignPatternC.Bridge;

namespace DesignPatternC.Strategy
{
    //  stratégies de dessin du catalogue
    interface IDessinCatalogue
    {
        void Dessine(List<Vehicule> vehicules);

    }
}