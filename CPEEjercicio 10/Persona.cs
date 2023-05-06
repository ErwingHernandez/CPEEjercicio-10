using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPEEjercicio_10
{
    internal class Persona
    {
        private string nom;
        private int edad;

        public Persona() { }
        public Persona(string nom, int edad)
        {
            this.nom = nom;
            this.edad = edad;
        }

        public string Nom { get => nom; set => nom = value; }
        public int Edad { get => edad; set => edad = value; }

        public virtual void Mostrar()
        {
            Console.WriteLine("Nombre: " + this.Nom + "\nEdad: "+this.Edad);
        }
    }
}
