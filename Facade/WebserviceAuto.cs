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
    public class WebserviceAuto
    {
        private Catalogue catalogue = new Catalogue();
        private GestionDocument gestionDocument = new GestionDocument();
        private RepriseVehicule repriseVehicule = new RepriseVehicule();

        public void ajouteVehicule(Vehicule vehicule)
        {
            catalogue.ajouteVehicule(vehicule);
        }

        public List<Vehicule> chercheVehicules(double prixMoyen, double ecartMax)
        {
            double prixMin = prixMoyen - ecartMax;
            double prixMax = prixMoyen + ecartMax;
            return catalogue.retrouveVehicules(prixMin, prixMax);
        }

        public void ajouteDocument(Vehicule vehicule, string document)
        {
            gestionDocument.ajouteDocument(vehicule, document);
        }

        public void demandeReprise(Vehicule vehicule)
        {
            repriseVehicule.demandeReprise(vehicule);
        }

    /*    public double CalculPrixMoyen()
        {
            List<Vehicule> vehicules = catalogue.getVehicules();
            double prixTotal = 0;

            foreach (Vehicule vehicule in vehicules)
            {
                prixTotal += vehicule.prix;
            }

            return vehicules.Count > 0 ? prixTotal / vehicules.Count : 0;
        }

        public double CalculEcartMax(double prixMoyen)
        {
            List<Vehicule> vehicules = catalogue.getVehicules();
            double ecartMax = 0;

            foreach (Vehicule vehicule in vehicules)
            {
                double ecart = Math.Abs(prixMoyen - vehicule.prix);
                if (ecart > ecartMax)
                {
                    ecartMax = ecart;
                }
            }

            return ecartMax;
        }*/
    }
}
