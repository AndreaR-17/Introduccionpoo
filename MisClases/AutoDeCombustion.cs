using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class AutoDeCombustion : Vehiculo
    {
        private int nivelCombustible;
        public AutoDeCombustion(int anio, string elColor, string elModelo, int v, string v1) : base(anio, elColor, elModelo)
        {
            this.nivelCombustible = 100;
        }

        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto);
            nivelCombustible -= (cuanto / 10);
        }

        public override void frenar(int cuanto)
        {
            base.frenar(cuanto);
            nivelCombustible -= (cuanto / 10);
        }
        public void cargarCombustible(int cantidad)
        {
            nivelCombustible += cantidad;
        }

    }
}

