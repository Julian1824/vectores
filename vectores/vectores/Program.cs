using System;

namespace vectores
{
    public class Program
    {
        static void Main(String[] args)
        {
            int dimensionArray, numeroUsuario;
            bool repetir = true;
            String continuar;
            Random ramdom = new Random();



            while (repetir) {
                try
                {   
                Console.WriteLine("Por favor, introduce el valor que determinará la longitud del vector.");
                dimensionArray = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Por favor, introduce el valor que deseas buscar dentro del vector.");
                numeroUsuario = Convert.ToInt32(Console.ReadLine());

                    int[] nums = new int[dimensionArray];

                    BuscarNumero(nums, numeroUsuario, ramdom);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Has ingresado una letra en lugar de un número.");
                }
                
                Console.WriteLine("¿Presiona cualquier letra para continuar o n para cerrar?");
                continuar = Console.ReadLine().ToLower();

                if (continuar == "n") {
                    repetir = false;
                }
            }
        }
        private static void BuscarNumero(int[] dimensionArray, int numeroUsuario, Random n)
        {
            bool hallar = false;
            for (int i = 0; i < dimensionArray.Length; i++)
            {
                dimensionArray[i] = n.Next(1, 21);
                if (dimensionArray[i] == numeroUsuario)
                {
                    Console.WriteLine("********Ganaste********");
                    Console.WriteLine("El numero " + dimensionArray[i] + " se encuentra en la pocision: " + i);
                    Console.WriteLine("************************");
                    hallar = true;
                    break;
                }
            }
            if (!hallar)
            {
                Console.WriteLine("El numero no existe");
            }
        }
    }
}
