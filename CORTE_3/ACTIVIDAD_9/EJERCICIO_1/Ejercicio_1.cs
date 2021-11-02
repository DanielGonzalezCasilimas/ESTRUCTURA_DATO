using System;

namespace Ejercicio_1
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

    class Empleado
    {   /*Confeccionar una clase que represente un empleado. 
        Definir como atributos su nombre y su sueldo. 
        En el constructor cargar los atributos y luego en otro método imprimir sus datos 
        y por último uno que imprima un mensaje si debe pagar impuestos (si el sueldo supera a 3000)*/
        int sueldo;
        string nombre;
        public Empleado()
        {
            Console.WriteLine("Digite su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Digite su sueldo: ");
            sueldo = int.Parse(Console.ReadLine());

        }

        public void Imprimir()
        {
            Console.WriteLine(nombre);
            Console.WriteLine(sueldo);
        }
        public void Impuesto()
        {
            if (sueldo > 3000)
            {
                Console.WriteLine("Su saldo supera los 3000, por lo tanto pagará impuesto.");
            }
        }

        static void Main(string[] args)
        {
            Empleado op = new Empleado();
            op.Imprimir();
            op.Impuesto();
        }
    }
}