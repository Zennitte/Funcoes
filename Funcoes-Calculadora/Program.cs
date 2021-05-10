using System;

namespace Funcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool resposta = false;

            do
            {

                Console.WriteLine("Qual operação matematica você gostaria de realizar: SM para somar, SB para subtrair, MP para multiplicar ou DV para dividir");
                string operacaoMatematica = Console.ReadLine().ToUpper();

                switch (operacaoMatematica)
                {
                    case "SM":
                        Console.Write("Digite o primeiro número: ");
                        double sm1 = double.Parse(Console.ReadLine());

                        Console.Write("Digite o segundo número: ");
                        double sm2 = double.Parse(Console.ReadLine());

                        Console.WriteLine($"O resultado da soma é: {Somar(sm1, sm2)}");
                        break;
                    case "SB":
                        Console.Write("Digite o primeiro número: ");
                        double sb1 = double.Parse(Console.ReadLine());

                        Console.Write("Digite o segundo número: ");
                        double sb2 = double.Parse(Console.ReadLine());

                        Console.WriteLine($"O resultado da subtração: {Subtrair(sb1, sb2)}");
                        break;
                    case "MP":
                        Console.Write("Digite o primeiro número: ");
                        double m1 = double.Parse(Console.ReadLine());

                        Console.Write("Digite o segundo número: ");
                        double m2 = double.Parse(Console.ReadLine());

                        Console.WriteLine($"O resultado da multiplicação: {Multiplicar(m1, m2)}");
                        break;
                    case "DV":
                        Console.Write("Digite o primeiro número: ");
                        double d1 = double.Parse(Console.ReadLine());

                        Console.Write("Digite o segundo número: ");
                        double d2 = double.Parse(Console.ReadLine());

                        Console.WriteLine($"O resultado da divisão: {Dividir(d1, d2)}");
                        break;
                    default:
                        Console.WriteLine("Digite uma opção válida");
                        break;
                }

                Console.WriteLine("Deseja realizar outra operação? S para sim ou N para não");
                string novaConsulta = Console.ReadLine().ToUpper();

                if (novaConsulta == "N")
                {
                    Console.WriteLine("Adeus");
                    resposta = true;
                }
                if(novaConsulta == "S")
                {
                    Console.WriteLine("Tudo bem, realizaremos outra operação");
                }                
            } while (resposta == false);

        }
        static double Somar(double primeiroNumero, double segundoNumero)
        {
            return primeiroNumero + segundoNumero;
        }
        static double Subtrair(double primeiroNumero, double segundoNumero)
        {
            return primeiroNumero - segundoNumero;
        }
        static double Multiplicar(double primeiroNumero, double segundoNumero)
        {
            return primeiroNumero * segundoNumero;
        }
        static double Dividir(double primeiroNumero, double segundoNumero)
        {
            return primeiroNumero / segundoNumero;
        }
    }
}
