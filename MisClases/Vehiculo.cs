using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Vehiculo
    {
        public string Color { get; set; }
        public string Modelo { get; }
        public int Year { get; }

        private int velocidad = 0;
        private int capacidadDeVolteo;
        private int nivelAgua;
        private int nivelAceite;

        public Vehiculo(int anio, string elColor, string elModelo)
        {
            this.Color = elColor;
            this.Modelo = elModelo;
            this.Year = anio;

        }

        public Vehiculo(int anio, string elColor, string elModelo, int capacidadDeVolteo, int nivelAgua, int nivelAceite) : this(anio, elColor, elModelo)
        {
            this.capacidadDeVolteo = capacidadDeVolteo;
            this.nivelAgua = nivelAgua;
            this.nivelAceite = nivelAceite;
        }

        public void InformacionVehiculo()
        {
            Console.WriteLine("Color {0}:", this.Color);
            Console.WriteLine("Modelo {0}:", this.Modelo);
            Console.WriteLine("Año {0}", this.Year);
        }
        public virtual void acelerar(int cuanto)
        {
            velocidad += cuanto;
            Console.WriteLine("vas a {0} KMS / Hora", velocidad);
        }
        public virtual void frenar(int cuanto)
        {
            velocidad -= cuanto;
            Console.WriteLine("vas a {0} KMS / Hora", velocidad);
        }
        public virtual void encender()
        {
            Console.WriteLine("Vehiculo encendido");
        }
        public virtual void apagar()
        {
            Console.WriteLine("Vehiculo apagado");
        }

        public void RevisionAgua() => Console.WriteLine($"El nivel de agua es {nivelAgua}");
    }
}
