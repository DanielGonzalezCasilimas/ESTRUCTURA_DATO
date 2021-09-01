using System;
/*GROUP MEMBERS

 Roa Ruiz Maria Camila
 Barbosa Fierro Luis Esteban
 Cardona Acuña David Esteban
 González Casilimas Daniel Stevan

 SHIFT
 diurnal

 GROUP
 63102C / 239-2A */
namespace Problema_8
{
    class Problema_8
    {
        /*Dada  una  variable “c”que  contiene  un  carácter,  
        escribe  las  expresiones  que representen las siguientes 
        afirmaciones: a) c es una vocal. b) c es una letra minúscula. c) c es un símbolo del alfabeto.
        */
        static void Main(string[] args)
        {
            mostrarMedicion ('A');//Salida: Es una vocal: A
            mostrarMedicion('b');//Salida: Es una letra minúscula
            mostrarMedicion('.');//Salida: Símbolo del alfabeto

            void mostrarMedicion(char c)
            {
                if((c=='A')|(c=='E')|(c=='I')|(c=='O')|(c=='U'))
                {
                    Console.WriteLine($"Es una vocal: {c}");
                }
                else if (char.IsLower(c))
                {
                    Console.WriteLine($"Es una letra minúscula: {c}" );
                }
                else
                {
                    Console.WriteLine($"Es un símbolo del alfabeto: {c}");
                }

            }
        }
    }
}
