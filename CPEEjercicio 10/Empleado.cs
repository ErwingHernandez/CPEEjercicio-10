using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPEEjercicio_10
{
    internal class Empleado:Persona
    {
        private float sueldo_bruto;

        public Empleado(float sueldo_bruto)
        {
            this.sueldo_bruto = sueldo_bruto;
        }

        public float Sueldo_bruto { get => sueldo_bruto; set => sueldo_bruto = value; }

        public override void Mostrar()
        {
            base.Mostrar();
        }
        public void CalSalNeto()
        {
            Console.WriteLine(this.sueldo_bruto);
        }
    }
}
