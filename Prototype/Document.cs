using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternC.Prototype
{
    //définit le comportement de base des diff types de docs
    public abstract class Document : ICloneable
    {
        public abstract void imprime();
        public abstract void affiche();
        public abstract void remplir(Dictionary<string, string> informations);
        public abstract object Clone();

        internal Document clone()
        {
            throw new NotImplementedException();
        }
    }
}
