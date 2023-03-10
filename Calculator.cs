using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            double num1, num2;

            Console.WriteLine("Calculadora");

            while (true)
            {
                Console.WriteLine("Por favor ingresa una operacion:");
                Console.WriteLine("1. Adicion");
                Console.WriteLine("2. Sustraccion");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Potencia");
                Console.WriteLine("6. Raiz cuadrada");
                Console.WriteLine("0. Salir");

                opcion = int.Parse(Console.ReadLine());

                if (opcion == 0)
                {
                    Console.WriteLine("Adios!");
                    break;
                }

                Console.WriteLine("Ingrese el primer numero: ");
                num1 = double.Parse(Console.ReadLine());

                if (opcion != 6)
                {
                    Console.WriteLine("Ingrese el segundo numero:");
                    num2 = double.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                            break;
                        case 2:
                            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                            break;
                        case 3:
                            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                            break;
                        case 4:
                            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                            break;
                        case 5:
                            Console.WriteLine($"{num1} ^ {num2} = {Math.Pow(num1, num2)}");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine($"sqrt({num1}) = {Math.Sqrt(num1)}");
                }

            }
            
            //Adding a simple functionality to ask for and print n elements entered by the user stored 
            //in an array in descendent and ascendent order
            
            int n;
            int numeros;
            Console.Write("Ingrese una cantidad de numeros que desea almacenar: ");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Numero invalido. Por favor ingresa un numero entero: ");
            }

            int[] arreglo = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Ingrese los numeros{i}: ");
                
                while (!int.TryParse(Console.ReadLine(), out numeros))
                {
                    Console.Write($"Invalid input. Please enter an integer value for element {i}: ");
                }
                arreglo[i] = numeros;
            }
            Console.WriteLine("Elementos en orden ascendente: ");
            // loop to display the elements in ascending order
            for (int i = 0; i < n; i++)
            {
                Console.Write(arreglo[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Elementos en orden descendente: ");
            // loop to display the elements in descending order
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(arreglo[i] + " ");
            }
            Console.WriteLine();
            
            //Adding a simple TAX (INNS & IR) calculation 
            int salario;
            double inns = 0.06, ir = 0.15;
            double salarioTotal1 = 0, salarioTotal2 = 0;

            Console.WriteLine("Ingrese su salario mensual en cordobas: ");
            while (!int.TryParse(Console.ReadLine(), out salario))
            {
                Console.Write("Numero invalido. Por favor ingresa un numero entero: ");
            }

            if (salario > 8333.33)
            {
                salarioTotal1 = salario * inns;
            } else
            {
                Console.WriteLine("El INNS e IR no le deduce de su salario ya que es muy bajo");
            }

            if (salario > 8333.33)
            {
                salarioTotal2 = salario * ir;
            } else
            {
                Console.WriteLine("El INNS e IR no le deduce de su salario ya que es muy bajo");
            }

            Console.WriteLine($"La cantidad de INNS que se deducira de su salario es de: {salarioTotal1} " +
                $"y la cantidad que se deducira de IR es igual a: {salarioTotal2}");

            Console.ReadKey();
        } 
    }
}
