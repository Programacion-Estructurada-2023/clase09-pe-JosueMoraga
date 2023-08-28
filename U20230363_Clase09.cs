using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //Ejercicio de la clase 09

            //Programa que verifica si la nota es buena, muy buena, excelente o deficiente

            Console.WriteLine("\n----- PROGRAMA PARA VERIFICAR SU CALIFICACION -----\n");

            Console.WriteLine("\nIngrese su calificacion: ");
            double nota = Convert.ToDouble(Console.ReadLine()); 

            
             //Si la calificacion es mayor o igual a 9.5

            if (nota >=9.5)

            {
                Console.WriteLine("\nSu calificacion es: " +nota+ "\nla calificacion obtenia es excelente");
            }
            
            //Si la nota es mayor o igual a 8.5

            else if (nota >=8.5)

            {
                Console.WriteLine("\nSu calificacion es: "+nota+ "\nLa calificacion obtenida es muy buena. ");
            }

             //Si la nota es mayor o igual a 7.0

            else if (nota >=7)
            {
                Console.WriteLine("\nSu calificacion es: " +nota+ "\nla calificacion obtenia es buena ");
            }

            //En los demás casos se debe mostrar un mensaje que diga que la calificacion es deficiente 

            else 
            {
                Console.WriteLine("\nSu calificacion es: " +nota+ "\nsu calificacion es deficiente ");
            }

            Console.ReadKey();
        }
    }
}