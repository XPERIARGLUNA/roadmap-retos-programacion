using System;
using System.Collections.Generic;

namespace _02_Funciones_y_alcance
{
    internal class Program
    {
        //Variable global (Campo de clase)
        static int contadorGlobal = 0; //Accesible para los  métodos de la clase

        static void Main(string[] args)
        {
            //FUNCIONES DEFINIDAS POR EL USUARIO

            void saludar()  //Definimos la función de tipo sin retorno ni parámetro
            {
                Console.WriteLine("Hola, C#!");
            }

            saludar(); //Aquí la llamamos

            //con retorno
            string PositivoONegativo(int numero)
            {
                if (numero >= 0)
                    return "Positivo";
                else
                    return "Negativo";
            }

            Console.WriteLine(PositivoONegativo(-4));

            //con parámetro
            void SaludarConNombre(string nombre)
            {
                Console.WriteLine($"Hola, {nombre}!");
            }

            SaludarConNombre("Jesús");

            //con varios parámetros y retorno
            static int SumarTresNumeros(int a, int b, int c)
            {
                return a + b + c; //suma los parámetros
            }

            int resultado = SumarTresNumeros(2, 17, 7); //Llamada a ala función
            Console.WriteLine("La suma de los tres números es : " + resultado);

            //con un argumento predeterminado
            static double CalcularAreaCirculo(double radio, double pi = 3.1416)
            {
                return pi * radio * radio; //Fórmula del área
            }

            double area1 = CalcularAreaCirculo(5); //usa el valor predeterminado de pi
            Console.WriteLine($"El área del circulo con radio 5 es : {area1}");


            double area2 = CalcularAreaCirculo(5, 3.14); //Cambiamos el valor de pi
            Console.WriteLine($"El área del circulo con radio 5 y pi de 3.14 es: {area2}");


            //con tupla de valores
            static (string saludo1, string saludo2) multiples_saludos()
            {
                string saludo1 = "Hola!";
                string saludo2 = "Bienvenido";
                return (saludo1, saludo2); //Devuelve los saludos en tupla
            }

            var saludos = multiples_saludos();
            Console.WriteLine(saludos.saludo1);
            Console.WriteLine(saludos.saludo2);


            //con número variable de argumentos
            static void variablesArgumentos(params string[] nombres) //Se usa "params"
            {
                foreach (string nombre in nombres)
                {
                    Console.WriteLine($"Hola, {nombre}");
                }
            }

            variablesArgumentos("Jesús", "Antonio", "Luna");
            variablesArgumentos("Ana");
            variablesArgumentos(); //sin argumentos

            //FUNCIONES DENTRO DE FUNCIONES (LOCALES)

            void FuncionLocal1()
            {
                Console.WriteLine("Función Interna");

                void FuncionLocal2()
                {
                    Console.WriteLine("Inception!");
                }
                FuncionLocal2();
            }
            FuncionLocal1();


            //FUNCIÓN CREADA POR EL LENGUAJE Ejemplo: en String
            string texto = "Hola";
            int longitud = texto.Length; //Calcula la longitud de la cadena
            Console.WriteLine($" Hola tiene de longitud: {longitud}");

            //Ejemplo en Math
            int valorAbsoluto = Math.Abs(-4); //Da el valor absoluto de un número 

            //Ejemplo en Console
            Console.WriteLine("Hola Mundo"); // Imprime un mensaje en salto de línea

            //Ejemplo en DateTime
            DateTime ahora = DateTime.Now; //Da la fecha de hoy y la hora exacta
            Console.WriteLine($"Hoy es : {ahora}");


            //VARIABLES LOCALES Y GLOBALES

            SumarNumeros(2, 4);
            SumarNumeros(10, 5);

            Console.WriteLine($"La función SumarNumeros fue llamada {contadorGlobal} veces");

            static void SumarNumeros(int a, int b)
            {
                int resultado = a + b; //Variable local
                contadorGlobal++; //Modificamos la variable global
                Console.WriteLine($"La suma de {a} + {b} es : {resultado}");
            }

            //Extra
            int ImprimirNumeros(string texto1, string texto2)
            {
                int conteoNumeros = 0;

                for (int i = 1; i <= 100;  i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine($"{texto1},{texto2}");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine(texto1);
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine(texto2);
                    }
                    else
                    {
                        Console.WriteLine(i);
                        conteoNumeros++;
                    }
                }
                return conteoNumeros;
            }

            Console.WriteLine(ImprimirNumeros( "Múltiplo de 3" , "Múltiplo de 5" ));
        }
    }
}
