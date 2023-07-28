using POOEjercicio1Tema2.Entidades;

namespace POOEjercicio1Tema2.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Conus!");
            Console.WriteLine("ingrese el valor del radio ");
            int radio = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el valor de la altura ");
            int altura = int.Parse(Console.ReadLine());


            Cono c = new Cono(altura, radio);

            Console.WriteLine(c.MostrarDatos());
            Console.ReadLine();

        }
    }
}