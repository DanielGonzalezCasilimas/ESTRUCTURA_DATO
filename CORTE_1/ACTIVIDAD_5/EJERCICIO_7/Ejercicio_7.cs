using System;

namespace Ejercicio_7
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
        63102C / 239-2A */
    class Ejercicio_7
    {
        /*Como en el ejercicio de la anterior guía realizar de forma de matriz: En un censo familiar se desea
        colocar subsidios a los servicios públicos, se debe crear un programa que ingresen el valor del Agua, 
        Luz y Gas de 3 familias, si es estrato 1 debe dar el 20% de descuento a cada servicio, si es estrato 2 el 15% 
        si es de estrato 3 o más debe dar el 9% de descuento, al final nos debe dar el total a pagar discriminado por servicio público.*/

        
        static void Main(string[] args)
        {
            double[,] Matriz = new double[3, 1];
            int LONGITUD_FILA = 3;
            int LONGITUD_COLUMNA = 1;
            int Estrato;
            int Estrato2;

            do
            {
                Console.WriteLine("FAMILIA 1: ");
                Console.WriteLine("Teniendo en cuenta...");
                Console.WriteLine("Digita un numero de estrato '1,2,3,4,5 o 6':");
                Estrato = int.Parse(Console.ReadLine());
                    
                if(Estrato > 6)
                {
                    Console.WriteLine("No se conoce un estrato mayor a 6 (seis). Intente de nuevo:");
                    Console.WriteLine("");
                }
                else if(Estrato < 0)
                {
                    Console.WriteLine("No se conoce un estrato menor a cero. Intente de nuevo:");
                    Console.WriteLine("");
                }
                else if(Estrato == 0)
                {
                    Console.WriteLine("No se conoce un estrato igual a cero. Intente de nuevo:");
                    Console.WriteLine("");
                } 

            }while(Estrato <= 0 || Estrato > 6);

            
            switch (Estrato)
            {
                //estrato 1 20%
                case 1:
                    for (int f = 0; f < LONGITUD_FILA; f++)
                    {
                        for (int c = 0; c < LONGITUD_COLUMNA; c++)
                        {
                            Console.Write($"Ingrese el valor de agua, Luz, Gas {f+1}, {c+1} : ");
                            Matriz[f,c] = int.Parse(Console.ReadLine());
                        }
                    }
                    for (int f = 0; f < LONGITUD_FILA; f++)
                    {
                        for (int c = 0; c < LONGITUD_COLUMNA; c++)
                        {
                            double descuento = Matriz[f, c] * 0.20;
                            Matriz[f, c] = Matriz[f, c] - descuento;
                        }
                    }
                break;

                //estrato 2 15%
                case 2:
                    for (int f = 0; f < LONGITUD_FILA; f++)
                    {
                        for (int c = 0; c < LONGITUD_COLUMNA; c++)
                        {
                            Console.Write($"Ingrese el valor de agua, Luz, Gas {f+1}, {c+1} : ");
                            Matriz[f,c] = int.Parse(Console.ReadLine());
                        }
                    }
                    for (int f = 0; f < LONGITUD_FILA; f++)
                    {
                        for (int c = 0; c < LONGITUD_COLUMNA; c++)
                        {
                            double descuento = Matriz[f, c] * 0.15;
                            Matriz[f, c] = Matriz[f, c] - descuento;
                        }
                    }
                break;

                //estrato 3 o mas 9%
                case 3:
                    for (int f = 0; f < LONGITUD_FILA; f++)
                    {
                        for (int c = 0; c < LONGITUD_COLUMNA; c++)
                        {
                            Console.Write($"Ingrese el valor de agua, Luz, Gas {f+1}, {c+1} : ");
                            Matriz[f,c] = int.Parse(Console.ReadLine());
                        }
                    }
                    for (int f = 0; f < LONGITUD_FILA; f++)
                    {
                        for (int c = 0; c < LONGITUD_COLUMNA; c++)
                        {
                            double descuento = Matriz[f, c] * 0.09;
                            Matriz[f, c] = Matriz[f, c] - descuento;
                        }
                    }
                break;

                case 4:
                    for (int f = 0; f < LONGITUD_FILA; f++)
                    {
                        for (int c = 0; c < LONGITUD_COLUMNA; c++)
                        {
                            Console.Write($"Ingrese el valor de agua, Luz, Gas {f+1}, {c+1} : ");
                            Matriz[f,c] = int.Parse(Console.ReadLine());
                        }
                    }
                    for (int f = 0; f < LONGITUD_FILA; f++)
                    {
                        for (int c = 0; c < LONGITUD_COLUMNA; c++)
                        {
                            double descuento = Matriz[f, c] * 0.09;
                            Matriz[f, c] = Matriz[f, c] - descuento;
                        }
                    }
                break;

                case 5:
                    for (int f = 0; f < LONGITUD_FILA; f++)
                    {
                        for (int c = 0; c < LONGITUD_COLUMNA; c++)
                        {
                            Console.Write($"Ingrese el valor de agua, Luz, Gas {f+1}, {c+1} : ");
                            Matriz[f,c] = int.Parse(Console.ReadLine());
                        }
                    }
                    for (int f = 0; f < LONGITUD_FILA; f++)
                    {
                        for (int c = 0; c < LONGITUD_COLUMNA; c++)
                        {
                            double descuento = Matriz[f, c] * 0.09;
                            Matriz[f, c] = Matriz[f, c] - descuento;
                        }
                    }
                break;

                case 6:
                    for (int f = 0; f < LONGITUD_FILA; f++)
                    {
                        for (int c = 0; c < LONGITUD_COLUMNA; c++)
                        {
                            Console.Write($"Ingrese el valor de agua, Luz, Gas {f+1}, {c+1} : ");
                            Matriz[f,c] = int.Parse(Console.ReadLine());
                        }
                    }
                    for (int f = 0; f < LONGITUD_FILA; f++)
                    {
                        for (int c = 0; c < LONGITUD_COLUMNA; c++)
                        {
                            double descuento = Matriz[f, c] * 0.09;
                            Matriz[f, c] = Matriz[f, c] - descuento;
                        }
                    }
                break;
            }

            Console.WriteLine("\nFAMILIA 1: ");
            Console.WriteLine("\nEl total de cada servicio en matriz es: ");
            for (int f = 0; f < LONGITUD_FILA; f++){
                for (int c = 0; c < LONGITUD_COLUMNA; c++){
                    Console.Write("  [" + Matriz[f, c] + "]  ");
                }
                Console.WriteLine();
            }
        //-------------------------------------------------------------------------------------------

            do
            {
                Console.WriteLine("FAMILIA 2: ");
                Console.WriteLine("Teniendo en cuenta...");
                Console.WriteLine("Digita un numero de estrato '1,2,3,4,5 o 6':");
                Estrato2 = int.Parse(Console.ReadLine());
                    
                if(Estrato2 > 6)
                {
                    Console.WriteLine("No se conoce un estrato mayor a 6 (seis). Intente de nuevo:");
                    Console.WriteLine("");
                }
                else if(Estrato2 < 0)
                {
                    Console.WriteLine("No se conoce un estrato menor a cero. Intente de nuevo:");
                    Console.WriteLine("");
                }
                else if(Estrato2 == 0)
                {
                    Console.WriteLine("No se conoce un estrato igual a cero. Intente de nuevo:");
                    Console.WriteLine("");
                } 

            }while(Estrato2 <= 0 || Estrato2 > 6);

            switch (Estrato2)
            {
                //estrato 1 20%
                case 1:
                    for (int i = 0; i < LONGITUD_FILA; i++)
                    {
                        for (int j = 0; j < LONGITUD_COLUMNA; j++)
                        {
                            Console.Write($"Ingrese el valor de agua, Luz, Gas {i+1}, {j+1} : ");
                            Matriz[i,j] = int.Parse(Console.ReadLine());
                        }
                    }
                    for (int i = 0; i < LONGITUD_FILA; i++)
                    {
                        for (int j = 0; j < LONGITUD_COLUMNA; j++)
                        {
                            double descuento = Matriz[i, j] * 0.20;
                            Matriz[i, j] = Matriz[i, j] - descuento;
                        }
                    }
                break;

                //estrato 2 15%
                case 2:
                    for (int i = 0; i < LONGITUD_FILA; i++)
                    {
                        for (int j = 0; j < LONGITUD_COLUMNA; j++)
                        {
                            Console.Write($"Ingrese el valor de agua, Luz, Gas {i+1}, {j+1} : ");
                            Matriz[i,j] = int.Parse(Console.ReadLine());
                        }
                    }
                    for (int i = 0; i < LONGITUD_FILA; i++)
                    {
                        for (int j = 0; j < LONGITUD_COLUMNA; j++)
                        {
                            double descuento = Matriz[i, j] * 0.15;
                            Matriz[i, j] = Matriz[i, j] - descuento;
                        }
                    }
                break;

                //estrato 3 o mas 9%
                case 3:
                    for (int i = 0; i < LONGITUD_FILA; i++)
                    {
                        for (int j = 0; j < LONGITUD_COLUMNA; j++)
                        {
                            Console.Write($"Ingrese el valor de agua, Luz, Gas {i+1}, {j+1} : ");
                            Matriz[i,j] = int.Parse(Console.ReadLine());
                        }
                    }
                    for (int i = 0; i < LONGITUD_FILA; i++)
                    {
                        for (int j = 0; j < LONGITUD_COLUMNA; j++)
                        {
                            double descuento = Matriz[i, j] * 0.09;
                            Matriz[i, j] = Matriz[i, j] - descuento;
                        }
                    }
                break;

                case 4:
                    for (int i = 0; i < LONGITUD_FILA; i++)
                    {
                        for (int j = 0; j < LONGITUD_COLUMNA; j++)
                        {
                            Console.Write($"Ingrese el valor de agua, Luz, Gas {i+1}, {j+1} : ");
                            Matriz[i,j] = int.Parse(Console.ReadLine());
                        }
                    }
                    for (int i = 0; i < LONGITUD_FILA; i++)
                    {
                        for (int j = 0; j < LONGITUD_COLUMNA; j++)
                        {
                            double descuento = Matriz[i, j] * 0.09;
                            Matriz[i, j] = Matriz[i, j] - descuento;
                        }
                    }
                break;

                case 5:
                    for (int i = 0; i < LONGITUD_FILA; i++)
                    {
                        for (int j = 0; j < LONGITUD_COLUMNA; j++)
                        {
                            Console.Write($"Ingrese el valor de agua, Luz, Gas {i+1}, {j+1} : ");
                            Matriz[i,j] = int.Parse(Console.ReadLine());
                        }
                    }
                    for (int i = 0; i < LONGITUD_FILA; i++)
                    {
                        for (int j = 0; j < LONGITUD_COLUMNA; j++)
                        {
                            double descuento = Matriz[i, j] * 0.09;
                            Matriz[i, j] = Matriz[i, j] - descuento;
                        }
                    }
                break;

                case 6:
                    for (int i = 0; i < LONGITUD_FILA; i++)
                    {
                        for (int j = 0; j < LONGITUD_COLUMNA; j++)
                        {
                            Console.Write($"Ingrese el valor de agua, Luz, Gas {i+1}, {j+1} : ");
                            Matriz[i,j] = int.Parse(Console.ReadLine());
                        }
                    }
                    for (int i = 0; i < LONGITUD_FILA; i++)
                    {
                        for (int j = 0; j < LONGITUD_COLUMNA; j++)
                        {
                            double descuento = Matriz[i, j] * 0.09;
                            Matriz[i, j] = Matriz[i, j] - descuento;
                        }
                    }
                break;
            }

            Console.WriteLine("\nFAMILIA 2: ");
            Console.WriteLine("\nEl total de cada servicio en matriz es: ");
            for (int i = 0; i < LONGITUD_FILA; i++){
                for (int j = 0; j < LONGITUD_COLUMNA;j++){
                    Console.Write("  [" + Matriz[i, j] + "]  ");
                }
                Console.WriteLine();
            }

        //--------------------------------------------------------------------------------------------------------------------------------------

        do
            {
                Console.WriteLine("FAMILIA 3: ");
                Console.WriteLine("Teniendo en cuenta...");
                Console.WriteLine("Digita un numero de estrato '1,2,3,4,5 o 6':");
                Estrato = int.Parse(Console.ReadLine());
                    
                if(Estrato > 6)
                {
                    Console.WriteLine("No se conoce un estrato mayor a 6 (seis). Intente de nuevo:");
                    Console.WriteLine("");
                }
                else if(Estrato < 0)
                {
                    Console.WriteLine("No se conoce un estrato menor a cero. Intente de nuevo:");
                    Console.WriteLine("");
                }
                else if(Estrato == 0)
                {
                    Console.WriteLine("No se conoce un estrato igual a cero. Intente de nuevo:");
                    Console.WriteLine("");
                } 

            }while(Estrato <= 0 || Estrato > 6);

            
            switch (Estrato)
            {
                //estrato 1 20%
                case 1:
                    for (int f = 0; f < LONGITUD_FILA; f++)
                    {
                        for (int c = 0; c < LONGITUD_COLUMNA; c++)
                        {
                            Console.Write($"Ingrese el valor de agua, Luz, Gas {f+1}, {c+1} : ");
                            Matriz[f,c] = int.Parse(Console.ReadLine());
                        }
                    }
                    for (int f = 0; f < LONGITUD_FILA; f++)
                    {
                        for (int c = 0; c < LONGITUD_COLUMNA; c++)
                        {
                            double descuento = Matriz[f, c] * 0.20;
                            Matriz[f, c] = Matriz[f, c] - descuento;
                        }
                    }
                break;

                //estrato 2 15%
                case 2:
                    for (int f = 0; f < LONGITUD_FILA; f++)
                    {
                        for (int c = 0; c < LONGITUD_COLUMNA; c++)
                        {
                            Console.Write($"Ingrese el valor de agua, Luz, Gas {f+1}, {c+1} : ");
                            Matriz[f,c] = int.Parse(Console.ReadLine());
                        }
                    }
                    for (int f = 0; f < LONGITUD_FILA; f++)
                    {
                        for (int c = 0; c < LONGITUD_COLUMNA; c++)
                        {
                            double descuento = Matriz[f, c] * 0.15;
                            Matriz[f, c] = Matriz[f, c] - descuento;
                        }
                    }
                break;

                //estrato 3 o mas 9%
                case 3:
                    for (int f = 0; f < LONGITUD_FILA; f++)
                    {
                        for (int c = 0; c < LONGITUD_COLUMNA; c++)
                        {
                            Console.Write($"Ingrese el valor de agua, Luz, Gas {f+1}, {c+1} : ");
                            Matriz[f,c] = int.Parse(Console.ReadLine());
                        }
                    }
                    for (int f = 0; f < LONGITUD_FILA; f++)
                    {
                        for (int c = 0; c < LONGITUD_COLUMNA; c++)
                        {
                            double descuento = Matriz[f, c] * 0.09;
                            Matriz[f, c] = Matriz[f, c] - descuento;
                        }
                    }
                break;

                case 4:
                    for (int f = 0; f < LONGITUD_FILA; f++)
                    {
                        for (int c = 0; c < LONGITUD_COLUMNA; c++)
                        {
                            Console.Write($"Ingrese el valor de agua, Luz, Gas {f+1}, {c+1} : ");
                            Matriz[f,c] = int.Parse(Console.ReadLine());
                        }
                    }
                    for (int f = 0; f < LONGITUD_FILA; f++)
                    {
                        for (int c = 0; c < LONGITUD_COLUMNA; c++)
                        {
                            double descuento = Matriz[f, c] * 0.09;
                            Matriz[f, c] = Matriz[f, c] - descuento;
                        }
                    }
                break;

                case 5:
                    for (int f = 0; f < LONGITUD_FILA; f++)
                    {
                        for (int c = 0; c < LONGITUD_COLUMNA; c++)
                        {
                            Console.Write($"Ingrese el valor de agua, Luz, Gas {f+1}, {c+1} : ");
                            Matriz[f,c] = int.Parse(Console.ReadLine());
                        }
                    }
                    for (int f = 0; f < LONGITUD_FILA; f++)
                    {
                        for (int c = 0; c < LONGITUD_COLUMNA; c++)
                        {
                            double descuento = Matriz[f, c] * 0.09;
                            Matriz[f, c] = Matriz[f, c] - descuento;
                        }
                    }
                break;

                case 6:
                    for (int f = 0; f < LONGITUD_FILA; f++)
                    {
                        for (int c = 0; c < LONGITUD_COLUMNA; c++)
                        {
                            Console.Write($"Ingrese el valor de agua, Luz, Gas {f+1}, {c+1} : ");
                            Matriz[f,c] = int.Parse(Console.ReadLine());
                        }
                    }
                    for (int f = 0; f < LONGITUD_FILA; f++)
                    {
                        for (int c = 0; c < LONGITUD_COLUMNA; c++)
                        {
                            double descuento = Matriz[f, c] * 0.09;
                            Matriz[f, c] = Matriz[f, c] - descuento;
                        }
                    }
                break;
            }

            Console.WriteLine("\nFAMILIA 3: ");
            Console.WriteLine("\nEl total de cada servicio en matriz es: ");
            for (int f = 0; f < LONGITUD_FILA; f++){
                for (int c = 0; c < LONGITUD_COLUMNA; c++){
                    Console.Write("  [" + Matriz[f, c] + "]  ");
                }
                Console.WriteLine();
            }
        //-------------------------------------------------------------------------------------------

        }
    }
}
