//Frederico Guilherme Camilli Proença RA:200925

using System;
using System.Globalization;

namespace POO_ArrayVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração das variáveis soma e média.
            double sum = 0, average;
            //Inserção do usuário da variável que será utilizada para criação do vetor.
            Console.WriteLine("Insira a quantidade de pessoas para adquirir as alturas:");
            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];
            //Repetição do vetor de acordo com a quantidade inserida pelo usuário anteriormente.
            Console.WriteLine("Agora, insira a altura dos indivíduos:");
            for (int i = 0; i < n; i++)
            {
                //Inserção da altura dos indivíduos, de acordo com a quantidade n.
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            for (int i = 0; i < n; i++)
            {
                //Realização da soma das alturas a cada vez que o usuário inserir um valor.
                sum += vect[i];
            }
            //Cálculo da média das alturas.
            average = sum / n;
            //Exposição da média ao usuário.
            Console.WriteLine("A média das alturas inseridas é: {0}.", average.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
