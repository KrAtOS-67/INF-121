using System;

namespace Defensa
{
	class Program
	{
		public static void Main(string[] args)
		{
			//numero 1
			Aeropuerto a1=new Aeropuerto();
			Aeropuerto a2=new Aeropuerto("Aeropuerto de El Alto");
			Avioneta av1= new Avioneta("6746-AHG","Roberto","ps1","ps2","ps3","ps4","ps5");
			//numero 2
			Console.WriteLine("===============Numero 2)===============");
			if(a1.mayorcantidad()>a2.mayorcantidad())
				Console.WriteLine("El aeropuerto con mayor cantidad de salidas por avioneta es {0}",a1.Nombre);
			else
				Console.WriteLine("El aeropuerto con mayor cantidad de salidas por avioneta es {0}",a2.Nombre);
			Console.WriteLine("=======================================");
			Console.WriteLine("===============Numero 3)===============");
			a1.mostrarfechahora(a2,av1);
			Console.WriteLine("=======================================");
			Console.WriteLine("===============Numero 4)===============");
			a1.Ordenar();
			a2.Ordenar();
			a1.mostrar();
			a2.mostrar();
			Console.WriteLine("=======================================");
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}