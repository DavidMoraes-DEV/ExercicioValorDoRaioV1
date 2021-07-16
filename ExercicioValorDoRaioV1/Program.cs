// MEMBROS ESTÁTICOS - Versão 1: Métodos na própria classe do programa:

using System;
using System.Globalization;

namespace ExercicioValorDoRaio
{
    class Program
    {
        static double PI = 3.14;

        static void Main(string[] args)
        {
            

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("\nCircunferência: " + Circunferencia(raio).ToString("F2", CultureInfo.InvariantCulture));
            Console.Write("\nVolume: " + Volume(raio).ToString("F2", CultureInfo.InvariantCulture));
            Console.Write("\nValor de PI: " + PI.ToString("F2", CultureInfo.InvariantCulture));
        }

        static double Circunferencia(double r)
        {
            return 2 * PI * r;
        }

        static double Volume(double r)
        {
            return 4 * PI * Math.Pow(r, 3) / 3;
        }
    }
}
/*
 Fazer um programa para ler um valor numérico qualquer, e daí mostrar quanto seria o valor de uma
circuferência e do volume de uma esfera para um raio daquele valor. Informar também o valor de PI
com duas casas decimais.

Exemplo:

Digite o valor do raio: 3.0
Cirfunferência: 18.84
Volume: 113.04
Valor de PI: 3.14
 */