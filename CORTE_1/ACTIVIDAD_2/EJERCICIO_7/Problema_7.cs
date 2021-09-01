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

namespace Punto7
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            string b;
            int Cont1 = 0;
            int Cont2 = 0;
            int Cont3 = 0;
            int Cont4 = 0;
            int Cont5 = 0;

            Console.WriteLine("Ingrese una frase");
            frase = Console.ReadLine();

            for (int i = 0; i < frase.Length; i++)
            {
                b = frase.Substring(i,1);

                if( (b == "a") | (b == "e") | (b == "i") | (b == "o") | (b  == "u") )
                {
                    Cont1++;
                }

                if( (b == "A") | (b == "E") | (b == "I") | (b == "O") | (b  == "U") )
                {
                    Cont2++;
                }

                if( (b == "b") | (b == "c") | (b == "d") | (b == "f") | (b  == "g") | (b == "h") | (b == "j") | (b == "k") | (b == "l") | (b == "m") | (b == "n") | (b == "ñ") | (b == "p") | (b == "q") | (b == "r") | (b == "s") | (b == "t") | (b == "v") | (b == "w") | (b == "x") | (b == "y") | (b == "z"))
                {
                    Cont3++;
                }

                if( (b == "B") | (b == "C") | (b == "D") | (b == "F") | (b  == "G") | (b == "H") | (b == "J") | (b == "K") | (b == "L") | (b == "M") | (b == "N") | (b == "Ñ") | (b == "P") | (b == "Q") | (b == "R") | (b == "S") | (b == "T") | (b == "V") | (b == "W") | (b == "X") | (b == "Y") | (b == "Z"))
                {
                    Cont4++;
                }

                if( (b == "0") | (b == "1") | (b == "2") | (b == "3") | (b  == "4") | (b == "5") | (b == "6") | (b == "7") | (b == "8") | (b == "9") )
                {
                    Cont5++;
                }
                
            }

            Console.WriteLine("");
            Console.WriteLine("La cantidad de vocales minúsculas en la frase ingresada es: {0}", Cont1);
            Console.WriteLine("La cantidad de vocales mayúsculas en la frase ingresada es: {0}", Cont2);
            Console.WriteLine("La cantidad de consonantes minúsculas en la frase ingresada es: {0}", Cont3);
            Console.WriteLine("La cantidad de consonantes mayúsculas en la frase ingresada es: {0}", Cont4);
            Console.WriteLine("La cantidad de números en la frase ingresada es: {0}", Cont5);

        }
    }
}