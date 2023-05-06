using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPEEjercicio_10
{
    internal class Empresa
    {
        private string nom;

        public Empresa(string nom)
        {
            this.nom = nom;
        }

        public string Nom { get => nom; set => nom = value; }
    }
}
