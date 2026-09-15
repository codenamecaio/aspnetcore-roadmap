using System;

namespace Calculator
{
    class Program
    {
        static void Main (string[] args)
        {
            Menu(); 
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Oque Deseja fazer ?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("-------------------------");
            Console.WriteLine("Selecione uma opção: ");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Soma ()

        {
            Console.Clear();
            Console.WriteLine("---------------------------");
            Console.WriteLine("Digite o primeiro valor: ");

            float v1;
            while (!float.TryParse(Console.ReadLine(), out v1))
            {
                Console.WriteLine("Valor inválido.");
                Console.WriteLine("Digite novamente o primeiro valor: ");
            }

            Console.WriteLine("");
            Console.WriteLine("Digite o segundo valor a ser somado: ");

            float v2;
            while (!float.TryParse(Console.ReadLine(), out v2))
            {
                Console.WriteLine("Valor inválido.");
                Console.WriteLine("Digite um segundo valor para efetuar a operação");
            }

            Console.WriteLine("");

            float Vtotal = v1 + v2;
            Console.WriteLine($"A soma dos valores é: {Vtotal}");
            //Console.WriteLine("A soma dos valores é: " + Vtotal);
            //Console.WriteLine("A soma dos valores é: " + (v1 + v2));
            //Console.WriteLine($"A soma dos valores é: {v1 + v2}");

            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("---------------------------");
            Console.WriteLine("Digite o primeiro valor: ");

            float v1;
            while(!float.TryParse(Console.ReadLine(), out v1))
            {
                Console.WriteLine("Valor inválido.");
                Console.WriteLine("Por favor, Digite um número para fazer a operação: ");
            }
            //float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor a ser subtraído: ");

            float v2;
            while(!float.TryParse(Console.ReadLine(), out v2))
            {
                Console.WriteLine("Valor inválido.");
                Console.WriteLine("Por favor, digite um número para continuar a operação: ");
            }
            //float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float Vtotal = v1 - v2;
            Console.WriteLine($"A subtração do primeiro valor com o segundo é: {Vtotal}");
            //Console.WriteLine("A soma dos valores é: " + Vtotal);
            //Console.WriteLine("A soma dos valores é: " + (v1 - v2));
            //Console.WriteLine($"A soma dos valores é: {v1 - v2}");

            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("---------------------------");
            Console.WriteLine("Digite um primeiro valor: ");

          float v1;
          while(!float.TryParse(Console.ReadLine(), out v1))
            {
                Console.WriteLine("Valor inválido.: ");
                Console.WriteLine("Por favor, digite um número para fazer a opreção: ");
            }
            //float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Digite o valor que fará a divsão: ");

            float v2;
            while(!float.TryParse(Console.ReadLine(), out v2) || v2 == 0)
            {
                Console.WriteLine("Valor inválido.");
                Console.WriteLine("Por favor digite um número inteiro diferente de 0 para continuar a operação: ");
            }
            //float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

           float Vtotal = v1 / v2;

            Console.WriteLine($"O total dessa divisão foi: {Vtotal}");
            //Console.WriteLine("A soma dos valores é: " + Vtotal);
            //Console.WriteLine("A soma dos valores é: " + (v1 / v2));
            //Console.WriteLine($"A soma dos valores é: {v1 / v2}");

            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("---------------------------");
            Console.WriteLine("Digite o primeiro valor: ");

            float v1;
            while(!float.TryParse(Console.ReadLine(), out v1))
            {
                Console.WriteLine("Valor inválido.");
                Console.WriteLine("Por favor digite um número para começar a operação: ");
            }
            //float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Digite o segundo valor a ser multiplicado: ");

            float v2;
            while(!float.TryParse(Console.ReadLine(), out v2))
            {
                Console.WriteLine("Valor inválido.");
                Console.WriteLine("Por favor digite um número para continuar a operação");
            }
            //float v2 = float.Parse(Console.ReadLine());

            float Vtotal = v1 * v2;

            Console.WriteLine($"O resultado dessa multiplicação foi: {Vtotal}");
            //Console.WriteLine("A soma dos valores é: " + Vtotal);
            //Console.WriteLine("A soma dos valores é: " + (v1 * v2));
            //Console.WriteLine($"A soma dos valores é: {v1 * v2}");

            Console.ReadKey();
            Menu();
        }
    }
}