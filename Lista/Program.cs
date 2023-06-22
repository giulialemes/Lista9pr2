```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        int num;

        Console.WriteLine("Escolha um exercicio: ");

        Console.WriteLine("====MENU====");
        Console.WriteLine("1 exercicio ");
        Console.WriteLine("2 exercicio ");
        Console.WriteLine("3 exercicio ");
        Console.WriteLine("4 exercicio ");
        Console.WriteLine("5 exercicio ");
        Console.WriteLine("6 exercicio ");
        Console.WriteLine("7 exercicio ");
        Console.WriteLine("============");

        num = int.Parse(Console.ReadLine()); 


        case 1:
        Console.Write("Digite o tamanho do vetor: ");
        int tamanho = int.Parse(Console.ReadLine());

        int[] vetor = new int[tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            vetor[i] = (1, 101); 
        }
        Console.WriteLine("Vetor: ");
        for (int i = 0; i < tamanho; i++)
        {
            Console.WriteLine(vetor[i]);
        }
        double soma = 0;
        for (int i = 0; i < tamanho; i++)
        {
            soma += vetor[i];
        }
        double media = soma / tamanho;
        Console.WriteLine($"Média: {media}");

        Console.ReadKey();

        case 2: 
            
            int tamanhe, impar, par;


            Console.Write("Digite o tamanho do vetor: ");
            int tamanhe = int.Parse(Console.ReadLine());

            for (int i = 0; i < tamanho; i++)
            {
                vetor[i] = (1, 101); 

            Console.WriteLine("Vetor:");
            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine(vetor[i]);
            }

            
            int somaImpares = 0;
            for (int i = 0; i < tamanho; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    somaPares += vetor[i];
                }
                else
                {
                    somaImpares += vetor[i];
                }
            }

            Console.WriteLine($"Soma dos valores pares: {somaPares}");
            Console.WriteLine($"Soma dos valores ímpares: {somaImpares}");

            Console.ReadKey();

            case 3:

                int tamanhodovetor;

            Console.Write("Digite o tamanho do vetor: ");
            int tamanho = int.Parse(Console.ReadLine());

            int[] vetor = new int[tamanho];

          
            for (int i = 0; i < tamanho; i++)
            {
                vetor[i] = (1, 101); 
            }
            Console.WriteLine("Vetor (do início ao fim):");
            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine(vetor[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Vetor (do fim ao começo):");
            for (int i = tamanho - 1; i >= 0; i--)
            {
                Console.WriteLine(vetor[i]);
            }

            Console.ReadKey();

            case 4:

                 
            Console.Write("Digite o tamanho do vetor: ");
            int tamanho = int.Parse(Console.ReadLine());

            int[] vetor = new int[tamanho];

            
            for (int i = 0; i < tamanho; i++)
            {
                vetor[i] = (1, 101); //Intervalo de 1 a 100
            }
            Console.WriteLine("Vetor:");
            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine(vetor[i]);
            }
            double soma = 0;
            int numerosdivisiveisquant = 0;
            for (int i = 0; i < tamanho; i++)
            {
                if (vetor[i] % 3 == 0 && vetor[i] % 5 == 0)
                {
                    soma += vetor[i];
            int numerosdivisiveisquant = 0; ++;
                }
            
            int numerosdivisiveisquant = ( > 0)
            if 
            {
                double media = soma / ( > 0);
                Console.WriteLine($"Média dos números divisíveis por 3 e por 5: {media}");
            }
            else
            {
                Console.WriteLine("Não há números divisíveis por 3 e por 5.");
            }

            Console.ReadKey();
                break;
        }

    }
    }




    
}
