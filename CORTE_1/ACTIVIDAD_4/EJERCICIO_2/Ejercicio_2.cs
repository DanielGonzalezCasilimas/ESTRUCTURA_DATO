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

/*Crea un array de números donde le indicamos por teclado el tamaño del array, rellenaremos el array con números aleatorios entre 0 y 9, al final muestra por pantalla el valor de cada posición y la suma de todos los valores. Haz un método para rellenar el array (que tenga como parámetros los números entre los que tenga que generar), para mostrar el contenido y la suma del array y un método privado para generar número aleatorio.*/

{
    class Ejercicio_2
    {
        private int [] NumerosAleatorios;

        public void Rellenar (int x,int y)
        {
            int Longitud;
            Console.WriteLine("Ingrese la longitud del arreglo");
            Longitud = int.Parse(Console.ReadLine());
            NumerosAleatorios = new int [Longitud];
            int Suma=0;
            Random Aleatorio = new Random();
            for(int i = 0; i < Longitud;i++)
            {
                NumerosAleatorios[i] = Aleatorio.Next(x,y);
                Console.WriteLine($"La posición {i} tiene un valor de: {NumerosAleatorios[i]}");
                Suma = Suma + NumerosAleatorios[i];
            }
            Console.WriteLine($"\nLa suma total es: {Suma}");


        }
        private void Azar ()
        {
          int Seleccion=0;
          Random Selec = new Random();
          Seleccion = Selec.Next(0,NumerosAleatorios.Length);
          Console.WriteLine("El número aleatorio es: "+ NumerosAleatorios[Seleccion]);
        }
         static void Main(string[] args)
        {
            Ejercicio_2 Array = new Ejercicio_2();
            Array.Rellenar(0,9);
            Array.Azar();

        }


    }
}
