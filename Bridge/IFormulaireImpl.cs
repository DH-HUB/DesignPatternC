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
  
    public interface IFormulaireImpl
    {
        void DessineText(string texte);
        string GereZoneSaisie();
    }
}