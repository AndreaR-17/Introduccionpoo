using p1bpoo.MisClases;
using Poo_tarea1.MisClases;

Vehiculo miCarrito = new Vehiculo(2026, "Azul", "Alfa Romeo");

Vehiculo elOtro = new Vehiculo(2000, "Rojo", "DELOREAN");

CarroElectrico miBYD = new CarroElectrico(2026, "Amarillo", "BYD");

miBYD.InformacionVehiculo();
miBYD.cargarBateria();
Console.WriteLine("El nivel de bateria es: {0}", miBYD.NivelBateria());

AutoDeCombustion miAuto = new AutoDeCombustion(2000, "Verde", "Mustang", 500, "Gasolina");
miAuto.encender();
miAuto.InformacionVehiculo();
miAuto.acelerar(100);
miAuto.frenar(50);
miAuto.cargarCombustible(50);

Motocicleta miMoto = new Motocicleta(2000, "azul", "Honda", 350);
miMoto.encender();
miMoto.InformacionVehiculo();
miMoto.acelerar(100);
miMoto.frenar(50);
miMoto.revisionAceite();
miMoto.AgregarAceite(100);
Camion miCamion = new Camion(2015, "Negro", "Toyota", 850);
miCamion.encender();
miCamion.InformacionVehiculo();
miCamion.acelerar(60);
miCamion.frenar(30);