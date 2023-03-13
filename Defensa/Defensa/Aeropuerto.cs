
using System;

namespace Defensa
{
	/// <summary>
	/// Description of Aeropuerto.
	/// </summary>
	public class Aeropuerto
	{
		private String nombre;
		private int nv;
		private String [,]v = new String[6,31];
		public Aeropuerto()
		{
			nombre="Viru Viru";
			nv=1;
			v[1,1]="Santa Cruz";
			v[2,1]="Pando";
			v[3,1]="07:00";
			v[4,1]="6746-AHG";
			v[5,1]="12/06/23";
		}
		public Aeropuerto(String a)
		{
			nombre=a;
			nv=3;
			v[1,1]="La Paz";
			v[2,1]="Cobija";
			v[3,1]="19:00";
			v[4,1]="453-DFG";
			v[5,1]="20/06/23";
			
			v[1,2]="Santa Cruz";
			v[2,2]="Cobija";
			v[3,2]="15:00";
			v[4,2]="6746-AHG";
			v[5,2]="18/06/23";
			
			v[1,2]="Santa Cruz";
			v[2,2]="Pando";
			v[3,2]="20:00";
			v[4,2]="3241-UIY";
			v[5,2]="24/06/23";
		}
		public void mostrar(){
			Console.WriteLine("Nombre = {0} ++ Numero de vuelo: {1}",nombre,nv);
			for(int i=1; i<=nv; i++){
				Console.WriteLine("===================");
				Console.WriteLine("origen: {0}",v[1,i]);
				Console.WriteLine("destino: {0}",v[2,i]);
				Console.WriteLine("Hora de Salida: {0}",v[3,i]);
				Console.WriteLine("Placa de avioneta: {0}",v[4,i]);
				Console.WriteLine("Fecha: {0}",v[5,i]);
			}
		}
		public string Nombre {
			get { return nombre; }
			set { nombre = value; }
		}

		public int Nv {
			get { return nv; }
			set { nv = value; }
		}

		public string[,] V {
			get { return v; }
			set { v = value; }
		}
		public int mayorcantidad(){
			int s=0;
			for(int i=1; i<=nv; i++){
				if(v[1,i]=="Santa Cruz" && v[2,i]=="Cobija")
					s+=1;
			}
			return s;
		}
		public void mostrarfechahora(Aeropuerto a2,Avioneta av1){
			String p=av1.Placa;
			int i;
			Console.WriteLine("La Avioneta {0} tiene las siguientes fechas y horas de salida",p);
			for(i=1; i<=nv; i++){
				if(p==V[4,i]){
					Console.WriteLine("--------------------");
					Console.WriteLine("Hora de Salida: {0}",V[3,i]);
					Console.WriteLine("Fecha de Salida: {0}",V[5,i]);
					Console.WriteLine("--------------------");
				}
			}
			for(i=1; i<=a2.nv; i++){
				if(p==a2.V[4,i]){
					Console.WriteLine("--------------------");
					Console.WriteLine("Hora de Salida: {0}",a2.V[3,i]);
					Console.WriteLine("Fecha de Salida: {0}",a2.V[5,i]);
					Console.WriteLine("--------------------");
				}
			}
		}
		public void Ordenar(){
			String [] vector=new String[31];
			int c=0;
			for(int i=0;i<=nv;i++){
				bool sw=true;
				for(int j=0;j<c;j++){
					if(V[2,i]==vector[j])
						sw=false;
				}
				if(sw){
					vector[c]=V[2,i];
					c+=1;
				}
			}
			String [,]matriz=new String[6,31];
			int g=1;
			for(int i=0;i<c;i++){
				for(int j=1;j<=nv;j++){
					if(vector[i]==V[2,j]){
						matriz[1,g]=V[1,j];
						matriz[2,g]=V[2,j];
						matriz[3,g]=V[3,j];
						matriz[4,g]=V[4,j];
						matriz[5,g]=V[5,j];
					}
				}
			}
			V=matriz;
		}
	}
}
