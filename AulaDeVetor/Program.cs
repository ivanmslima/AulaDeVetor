using System;
using System.Globalization;

namespace curso
{
    class Progam
    {
        static void Main(string[] args)
        {

            int N;
            double[] vet;

            Console.Write("Primeiro digite a quantidade de números que vai imprimir, em seguida o programa irá mostrar os números digitados: ");



            N = int.Parse(Console.ReadLine());
           vet = new double[N];

            for (int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
            }

            Console.ReadLine();
        }
    }
}