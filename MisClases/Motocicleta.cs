using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Motocicleta : Vehiculo
    {
        private int cilindrada;
        private int nivelAceite;
        private int v;

        public Motocicleta(int anio, string elColor, string elModelo, int cilindrada, string v) : base(anio, elColor, elModelo)
        {
            this.cilindrada = cilindrada;
            this.nivelAceite = 100;
        }

        public Motocicleta(int anio, string elColor, string elModelo, int v) : base(anio, elColor, elModelo)
        {
            this.v = v;
        }

        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto * 2);
        }
   
        public void revisionAceite()
        {
            
                Console.WriteLine("El nivel de aceite es {0}", nivelAceite);
            }
        public void AgregarAceite(int cantidad)
        {
            nivelAceite += cantidad;
            Console.WriteLine("El aceite ha sido agregado. El nivel de aceite es {0}", nivelAceite);
        }

    }
}
