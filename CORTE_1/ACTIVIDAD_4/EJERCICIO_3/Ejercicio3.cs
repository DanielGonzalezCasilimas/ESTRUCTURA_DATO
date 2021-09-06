using System;

/*
    GROUP MEMBERS
        Roa Ruiz Maria Camila
        Barbosa Fierro Luis Esteban
        Cardona Acuña David Esteban
        González Casilimas Daniel Stevan
    
    SHIFT
        diurnal

    GROUP
        63102C / 239-2A */

namespace Ejercicio3
{
    public class Punto3
    {
	    public static void Main(string[] args)
	    {
            string Longitud;
            int NumeroX;
            int NumeroY;
		
		    Console.WriteLine("Introduce un tamaño");
            Longitud = Console.ReadLine();
		    int[] num = new int[int.Parse(Longitud)];

            Console.WriteLine("");
            Console.WriteLine("Ingrese un numero inicial y final para el intervalo de los numeros aleatorios primos");
            Console.WriteLine("Ingrese el numero inicial");
            NumeroX = int.Parse(System.Console.ReadLine());
            Console.WriteLine("Ingrese el numero final");
            NumeroY = int.Parse(System.Console.ReadLine());

		    rellenarNumPrimosAleatorioArray(num, NumeroX, NumeroY);

		    mostrarArray(num);
		
		    int primoMayor = mayor(num);
		    Console.WriteLine("El primo más grande es el " + primoMayor);

            int PrimoMenor = menor(num);
            Console.WriteLine("El primo más pequeño es el " + PrimoMenor);
	    }

	    public static void rellenarNumPrimosAleatorioArray(int[] lista, int a, int b)
	    {
		    int i = 0;
		
		    while (i < lista.Length)
		    {
			    int num = ((int)Math.Floor(GlobalRandom.NextDouble * (a - b) + b));
			    if (esPrimo(num))
			    {
				    lista[i] = num;
				    i++;
			    }
		    }
	    }
	
        private static bool esPrimo(int num)
	    {
            if (num <= 1)
		    {
			    return false;
		    }

		    else
		    {		   
			    int prueba;
			    int contador = 0;
			
			    prueba = (int)Math.Sqrt(num);
			
			    for (;prueba > 1;prueba--)
			    {
				    if (num % prueba == 0)
				    {
					    contador += 1;
				    }
			    }
			    return contador < 1;
		    }
	    }

	    public static void mostrarArray(int[] lista)
	    {
		    for (int i = 0;i < lista.Length;i++)
		    {
			    Console.WriteLine("En la fila " + (i+1) + " esta el valor " + lista[i]);
		    }
	    }

	    public static int mayor(int[] lista)
	    {
		    int mayor = 0;
		    for (int i = 0;i < lista.Length;i++)
		    {
			    if (lista[i] > mayor)
			    {
				    mayor = lista[i];
			    }
		    }
		    return mayor;
	    }

        public static int menor(int[] lista)
	    {
		    int menor = 0;
		    for (int n = 0; n < lista.Length;n++)
		    {
			    if (lista[n] < menor )
			    {
				    menor = lista[n];
			    }
		    }
		    return menor;
	    }
    }

    internal static class GlobalRandom
    {
	    private static System.Random randomInstance = null;

	    public static double NextDouble
	    {
		    get
		    {
			    if (randomInstance == null)
				    randomInstance = new System.Random();

			    return randomInstance.NextDouble();
		    }
	    }
    }
}
