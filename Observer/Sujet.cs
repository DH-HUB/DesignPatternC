using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternC.Adapter;
using DesignPatternC.Bridge;
using DesignPatternC.Composite;
using DesignPatternC.Facade;
using DesignPatternC.Strategy;

namespace DesignPatternC.Observer
{
    public class Sujet
    {
        public class CatalogueVehicules
        {
            private List<IObservateur> observateurs = new List<IObservateur>();
            private List<Vehicule> vehicules = new List<Vehicule>();

            public void ajoutObservateur(IObservateur observateur)
            {
                observateurs.Add(observateur);
            }

            public void retireObservateur(IObservateur observateur)
            {
                observateurs.Remove(observateur);
            }

            public void notifieObservateurs()
            {
                foreach (IObservateur observateur in observateurs)
                {
                    observateur.actualise();
                }
            }

            public void ajouteVehicule(Vehicule vehicule)
            {
                vehicules.Add(vehicule);
                notifieObservateurs();
            }

            public List<Vehicule> getVehicules()
            {
                return vehicules;
            }

            internal object getListeVehicules()
            {
                return vehicules;
            }

            public static implicit operator CatalogueVehicules(string v)
            {
                throw new NotImplementedException();
            }
        }

    }
}