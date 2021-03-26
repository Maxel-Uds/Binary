using System;
using binary.Entities;

namespace binary
{
    class Program
    {
            static void Main(string[] args)
            {
            try
            {
                Console.WriteLine("Escolha uma opção");
                Console.WriteLine("---------------------------");
                Console.WriteLine("[1] De decimal para binário");
                Console.WriteLine("[2] De binário para decimal");
                Console.WriteLine("[0] Sair");
                int n = int.Parse(Console.ReadLine());
                Binary binary;
                Console.Clear();

                switch(n)
                {
                    case 1:
                    Console.Write("Digite um número inteiro para transformar em binário: ");
                    int decimalNumber = int.Parse(Console.ReadLine());

                    binary = new Binary(decimalNumber);
                    Console.WriteLine(binary.DecimalToBinary());
                    break;

                    case 2:
                    Console.Write("Digite o número binário com espaços entre os digitos: ");
                    string binaryNumber = Console.ReadLine();

                    binary = new Binary(binaryNumber);
                    Console.WriteLine(binary.BinaryToDecimal());
                    break;

                    default:
                    break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
