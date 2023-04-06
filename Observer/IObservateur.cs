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
    public interface IObservateur
    {
        void actualise();
    }
}