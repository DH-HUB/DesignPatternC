using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternC;
using DesignPatternC.Strategy;
using DesignPatternC.Facade;
using DesignPatternC.Bridge;

namespace DesignPatternC.Adapter
{
    public interface Document
    {
        void setContenu(string contenu);
        void dessine();
        void imprime();
    }
}