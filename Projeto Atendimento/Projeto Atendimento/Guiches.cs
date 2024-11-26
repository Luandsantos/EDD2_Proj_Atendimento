using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Atendimento
{
    internal class Guiches
    {
        private List<Guiche> listaGuiches;

        public List<Guiche> ListaGuiches
        {
            get { return listaGuiches; }
            set { listaGuiches = value; }
        }

        public Guiches()
        {
            ListaGuiches = new List<Guiche>();
        }

        public void adicionar(Guiche guiche)
        {
            ListaGuiches.Add(guiche);
        }
    }
}
