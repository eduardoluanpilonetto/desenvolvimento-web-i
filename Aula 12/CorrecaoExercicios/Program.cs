// ==========================================================
// Aula 12 – Estruturas de Repetição e Métodos (C#)
// Correção dos Exercícios
// ==========================================================
// Como usar: execute o programa (dotnet run) e escolha no menu
// o número do exercício que deseja testar.
// ==========================================================

using System;
using System.Collections.Generic; // necessário para usar List<T>

class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine();
            Console.WriteLine("===== AULA 12 - EXERCÍCIOS =====");
            Console.WriteLine("1  - for: números de 1 a 20");
            Console.WriteLine("2  - for: pares de 0 a 50");
            Console.WriteLine("3  - for: soma de 1 a 100");
            Console.WriteLine("4  - while: de 10 até 1");
            Console.WriteLine("5  - while: validação de senha");
            Console.WriteLine("6  - foreach: array de nomes");
            Console.WriteLine("7  - foreach: soma de uma lista");
            Console.WriteLine("8  - Método Mensagem()");
            Console.WriteLine("9  - Método Dobro(int numero)");
            Console.WriteLine("10 - Método Media(double nota1, double nota2)");
            Console.WriteLine("0  - Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();
            Console.WriteLine();

            switch (opcao)
            {
                case "1": Exercicio1(); break;
                case "2": Exercicio2(); break;
                case "3": Exercicio3(); break;
                case "4": Exercicio4(); break;
                case "5": Exercicio5(); break;
                case "6": Exercicio6(); break;
                case "7": Exercicio7(); break;
                case "8": Exercicio8(); break;
                case "9": Exercicio9(); break;
                case "10": Exercicio10(); break;
                case "0":
                    continuar = false;
                    Console.WriteLine("Programa encerrado.");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }

    // ----------------------------------------------------------
    // Exercício 1 – Exibir os números de 1 a 20 com for
    // ----------------------------------------------------------
    static void Exercicio1()
    {
        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine(i);
        }
    }

    // ----------------------------------------------------------
    // Exercício 2 – Exibir apenas os pares de 0 a 50 com for
    // ----------------------------------------------------------
    static void Exercicio2()
    {
        // Começando em 0 e somando 2 a cada volta, só passamos pelos pares
        for (int i = 0; i <= 50; i += 2)
        {
            Console.WriteLine(i);
        }

        // Alternativa: percorrer todos e testar com o operador %
        // for (int i = 0; i <= 50; i++)
        // {
        //     if (i % 2 == 0)
        //         Console.WriteLine(i);
        // }
    }

    // ----------------------------------------------------------
    // Exercício 3 – Somar os números de 1 até 100 com for
    // ----------------------------------------------------------
    static void Exercicio3()
    {
        int soma = 0;

        for (int i = 1; i <= 100; i++)
        {
            soma += i; // o mesmo que: soma = soma + i;
        }

        Console.WriteLine("Soma de 1 até 100: " + soma); // 5050
    }

    // ----------------------------------------------------------
    // Exercício 4 – Exibir de 10 até 1 com while
    // ----------------------------------------------------------
    static void Exercicio4()
    {
        int contador = 10;

        while (contador >= 1)
        {
            Console.WriteLine(contador);
            contador--; // diminui 1 a cada volta (sem isso o laço seria infinito)
        }
    }

    // ----------------------------------------------------------
    // Exercício 5 – Pedir a senha até o usuário digitar "1234"
    // ----------------------------------------------------------
    static void Exercicio5()
    {
        Console.Write("Digite a senha: ");
        string senha = Console.ReadLine();

        while (senha != "1234")
        {
            Console.WriteLine("Senha incorreta! Tente novamente.");
            Console.Write("Digite a senha: ");
            senha = Console.ReadLine();
        }

        Console.WriteLine("Acesso liberado!");
    }

    // ----------------------------------------------------------
    // Exercício 6 – Array com 5 nomes exibidos com foreach
    // ----------------------------------------------------------
    static void Exercicio6()
    {
        string[] nomes =
        {
            "Ana",
            "Carlos",
            "Maria",
            "João",
            "Beatriz"
        };

        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }
    }

    // ----------------------------------------------------------
    // Exercício 7 – Lista com 10 números e soma com foreach
    // ----------------------------------------------------------
    static void Exercicio7()
    {
        List<int> numeros = new List<int>()
        {
            5, 10, 15, 20, 25, 30, 35, 40, 45, 50
        };

        int soma = 0;

        foreach (int numero in numeros)
        {
            soma += numero;
        }

        Console.WriteLine("Soma dos elementos da lista: " + soma); // 275
    }

    // ----------------------------------------------------------
    // Exercício 8 – Método Mensagem() chamado a partir do menu
    // ----------------------------------------------------------
    static void Exercicio8()
    {
        Mensagem(); // chamada do método
    }

    public static void Mensagem()
    {
        Console.WriteLine("Olá, mundo!");
    }

    // ----------------------------------------------------------
    // Exercício 9 – Método Dobro(int numero) que exibe o dobro
    // ----------------------------------------------------------
    static void Exercicio9()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        Dobro(numero); // o valor digitado é enviado como parâmetro
    }

    public static void Dobro(int numero)
    {
        Console.WriteLine("O dobro de " + numero + " é " + (numero * 2));
    }

    // ----------------------------------------------------------
    // Exercício 10 – Método Media(double nota1, double nota2)
    // que RETORNA a média das duas notas
    // ----------------------------------------------------------
    static void Exercicio10()
    {
        Console.Write("Digite a nota 1: ");
        double nota1 = double.Parse(Console.ReadLine());

        Console.Write("Digite a nota 2: ");
        double nota2 = double.Parse(Console.ReadLine());

        double resultado = Media(nota1, nota2); // o retorno é guardado na variável

        Console.WriteLine("Média: " + resultado);
    }

    public static double Media(double nota1, double nota2)
    {
        return (nota1 + nota2) / 2;
    }
}