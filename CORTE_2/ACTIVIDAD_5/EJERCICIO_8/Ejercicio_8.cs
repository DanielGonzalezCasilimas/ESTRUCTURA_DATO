using System;

/*  *GROUP MEMBERS
        Roa Ruiz Maria Camila
        Barbosa Fierro Luis Esteban
        Cardona Acuña David Esteban
        González Casilimas Daniel Stevan
     *SHIFT
        diurnal
     *GROUP
        63102C / 239-2A 
    */

namespace Ejercicio_Prueba {
	class Prueba {

		static void Main(string[] args) {
			int a;
			int cantidad3ens1;
			int i;
			double maxsucursal;
			int mejorsucursal;
			int s;
			double total;
			int totals2;

			int[] precios = new int[5];
			int[,] ventassucursal = new int[4,5];
			Console.WriteLine("Dime los precios");
			for (i=0;i<=4;i++) 
			{
				Console.Write("Árticulo " + (i+1) + " : $");
				precios[i] = int.Parse(Console.ReadLine());
			}
			
			for (s=0;s<=3;s++) 
			{
				Console.WriteLine("");
				Console.WriteLine("Cantidad de árticulos que compro en la sucursal N° : "+ (s+1));
				
				for (a=0;a<=4;a++) {
					Console.Write(" -> Árticulo " + (a+1) + " : ");
					ventassucursal[s,a] = int.Parse(Console.ReadLine());
				}
			}
			
			int[] cantidades = new int[5];
			for (i=0;i<=4;i++) {
				
				cantidades[i] = 0;
			}
			
			totals2 = 0;
			
			cantidad3ens1 = ventassucursal[1,3];
			
			double[] recaudaciones = new double[4];
			for (i=0;i<=3;i++) {
				recaudaciones[i] = 0;
			}
			
			total = 0;
			
			maxsucursal = 0;
			for (s=0;s<=3;s++) {
				for (a=0;a<=4;a++) {
					cantidades[a] = cantidades[a]+ventassucursal[s,a];
					if (s==2) {
						totals2 = totals2+ventassucursal[s,a];
					}
					recaudaciones[s] = recaudaciones[s]+(ventassucursal[s,a]*precios[a]);
					total = total+(ventassucursal[s,a]*precios[a]);
				}
			}

			Console.WriteLine("");
			Console.WriteLine("Total de Ventas por Articulos");
			Console.WriteLine("");
			for (i=0;i<=4;i++) {
				Console.WriteLine("Árticulo "+ (i+1) +" Total : "+cantidades[i]);
			}

			Console.WriteLine("");
			Console.WriteLine("Total ventas Sucursal 2 : "+totals2);

			Console.WriteLine("");
			Console.WriteLine("Cantidad de compra de Árticulos en el Árticulo N°3 de la sucursal en la sucursal 1 : " +cantidad3ens1);

			Console.WriteLine("");
			Console.WriteLine("Recaudacion de cada sucursal");

			for (i=0;i<=3;i++) 
			{
				if (recaudaciones[i]>maxsucursal) 
				{
					maxsucursal = recaudaciones[i];
					mejorsucursal = i;
				}

				
				Console.WriteLine($"La mayor sucursal Hasta el momento es :  {maxsucursal}" );
				Console.WriteLine("");
				Console.WriteLine("El Total en sucursal "+(i+1)+" Es :"+recaudaciones[i]);
			}
			Console.WriteLine("");
			Console.WriteLine("Recaudacion total de la empresa "+total);
		}
	}
}