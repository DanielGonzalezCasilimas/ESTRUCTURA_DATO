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
namespace AplicacionBase
{
/*Crea un array de números de un tamaño pasado por teclado, el array contendrá números aleatorios entre 1 y 300 y mostrar aquellos números que acaben en un dígito que nosotros le indiquemos por teclado (debes controlar que se introduce un numero correcto), estos deben guardarse en un nuevo array.
Por ejemplo, en un array de 10 posiciones e indicamos mostrar los números acabados en 5, podría salir 155, 25, etc*/

    class Ejercicio_6
    {
        static void Main(string[] args)
        {
            
            Random Aleatorio = new Random();
            int Comparacion;
            int Dimension = 1;
            int [] Resultado = new int [Dimension];
            int Longitud;
            

            Console.WriteLine("Ingrese por favor la longitud del arreglo");
            Longitud = int.Parse(Console.ReadLine());
            int [] Numeros = new int [Longitud];

            for(int i = 0; i < Longitud;i++)
            {
                Numeros[i] = Aleatorio.Next(1,300);
                Console.Write($"{Numeros[i]}  ");

            }
            
            Console.WriteLine("\nIngrese por favor el digito entre 0 y 9 del cuál desea mostrar los números del arreglo: ");
            Comparacion = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Se van a mostrar los números termiandos en: "+Comparacion);
            Console.WriteLine("Los números son: ");

           for (int j = 0; j < Longitud;j++)
            {
                if(Numeros[j]%10 == Comparacion)
                {
                    int indice = 0;
                    Resultado[indice] = Numeros[j];
                    Console.Write($"{Resultado[indice]} - ");
                    indice = indice + 1;
                    Dimension = Dimension + 1;
                }
            }
        

            Dimension = Dimension - 1;
            

        
        }
        
    }
}
