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

namespace PUNTO_5
{
    class Punto_5
    {
        static void Main(string[] args)
        {
            int Num1;
            int Num2;
            int Num3;
            int Num4;
            int opcion;

            Console.WriteLine("");
            Console.WriteLine("Ingrese 4 digitos por favor");
            Console.WriteLine("RECUERDE! No se puede ingresar ningun numero repetido");

            Console.WriteLine("");
            Console.WriteLine("Digita el primer número");
            Num1 = int.Parse(System.Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Digita el segundo número");
            Num2 = int.Parse(System.Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Digita el tercer número");
            Num3 = int.Parse(System.Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Digita el cuarto número");
            Num4 = int.Parse(System.Console.ReadLine());

            if (Num1 == Num2 || Num1 == Num3 || Num1 == Num4 || Num2 == Num1 || Num2 == Num3 || Num2 == Num4 || Num3 == Num1 || Num3 == Num2 || Num3 == Num4 || Num4 == Num1 || Num4 == Num2 || Num4 == Num3)
            {
                Console.WriteLine("");
                Console.WriteLine("Lo lamento algun numero se repite");
            }

            else 
            {
                Console.WriteLine("");
                Console.WriteLine("MENU");
                Console.WriteLine("====");
                Console.WriteLine("1. ¿Qué número es mayor?");  
                Console.WriteLine("2. ¿Qué número es menor?"); 

                Console.WriteLine("");
                Console.WriteLine("Que opcion desea elegir: ");
                opcion = int.Parse(System.Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        if (Num1 > Num2)
                        {
                            if (Num1 > Num3)
                            {
                                if (Num1 > Num4)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("El numero mayor es: {0}", Num1);
                                }
                            }
                        }

                        if (Num2 > Num1)
                        {
                            if (Num2 > Num3)
                            {
                                if (Num2 > Num4)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("El numero mayor es: {0}", Num2);
                                }
                            }
                        }

                        if (Num3 > Num1)
                        {
                            if (Num3 > Num2)
                            {
                                if (Num3 > Num4)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("El numero mayor es: {0}", Num3);
                                }
                            }
                        }

                        if (Num4 > Num1)
                        {
                            if (Num4 > Num2)
                            {
                                if (Num4 > Num3)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("El numero mayor es: {0}", Num4);
                                }
                            }
                        }
                    break;

                    case 2:
                        if (Num1 < Num2)
                        {
                            if (Num1 < Num3)
                            {
                                if (Num1 < Num4)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("El numero menor es: {0}", Num1);
                                }
                            }
                        }

                        if (Num2 < Num1)
                        {
                            if (Num2 < Num3)
                            {
                                if (Num2 < Num4)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("El numero menor es: {0}", Num2);
                                }
                            }
                        }

                        if (Num3 < Num1)
                        {
                            if (Num3 < Num2)
                            {
                                if (Num3 < Num4)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("El numero menor es: {0}", Num3);
                                }
                            }
                        }

                        if (Num4 < Num1)
                        {
                            if (Num4 < Num2)
                            {
                                if (Num4 < Num3)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("El numero menor es: {0}", Num4);
                                }
                            }
                        }
                    break;
                } 
            }
        }
    }
}
