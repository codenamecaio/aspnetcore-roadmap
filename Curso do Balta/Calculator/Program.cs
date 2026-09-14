using System;

namespace Calculator
{
    class Program
    {
        static void Main (string[] args)
        {
            
            Subtracao();
            
        }

        static void Soma ()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o segundo valor a ser somado: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            
            float Vtotal = v1 + v2;
            Console.WriteLine($"A soma dos valores é: {Vtotal}");
            //Console.WriteLine("A soma dos valores é: " + Vtotal);
            //Console.WriteLine("A soma dos valores é: " + (v1 + v2));
            //Console.WriteLine($"A soma dos valores é: {v1 + v2}");

            Console.ReadKey();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor a ser subtraído: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float Vtotal = v1 - v2;

            Console.WriteLine($"A subtração do primeiro valor com o segundo é: {Vtotal}");
            Console.ReadKey();
        }

    }
}