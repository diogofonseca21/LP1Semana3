using System;

namespace PercorreString
{
    class Program
    {
        static void Main(string[] args)
        {
            float pi = 3.14f;

            Console.WriteLine("Introduza a altura");
            float altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Introduza o raio");
            float raio = float.Parse(Console.ReadLine());

            float volume = pi * (raio*raio) * altura;
            float area = 2 * pi * raio* (raio + altura);

            Console.WriteLine(volume);
            Console.WriteLine(area);
        }
    }
}
