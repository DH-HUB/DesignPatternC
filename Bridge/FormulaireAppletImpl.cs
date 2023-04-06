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

    public class FormulaireAppletImpl : IFormulaireImpl
    {
        public void DessineText(string texte)
        {
            Console.WriteLine($"Applet : {texte}");
        }

        public string GereZoneSaisie()
        {
            return Console.ReadLine();
        }
    }
}