﻿using System;

namespace binary
{
    class Program
    {
            static void Main(string[] args)
            {
            try
            {
                int? n = null;
                while(n != 1 && n != 2 && n != 0)
                {
                    Console.WriteLine("Escolha uma opção");
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("[1] De decimal para binário");
                    Console.WriteLine("[2] De binário para decimal");
                    Console.WriteLine("[0] Sair");
                    n = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if(n != 1 && n != 2 && n != 0)
                    {
                        Console.WriteLine($"{n} não é uma opção válida!");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }

                switch(n)
                {
                    case 1:
                    Console.Write("Digite um número inteiro para transformar em binário: ");
                    int decimalNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine(decimalNumber.DecimalToBinary());
                    Console.ReadLine();
                    break;

                    case 2:
                    Console.Write("Digite o número binário com espaços entre os digitos: ");
                    string binaryNumber = Console.ReadLine();
                    Console.WriteLine(binaryNumber.BinaryToDecimal());
                    Console.ReadLine();
                    break;

                    default:
                    break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }
}
