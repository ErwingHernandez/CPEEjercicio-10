using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPEEjercicio_10
{
    internal class Cliente: Persona
    {
        int telf;

        public Cliente(int telf)
        {
            this.telf = telf;
        }

        public int Telf { get => telf; set => telf = value; }

        public override void Mostrar()
        {
            base.Mostrar(); Console.WriteLine(" telf: "+ this.Telf);
        }
    }
}
