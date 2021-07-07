using System;

/**
 * @author Victor
 *
 * EJERCIO 2 de la TAREA 2 Dado el siguiente programa, modifícalo para utilizar
 * las variables que se indican. El tipo de dato elegido debe ser el de menos
 * bits posibles que puedan representar el valor. Justifica tu elección.
 * 
 */

namespace PROG02_Tarea
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Sexo: con dos valores posibles 'V' o 'M'  - char almacena un caracter, pesa 1bit.
            char[] sexo = { 'V', 'M' };

            // Día de la semana 
            String[] diasSemana = {"Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sábado", "Domingo" };

            // Si un empleado está casado o no. - boleano
            Boolean casado = false;

            String respuesta;
            Boolean flag = false;

            do { 
                Console.WriteLine("else empleado esta casado? (1 para Si; 2 para No)");
                int resp = Convert.ToInt32(Console.ReadLine());
                
                switch (resp)
                {
                    case 1:
                        casado = true;
                        flag = true;
                        break;
                    case 2:
                        casado = false;
                        flag = true;
                        break;
                    default:
                        Console.WriteLine("El valor introducido no es correcto");
                        flag = false;
                        break;
                }
            } while (flag == false) ;

            if (casado == true)
            {
                respuesta = "Si";
            } else
            {
                respuesta = "No";
            }

            Console.WriteLine("El empleado esta casado?\n {0}", respuesta);


            // Valor máximo no modificable: 999999. - constante: int
            const int valorMax = 999999;

            // Día del año. - short
            short diaAnio;

            // Milisegundos transcurridos desde el 01/01/1970 hasta nuestros días. - double
            double tiempo;

            // Almacenar el total de una factura - float
            float totalFra;

            // Población mundial del planeta tierra. - long
            long personas;



        }
    }
}
