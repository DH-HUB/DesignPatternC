using DesignPatternC.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternC.Composite
{
    class SocieteMere : ISociete
    {
        private List<ISociete> filiales = new List<ISociete>();
        private List<Vehicule> vehicules = new List<Vehicule>();
        private string v;

        public SocieteMere(string v)
        {
            this.v = v;
        }

        public void ajouteFiliale(ISociete filiale)
        {
            filiales.Add(filiale);
        }

        public void calculCoutEntretien()
        {
            double coutTotal = 0;

            // Coût d'entretien pour chaque filiale et ajout au coût total
            foreach (ISociete filiale in filiales)
            {
                filiale.calculCoutEntretien();
                coutTotal += 5000;
            }

            // Coût d'entretien pour les véhicules de la société mère
            foreach (Vehicule vehicule in vehicules)
            {
                coutTotal += vehicule.GetCoutEntretienAnnuel();
            }

            Console.WriteLine("La société mère et ses filiales ont un coût d'entretien total de " + coutTotal + " euros.");
        }

        public void ajouterVehicule(Vehicule vehicule)
        {
            vehicules.Add(vehicule);
            Console.WriteLine($"Le véhicule {vehicule.Modele} a été ajouté à la société {this.v}.");
        }

        internal double GetCoutEntretienTotal()
        {
            double coutTotal = 0;

            // Calcul d'entretien pour chaque filiale et ajout au coût total
            foreach (ISociete filiale in filiales)
            {
                filiale.calculCoutEntretien();
                coutTotal += 4000;
            }

            // Calcul d'entretien pour les véhicules de la société mère
            foreach (Vehicule vehicule in vehicules)
            {
                coutTotal += vehicule.GetCoutEntretienAnnuel();
            }

            return coutTotal;
        }

        internal List<Vehicule> getListeVehicules()
        {
            return vehicules;
            
        }
    }
}

