using System;
using System.Collections;
using System.Collections.Generic;

//Desarrolle un programa donde muestre todas los metodos de las cadenas. 

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

namespace MENU_FUNCIONES_CADENA
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            string Cadena;
            string Cadena2;

            do
            {
                Console.WriteLine("");
                Console.WriteLine("01- Length");           //Calcular longitud de la cadena
                Console.WriteLine("02- SubString");        //Mostrar del segundo hasta el sexto letra de la cadena
                Console.WriteLine("03- IndexOf");          //Mostrar la primera letra pedida
                Console.WriteLine("04- ToUpper");          //Convertir cadena en mayuscula
                Console.WriteLine("05- ToLower");          //Convertir cadena en minuscula
                Console.WriteLine("06- Replace");          //Borrar espacios en blanco
                Console.WriteLine("07- Concat");           //Mostra fecha y hora personalizada
                Console.WriteLine("08- Compare");          //Compara dos cadenas
                Console.WriteLine("09- Equals");           //Permite comparar de otra forma
                Console.WriteLine("10- Contains");        //Buscar una letra en la cadena
                Console.WriteLine("11- EndsWith");        //Determinar si una letra se encunetra al final de la cadena
                Console.WriteLine("12- Insert");          //Insertar una cadena a otra, en la posicion deseada
                Console.WriteLine("13- PadLeft");         //devuelve una nueva cadena que alinea a la derecha
                Console.WriteLine("14- PadRight");        //devuelve una nueva cadena que alinea a la izquierda
                Console.WriteLine("15- Remove");          //Eliminar un caracter de una cadena
                Console.WriteLine("16- Replace");         //Remplaza un caracter dentro de una cadena por uno nuevo
                Console.WriteLine("17- Split");           //Remplaza un caracter dentro de una cadena por uno nuevo, pero de otra forma
                Console.WriteLine("18- Trim");            //Rectifica datos ingresado y los concatena
                Console.WriteLine("19- TrimEnd");         //recorta los espacios en blanco o los signos de puntuación del final de una cadena
                Console.WriteLine("20- TrimStart");       //recorta los espacios en blanco o los signos de puntuación del principio de una cadena
                Console.WriteLine("21- Append");          //Agrega la representación de cadena de un objeto especificado a esta instancia
                Console.WriteLine("22- Format");          //Reemplaza el valor de un dato (entero, real, una cadena, un carácter, hasta de un objeto)
                Console.WriteLine("23- Capacity");        //Calcular la capacidad de una lista
                Console.WriteLine("24- DateTime");        //Cadena para una fecha y hora
                Console.WriteLine("25- Salir");

                Console.Write("Dime una opcion del menú: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese una cadena por favor");
                        Cadena = Console.ReadLine();

                        Console.WriteLine("");
                        Console.WriteLine($"La longitud de la cadena es: {Convert.ToString(Cadena.Length)}");
                        Console.WriteLine("");
                    break;

                    case 2:
                        Console.WriteLine("Ingrese una cadena por favor");
                        Cadena = Console.ReadLine();

                        Console.WriteLine("");
                        Console.WriteLine($"Estos son los valores desde el segundo valor hasta el sexto: {Cadena.Substring(2, 6)}");
                        Console.WriteLine("");
                    break;

                    case 3:
                        Console.WriteLine("Ingrese una cadena por favor");
                        Cadena = Console.ReadLine();

                        Console.WriteLine("");
                        Console.WriteLine($"La posicición de la primera letra a es: {Convert.ToString(Cadena.IndexOf("a", 0)+1)}");
                        Console.WriteLine("");
                    break;

                    case 4:
                        Console.WriteLine("Ingrese una cadena por favor");
                        Cadena = Console.ReadLine();

                        Console.WriteLine("");
                        Console.WriteLine($"Ahora la cadena está en mayuscula: {Cadena.ToUpper()}");
                        Console.WriteLine("");
                    break;

                    case 5:
                        Console.WriteLine("Ingrese una cadena por favor");
                        Cadena = Console.ReadLine();

                        Console.WriteLine("");
                        Console.WriteLine($"Ahora la cadena está en minuscula: {Cadena.ToLower()}");
                        Console.WriteLine("");
                    break;

                    case 6:
                        Console.WriteLine("Ingrese una cadena por favor");
                        Cadena = Console.ReadLine();

                        Console.WriteLine("");
                        Console.WriteLine($"Ahora la cadena se ve así sin los espacios en blanco: {Cadena.Replace(" ","")}");
                        Console.WriteLine("");
                    break;

                    case 7:
                        string[] Palabras = { "Gato", "Perro", "Leon", "Tigre", "Puma", "Chita", "Rinoceronte." };

                        Console.WriteLine("");
                        string PrimeraFrase = string.Concat(Palabras);
                        Console.WriteLine(PrimeraFrase);

                        Console.WriteLine("");
                        string SegundaFrase = string.Join(", ", Palabras);
                        Console.WriteLine(SegundaFrase);
                    break;

                    case 8:
                        Console.WriteLine("");
                        Console.WriteLine("Ingrese una cadena por favor");
                        Cadena = Console.ReadLine();

                        Console.WriteLine("");
                        Console.WriteLine("Ingrese una segunda cadena por favor");
                        Cadena2 = Console.ReadLine();

                        Console.WriteLine("");
                        Console.WriteLine($"Resultado de comparar {Cadena} con {Cadena2}");
                        int Resultado = Cadena.CompareTo(Cadena2);
                        
                        if (Resultado == 0)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Las cadenas son iguales");
                        }

                        else if (Resultado < 0)
                        {
                            Console.WriteLine("");
                            Console.WriteLine($"{Cadena} es lexicográficamente menor que {Cadena2}");
                        }
            
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine($"{Cadena} es lexicográficamente mayor que {Cadena2}");
                        }
                    break;

                    case 9:
                        Console.WriteLine("");
                        Console.WriteLine("Ingrese una cadena");
                        Cadena = Console.ReadLine();

                        Console.WriteLine("");
                        Console.WriteLine("Ingrese una segunda cadena");
                        Cadena2 = Console.ReadLine();

                        bool Compara = Cadena.Equals(Cadena2);

                        if (Compara == false)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Ambas palabras son diferentes");
                        }

                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Ambas palabras son iguales");
                        }
                    break;

                    case 10:
                        Console.WriteLine("");
                        Console.WriteLine("Ingrese una cadena por favor");
                        Cadena = Console.ReadLine();

                        Console.WriteLine("");
                        Console.WriteLine($"La cadena contiene la letra m minúscula?: {Cadena.Contains("m")}");
                    break;

                    case 11:
                        Console.WriteLine("");
                        Console.WriteLine("Ingrese una cadena por favor");
                        Cadena = Console.ReadLine();

                        if(Cadena.EndsWith("o"))
                        {
                            Console.WriteLine("");
			                Console.WriteLine("Termina con la letra o");
		                }
                        
                        else
                        {
                            Console.WriteLine("");
			                Console.WriteLine("No termina con o");
		                }
                    break;

                    case 12:
                        Console.WriteLine("");
                        Console.WriteLine("Ingrese una cadena");
                        Cadena = Console.ReadLine();

                        Console.WriteLine("");
                        Console.WriteLine("Ingrese una segunda cadena");
                        Cadena2 = Console.ReadLine();

                        Console.WriteLine("");
                        Console.WriteLine($"La Primera cadena: {Cadena}");

                        Console.WriteLine("");
                        Cadena2 = Cadena.Insert(3, " ");
                        Console.WriteLine($"La cadena se modifica: {Cadena2}");
                    break;

                    case 13:
                        Console.WriteLine("");
                        Console.WriteLine("Ingrese una cadena");
                        Cadena = Console.ReadLine();

                        Console.WriteLine("");
                        Console.WriteLine("Ingrese una segunda cadena");
                        Cadena2 = Console.ReadLine();

                        Cadena = Cadena2.PadLeft(5,'3');

                        Console.WriteLine("");
                        Console.WriteLine($"Esta es la cadena actual {Cadena}");
                    break;

                    case 14:
                        Console.WriteLine("");
                        Console.WriteLine("Ingrese una cadena");
                        Cadena = Console.ReadLine();

                        Console.WriteLine("");
                        Console.WriteLine("Ingrese una segunda cadena");
                        Cadena2 = Console.ReadLine();

                        Cadena = Cadena2.PadRight(3,'5');

                        Console.WriteLine("");
                        Console.WriteLine($"Esta es la cadena actual {Cadena}");
                    break;

                    case 15:
                        Console.WriteLine("");
                        Console.WriteLine("Ingrese nombre completo");
                        Cadena = Console.ReadLine();

                        Console.WriteLine("");
                        Console.WriteLine($"El nombre completo es  {Cadena}");

                        int Valor1 = Cadena.IndexOf(" ");
                        int Valor2 = Cadena.IndexOf(" ", Valor1 + 1);

                        if (Valor1 != Valor2 && Valor1 >= 0)
                        {
                            Cadena = Cadena.Remove(Valor1 + 1, Valor2 - Valor1);

                            Console.WriteLine("");
                            Console.WriteLine($"Después de eliminar el segundo nombre, nos quedamos con {Cadena}");
                        }
                    break;

                    case 16:
                        string CadenaNumerico = "1 2 3 4 5 6 7 8 9";

                        Console.WriteLine("");
                        Console.WriteLine($"Cadena Original: {CadenaNumerico}");

                        Console.WriteLine("");
                        Console.WriteLine("Cadena remplazada {0}", CadenaNumerico.Replace(' ', ','));
                    break;

                    case 17:
                        string Palabra = "Jugar en la noche. Jugar en la mañana.";
                        Console.WriteLine("");
                        string[] OtraPalabra = Palabra.Split(' ', '.');

                        foreach (var b in OtraPalabra)
                        {
                            Console.WriteLine("");
                            Console.WriteLine($"Subcadena: {b}");
                        }
                    break;

                    case 18:
                        Console.WriteLine("");
                        Console.WriteLine("Ingrese el primer nombre: ");
                        string Nombre1 = Console.ReadLine();
                        
                        Console.WriteLine("");
                        Console.WriteLine("Ingrese su segundo nombre o inicial: ");
                        string Nombre2 = Console.ReadLine();
      
                        Console.WriteLine("");
                        Console.Write("Ingrese ultimo nombre: ");
                        string Nombre3 = Console.ReadLine();

                        Console.WriteLine("");
                        Console.WriteLine($"Esto es {Nombre1}, {Nombre2}, y {Nombre3}.");
      
                        Console.WriteLine("");
                        string Nombres = ((Nombre1.Trim() + " " + Nombre2.Trim()).Trim() + " " + Nombre3.Trim()).Trim();
                        Console.WriteLine("Este es el resultado " + Nombres + ".");
                    break;

                    case 19:
                        Console.WriteLine("");
                        string Frase = "Tengo clases todos los dias, excepto el sabado y domingo.";
                        char[] Caracteres = {',', '.', ' '};
                        string[] UnaPalabra = Frase.Split();

                        foreach (string U in UnaPalabra)
                        {
                            Console.WriteLine(U.TrimEnd(Caracteres));
                        }
                    break;

                    case 20:
                        string Cadenas1 = "*****0000ABC000****";
 
                        char[] Eliminador = { '*', '0' };

                        string Cadenas2 = "  ABC";
                        string Cadenas3 = "  -HJH-";
                        string Cadenas4 = "  HolaMundo";

                        Console.WriteLine("Antes :");
                        Console.WriteLine(Cadenas1);
                        Console.WriteLine(Cadenas2);
                        Console.WriteLine(Cadenas3);
                        Console.WriteLine(Cadenas4);
 
                        Console.WriteLine("");
                        Console.WriteLine("Ahora :");
                        Console.WriteLine(Cadenas1.TrimStart(Eliminador));
                        Console.WriteLine(Cadenas2.TrimStart());
                        Console.WriteLine(Cadenas3.TrimStart('-'));
                        Console.WriteLine(Cadenas4.TrimStart(' ', 'H', 'a', 'M', 'd'));                   
                    break;

                    case 21:
                        int numero = 0;
                    
                        if (numero == 0)
                        {
                            Console.WriteLine("");
                            System.Text.StringBuilder CadenaAppend = new 
                            System.Text.StringBuilder("El rango de un entero sin signo de 16 bits: ");
                            CadenaAppend.Append(UInt16.MinValue).Append(" a ").Append(UInt16.MaxValue);
                            Console.WriteLine(CadenaAppend);
                        }

                    break;

                    case 22: 
                        Console.WriteLine("Especificadores de formato numérico estándar");

                        String s = String.Format(   "(C) Moneda:. . . . . . . . . {0:C}" +
                                                    "(D) Decimal :. . . . . . . . {1:D}" +
                                                    "(E) Científico:. . . . . . . {1:E}" +
                                                    "(F) Punto fijo:. . . . . . . {0:F}" +
                                                    "(G) General :. . . . . . . . {0:G}" +
                                                    "    (defecto) :. . . . . . . {0} (default = 'G')" +
                                                    "(N) Número:. . . . . . . . . {0:N}" +
                                                    "(P) Porcentaje:. . . . . . . {1:P}" +
                                                    "(R) Ida y vuelta : . . . . . {1:R}" +
                                                    "(X) Hexadecimal :. . . . . . {0:X}", - 1234, -1234.565F);
                        Console.WriteLine(s);
                    break;

                    case 23:
                        ArrayList Lista = new ArrayList();
                        int Salir = 0;

                        do 
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Ingrese los numeros de la lista y ingrese 0 para salir");

                            int NumLista = int.Parse(Console.ReadLine());

                            if (NumLista == 0)
                            {
                                Salir = 100;
                            }

                            else
                            {
                                Lista.Add(NumLista);
                            }
                        } while (Salir != 100);

                        Lista.Sort();
                        Console.WriteLine($"Capacidad: {Lista.Capacity}");

                        foreach (int n in Lista)
                        {
                            Console.WriteLine($" [{n}] ");
                        }
                    break;

                    case 24:
                        DateTime Dato1 = new DateTime(2021, 10, 30);
                        Console.WriteLine("Hoy es " + Dato1.ToString("MMMM dd, yyyy") + ".");

                        DateTimeOffset Dato2 = new DateTimeOffset(2021, 10, 30, 15, 24, 16, TimeSpan.Zero);
                        Console.WriteLine("La fecha y hora actual: {0:MM/dd/yy H:mm:ss zzz}", Dato2);
                    break;
                }
            } while (opcion != 25);
        }
    }
}