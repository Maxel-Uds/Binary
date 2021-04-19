using System;

namespace binary
{
    class Program
    {
    static void Main(string[] args)
        {
            int? startProgram = 3;
            while(startProgram == 3 && startProgram != 0)
            {
                try
                {
                    int? startOperation = null;
                    while(startOperation != 1 && startOperation != 2 && startOperation != 0)
                    {
                        Console.WriteLine("Escolha uma opção");
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("[1] De decimal para binário");
                        Console.WriteLine("[2] De binário para decimal");
                        Console.WriteLine("[0] Sair");
                        startOperation = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if(startOperation != 1 && startOperation != 2 && startOperation != 0)
                        {
                            Console.WriteLine($"{startOperation} não é uma opção válida!");
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }

                    switch(startOperation)
                    {
                        case 1:
                        Console.Write("Digite um número inteiro para transformar em binário: ");
                        int decimalNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine(decimalNumber.DecimalToBinary());
                        Console.ReadLine();
                        Console.Clear();
                        break;

                        case 2:
                        Console.Write("Digite o número binário com espaços entre os digitos: ");
                        string binaryNumber = Console.ReadLine();
                        Console.WriteLine(binaryNumber.BinaryToDecimal());
                        Console.ReadLine();
                        Console.Clear();
                        break;

                        default:
                        startProgram = 0;
                        break;
                    }
                    if(startOperation != 0)
                    {
                        startProgram = null; 
                        while(startProgram != 3 && startProgram != 0)
                        {
                            Console.Write("Para efetuar outra operação digite 3, para sair digite 0: ");
                            startProgram = int.Parse(Console.ReadLine());
                            Console.Clear();
                            if(startProgram != 3 && startProgram != 0)
                            {
                                Console.WriteLine($"{startProgram} não é uma escolha válida!");
                                Console.Clear();
                            }
                        }
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}
