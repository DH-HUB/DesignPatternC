using DesignPatternC;
using DesignPatternC.Adapter;
using DesignPatternC.Bridge;
using DesignPatternC.Composite;
using DesignPatternC.Facade;
using DesignPatternC.Observer;
using DesignPatternC.Strategy;
using DesignPatternC.Prototype;
using DesignPatternC.Singleton;
using System.Collections.Generic;
internal class Program
{
    private static void Main(string[] args)
    {
        ;



        /***************************************Singleton ********************************************/

        // Création d'instance unique de la classe LiasseVierge
        LiasseVierge liasseVierge = LiasseVierge.Instance;


        /***************************************Adapter  ******************************************************/
        // Création du PDF
        DocumentPdf docPdf = new DocumentPdf();
        docPdf.setContenu("Contenu du document PDF");

        // Ajout du doc PDF à la liasse vierge
        liasseVierge.ajoute(docPdf);

        // Création du doc HTML (adapté pour le composant PDF)
        DocumentHtml docHtml = new DocumentHtml();
        docHtml.setContenu("Contenu du document HTML");

        // Adaptation du doc TML pour utiliser le composant PDF
        DocumentPdf docHtmlPdf = new DocumentPdfAdapter(docHtml);

        // Ajout du doc HTML adapté à la liasse vierge
        liasseVierge.ajoute(docHtmlPdf);


        liasseVierge.affiche();


        liasseVierge.retire(docPdf);

        // Affichage des docs restants dans la liasse vierge
        liasseVierge.affiche();

        Console.ReadLine();

        /*****************************************Bridge *******************************************************/

        FormulaireImmatriculation formulaire = new FormulaireImmatriculationFrance(new FormulaireHtmlImpl());
        formulaire.Affiche();
        formulaire.GereSaisie();

        /******************************************Composite / Strategy*************************************************/
        SocieteMere societeMere = new SocieteMere("Societe Mere");
        SocieteSansFiliale societeSansFiliale = new SocieteSansFiliale("Societe sans filiale");

        Vehicule vehicule1 = new Vehicule("BMW", "M4 CSL", 765000, "photo1.jpg");
        Vehicule vehicule2 = new Vehicule("AUDI", "R8", 186000, "photo2.jpg");
        Vehicule vehicule3 = new Vehicule("TESLA", "Roadster", 240000, "photo3.jpg");
        Vehicule vehicule4 = new Vehicule("MERCEDES", "EQE", 76250, "photo4.jpg");
        societeMere.ajouterVehicule(vehicule1);
        societeMere.ajouterVehicule(vehicule2);
        societeMere.ajouterVehicule(vehicule3);
        societeMere.ajouteFiliale(societeSansFiliale);
        societeSansFiliale.ajouterVehicule(vehicule4);
        IDessinCatalogue dessinUnVehiculeLigne = new DessinUnVehiculeLigne("Affichage en une seule ligne");
        IDessinCatalogue dessinTroisVehiculesLigne = new DessinTroisVehiculesLigne("Affichage de trois véhicules par ligne");

        // dessin des véhicules avec la stratégie de dessin "une seule ligne"
        dessinUnVehiculeLigne.Dessine(societeMere.getListeVehicules());
        dessinUnVehiculeLigne.Dessine(societeSansFiliale.getListeVehicules());

        // dessin des véhicules avec la stratégie de dessin "trois véhicules par ligne"
        dessinTroisVehiculesLigne.Dessine(societeMere.getListeVehicules());
        dessinTroisVehiculesLigne.Dessine(societeSansFiliale.getListeVehicules());

        Console.ReadKey();


        // Calcul entretien total de la société mère et de ses filiales
        societeMere.calculCoutEntretien();

        // Affichage entretien total de la société mère et de ses filiales
        Console.WriteLine($"Le coût d'entretien total est de : {societeMere.GetCoutEntretienTotal()}");

        Console.ReadLine();

        /****************************************** /Facade et Strategy *************************************************/
        /*Console.WriteLine("Bienvenue sur le service Web Auto !");
        Console.WriteLine("-----------------------------------");

        WebserviceAuto webservice = new WebserviceAuto();

        // prix moyen des véhicules
        double prixMoyen = webservice.CalculPrixMoyen();

        // écart maximum entre le prix de chaque véhicule et le prix moyen
        double ecartMax = webservice.CalculEcartMax(prixMoyen);

        // Affichage des résultats
        Console.WriteLine("Le prix moyen des véhicules est de : " + prixMoyen + " euros.");
        Console.WriteLine("L'écart maximum entre le prix de chaque véhicule et le prix moyen est de : " + ecartMax + " euros.");


        Console.WriteLine($"Voici les véhicules disponibles entre {prixMoyen - ecartMax} et {prixMoyen + ecartMax} euros :");

        var vehicules = webservice.chercheVehicules(prixMoyen, ecartMax);

        foreach (var vehicule in vehicules)
        {
            Console.WriteLine($"- {vehicule}");
        }

        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Merci d'avoir utilisé notre service !");
        Console.ReadKey();*/
        Console.WriteLine("Bienvenue sur le service Web Auto !");
        Console.WriteLine("-----------------------------------");

        WebserviceAuto webservice = new WebserviceAuto();

        double prixMoyen = 15000;
        double ecartMax = 2000;


        Console.WriteLine($"Voici les véhicules disponibles entre {prixMoyen - ecartMax} et {prixMoyen + ecartMax} euros :");

        var vehicules = webservice.chercheVehicules(prixMoyen, ecartMax);

        foreach (var vehicule in vehicules)
        {
            Console.WriteLine($"- {vehicule}");
        }

        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Merci d'avoir utilisé notre service !");
        Console.ReadKey();

        /****************************************** Observer *************************************************/
        Sujet.CatalogueVehicules catalogue = new Sujet.CatalogueVehicules();

        // Ajouter des véhicules au catalogue
        catalogue.ajouteVehicule(new Vehicule("Peugeot 208", 15000, catalogue));
        catalogue.ajouteVehicule(new Vehicule("Renault Clio", 16000, catalogue));
        catalogue.ajouteVehicule(new Vehicule("Volkswagen Golf", 20000, catalogue));

        // Créer des vues pour les véhicules
        VueVehicule vue1 = new VueVehicule(catalogue.getVehicules()[0]);
        VueVehicule vue2 = new VueVehicule(catalogue.getVehicules()[1]);

        // Afficher les vues
        vue1.affiche();
        vue2.affiche();


        Console.ReadKey();
        /****************************************** Prototype *************************************************/
        //création instance de la classe Liasse et ajout des diffs docs à la liasse. Cloner la liasse et afficher les documents clonés

        // Création d'une liasse v
        LiasseVierge liasseViergev = new LiasseVierge();

        // Ajout des docs à la liasse v
        liasseVierge.ajoute(new BonDeCommande());
        liasseVierge.ajoute(new DemandeImmatriculation());
        liasseVierge.ajoute(new CertificatCession());

        // Création d'une liasse c
        LiasseClient liasseClient = new LiasseClient();

        // Clonage de la liasse vierge et remplissage des copies
        liasseClient.creer(liasseVierge);

        Dictionary<string, string> informations = new Dictionary<string, string>();
        informations.Add("nom", "Dupont");
        informations.Add("adresse", "123 rue de la Paix");
        informations.Add("ville", "Paris");
        Console.ReadKey();
    }
}