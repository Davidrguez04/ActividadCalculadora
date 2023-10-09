using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadCalculadora.Entidades
{
    /// <summary>
    /// iMPLEMENTACION DE LAS ACCIONES DEL MENU
    /// 091023 - David RA
    /// </summary>
    internal class MenuImplementacion: MenuInterfaz
    {
        public void mensajeBienvenida()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            string mensaje = "Bienvenido tu Calculadora";
            Console.WriteLine("\n\n\t\t\t\t" + mensaje);
        }

        public int mostrarMenu()
        {
            int opcion;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\t\t--------------------------------");
            Console.WriteLine("\t\t\t\t|\tMenú:            ");
            Console.WriteLine("\t\t\t\t|                     ");
            Console.WriteLine("\t\t\t\t|1.-Cerrar                     ");
            Console.WriteLine("\t\t\t\t|2.-Suma                     ");
            Console.WriteLine("\t\t\t\t|3.-Resta            ");
            Console.WriteLine("\t\t\t\t|4.-Multiplicación            ");
            Console.WriteLine("\t\t\t\t|5.-División            ");
            Console.Write("\n\tElija una opción: ");

            opcion = Console.ReadKey(true).KeyChar - ('0');

            return opcion;
        }
        
        public int hacerSuma()
        {
            int num1, num2;
            Console.Write("\nIndique el primer operando: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nIndique el segundo operando: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            int resultado = num1 + num2;
            Console.WriteLine("\nEl resultado de la operación es "+resultado);

            return resultado;
        }

        public int hacerResta()
        {
            int num1, num2;
            Console.Write("\nIndique el primer operando: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nIndique el segundo operando: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            int resultado = num1 - num2;
            Console.WriteLine("\nEl resultado de la operación es " + resultado);

            return resultado;
        }

        public int hacerMultipli()
        {
            int num1, num2;
            Console.Write("\nIndique el primer operando: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nIndique el segundo operando: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            int resultado = num1 * num2;
            Console.WriteLine("\nEl resultado de la operación es " + resultado);

            return resultado;
        }

        public int hacerDivis()
        {
            int num1, num2;
            Console.Write("\nIndique el primer operando: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nIndique el segundo operando: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            int resultado = num1 / num2;
            Console.WriteLine("\nEl resultado de la operación es " + resultado);

            return resultado;
        }
    }
}
