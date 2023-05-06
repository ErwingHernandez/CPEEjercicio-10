using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPEEjercicio_10
{
    internal class Directivo: Persona
    {
        private string categ;

        public Directivo(string categ)
        {
            this.categ = categ;
        }

        public string Categ { get => categ; set => categ = value; }

        public override void Mostrar()
        {
            base.Mostrar();
        }
    }
}
