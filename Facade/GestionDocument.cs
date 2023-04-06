using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternC;
using DesignPatternC.Strategy;
using DesignPatternC.Bridge;

namespace DesignPatternC.Facade
{
    public class GestionDocument
    {
        public void ajouteDocument(Vehicule vehicule, string document)
        {
            Console.WriteLine("Ajout du document \"" + document + "\" pour le véhicule \"" + vehicule.marque + " " + vehicule.modele + "\"");
        }
    }
}
