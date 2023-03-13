using System;

namespace Defensa
{
	/// <summary>
	/// Description of Avioneta.
	/// </summary>
	public class Avioneta
	{
		private String placa;
		private String piloto;
		private String pasajero1;
		private String pasajero2;
		private String pasajero3;
		private String pasajero4;
		private String pasajero5;
		
		public Avioneta()
		{
			placa = "1234-ABC";
			piloto = "Agustin";
			pasajero1 = "p1";
			pasajero2 = "p2";
			pasajero3 = "p3";
			pasajero4 = "p4";
			pasajero5 = "p5";
		}
		public Avioneta(String a,String b,String c,String d,String e,String f,String g)
		{
			placa = a;
			piloto = b;
			pasajero1 = c;
			pasajero2 = d;
			pasajero3 = e;
			pasajero4 = f;
			pasajero5 = g;
		}
		public void mostrar(){
			Console.WriteLine("placa: {0} ++ piloto: {1} ++ pasajero1: {2} ++ pasajero2: {3} ++ pasajero3: {4} ++ pasajero4: {5} ++ pasajero5: {6}",placa,piloto,pasajero1,pasajero2,pasajero3,pasajero4,pasajero5);
		}
		public string Placa {
			get { return placa; }
			set { placa = value; }
		}

		public string Piloto {
			get { return piloto; }
			set { piloto = value; }
		}

		public string Pasajero1 {
			get { return pasajero1; }
			set { pasajero1 = value; }
		}

		public string Pasajero2 {
			get { return pasajero2; }
			set { pasajero2 = value; }
		}

		public string Pasajero3 {
			get { return pasajero3; }
			set { pasajero3 = value; }
		}

		public string Pasajero4 {
			get { return pasajero4; }
			set { pasajero4 = value; }
		}

		public string Pasajero5 {
			get { return pasajero5; }
			set { pasajero5 = value; }
		}
		
	}
}
