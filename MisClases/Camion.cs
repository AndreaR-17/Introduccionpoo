using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using p1bpoo.MisClases;

namespace Poo_tarea1.MisClases
{
    internal class Camion: Vehiculo    {
        private int capacidadDeVolteo;
        private int nivelAgua;
        private int nivelAceite;
        private int v;

        public Camion(int anio, string elColor, string elModelo, int v) : base(anio, elColor, elModelo)
        {
            this.v = v;
        }

        public Camion (int anio, string elColor, string elModelo, int capacidadDeVolteo, int nivelAgua, int nivelAceite) : base(anio, elColor, elModelo, capacidadDeVolteo, nivelAgua, nivelAceite)
        {
            this.capacidadDeVolteo = capacidadDeVolteo;
            this.nivelAgua = 100;
            this.nivelAceite = 75;
        }
        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto / 2);
        }

        public void AgregarAgua(int cantidad)
        {
            nivelAgua += cantidad;
            Console.WriteLine("El agregado ha sido agregado. El nivel de agua es {0}", nivelAgua);
        }

    }
}
