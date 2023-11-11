namespace vectores
{
    internal class Program
    {
        static void Main(String[] args)
        {

            
            Random ramdom = new Random();
            int dimensionArray, numeroUsuario;

            Console.WriteLine("Por favor, introduce el valor que determinará la longitud del vector.");
            dimensionArray = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Por favor, introduce el valor que deseas buscar dentro del vector.");
            numeroUsuario = Convert.ToInt32(Console.ReadLine());

            int[] nums = new int[dimensionArray];
           
            for (int i = 0; i < nums.Length; i++) {
                nums[i] = ramdom.Next(9,18);
                if (nums[i] == numeroUsuario)
                {
                    Console.WriteLine("********Ganaste********");
                    Console.WriteLine("El numero " +  nums[i] + " se encuentra en la pocision: " + i);
                    Console.WriteLine("************************");
                }
                else {
                    Console.WriteLine("El numero no existe");
                }
            }

         

           
        }
    }
}
