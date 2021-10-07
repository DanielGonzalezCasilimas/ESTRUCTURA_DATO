using System;
using System.Collections;
namespace Ejercicio_11
{
    /*
    GROUP MEMBERS
        Roa Ruiz Maria Camila
        Barbosa Fierro Luis Esteban
        Cardona Acuña David Esteban
        González Casilimas Daniel Stevan
    SHIFT
        diurnal
    GROUP
        63102C / 239-2A 
    */
    class Ejercicio_11
    {
        /*Escriba una rutina que reciba una Pila P de números flotantes y devuelva una Cola,manteniendo el orden de salida de los elementos.Es de destacar que la Pila P no debe sufrir ningún tipo de cambio o alteración.*/
        static void Main(string[] args)
        {
            ArrayList Pila = new ArrayList();
            Pila.Add(0.7f);
            Pila.Add(0.9f);
            Pila.Add(0.1f);
            Pila.Add(0.13f);
            Pila.Add(0.17f);
            Pila.Add(0.3f);
            imprimir(Pila);

            ArrayList Cola = new ArrayList();
            Cola.AddRange(Pila);
            imprimir(Cola);
            
        }
        
        static void imprimir(ArrayList nuevacola)
        {
            
            foreach (float P in nuevacola)
                Console.Write($" {P} |");
            Console.WriteLine("\n");
            
        }
        
    }
}
