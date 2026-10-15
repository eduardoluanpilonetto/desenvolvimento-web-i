// ==========================================================
// Aula 11 – Fundamentos da Linguagem C#
// Correção dos Exercícios de Fixação + Desafio Extra
// ==========================================================
// Como usar: execute o programa (dotnet run) e escolha no menu
// o número do exercício que deseja testar.
// ==========================================================

using System;

class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine();
            Console.WriteLine("===== AULA 11 - EXERCÍCIOS =====");
            Console.WriteLine("1  - Variáveis (nome, idade, altura, cidade)");
            Console.WriteLine("2  - Operações com dois números");
            Console.WriteLine("3  - Média de três notas");
            Console.WriteLine("4  - Número maior que 100");
            Console.WriteLine("5  - Usuário logado (bool)");
            Console.WriteLine("6  - Maior ou menor de idade");
            Console.WriteLine("7  - Par ou ímpar");
            Console.WriteLine("8  - Nome do mês (switch)");
            Console.WriteLine("9  - Situação do aluno (duas notas)");
            Console.WriteLine("10 - Maior de três números");
            Console.WriteLine("11 - Desafio Extra");
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
                case "11": DesafioExtra(); break;
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
    // Exercício 1 – Declarar variáveis e exibir seus valores
    // ----------------------------------------------------------
    static void Exercicio1()
    {
        string nome = "Maria";
        int idade = 25;
        double altura = 1.68;
        string cidade = "São Paulo";

        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Altura: " + altura);
        Console.WriteLine("Cidade: " + cidade);
    }

    // ----------------------------------------------------------
    // Exercício 2 – Soma, subtração, multiplicação e divisão
    // ----------------------------------------------------------
    static void Exercicio2()
    {
        Console.Write("Digite o primeiro número inteiro: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número inteiro: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Soma: " + (a + b));
        Console.WriteLine("Subtração: " + (a - b));
        Console.WriteLine("Multiplicação: " + (a * b));

        // Não é possível dividir por zero
        if (b != 0)
        {
            // Divisão entre inteiros descarta a parte decimal (ex.: 7 / 2 = 3)
            Console.WriteLine("Divisão: " + (a / b));
        }
        else
        {
            Console.WriteLine("Divisão: não é possível dividir por zero.");
        }
    }

    // ----------------------------------------------------------
    // Exercício 3 – Média de três notas
    // ----------------------------------------------------------
    static void Exercicio3()
    {
        Console.Write("Digite a nota 1: ");
        double nota1 = double.Parse(Console.ReadLine());

        Console.Write("Digite a nota 2: ");
        double nota2 = double.Parse(Console.ReadLine());

        Console.Write("Digite a nota 3: ");
        double nota3 = double.Parse(Console.ReadLine());

        // Os parênteses garantem que a soma seja feita antes da divisão
        double media = (nota1 + nota2 + nota3) / 3;

        Console.WriteLine("Média do aluno: " + media.ToString("F2"));
    }

    // ----------------------------------------------------------
    // Exercício 4 – Verificar se o número é maior que 100
    // ----------------------------------------------------------
    static void Exercicio4()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero > 100)
        {
            Console.WriteLine("O número é maior que 100.");
        }
        else
        {
            Console.WriteLine("O número NÃO é maior que 100.");
        }
    }

    // ----------------------------------------------------------
    // Exercício 5 – Variável booleana (usuário logado)
    // ----------------------------------------------------------
    static void Exercicio5()
    {
        bool usuarioLogado = true;

        Console.WriteLine("Usuário logado: " + usuarioLogado);
    }

    // ----------------------------------------------------------
    // Exercício 6 – Maior ou menor de idade
    // ----------------------------------------------------------
    static void Exercicio6()
    {
        Console.Write("Digite a idade: ");
        int idade = int.Parse(Console.ReadLine());

        if (idade >= 18)
        {
            Console.WriteLine("Maior de idade.");
        }
        else
        {
            Console.WriteLine("Menor de idade.");
        }
    }

    // ----------------------------------------------------------
    // Exercício 7 – Par ou ímpar
    // ----------------------------------------------------------
    static void Exercicio7()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        // Se o resto da divisão por 2 for zero, o número é par
        if (numero % 2 == 0)
        {
            Console.WriteLine(numero + " é PAR.");
        }
        else
        {
            Console.WriteLine(numero + " é ÍMPAR.");
        }
    }

    // ----------------------------------------------------------
    // Exercício 8 – Nome do mês com switch
    // ----------------------------------------------------------
    static void Exercicio8()
    {
        Console.Write("Digite o número do mês (1 a 12): ");
        int mes = int.Parse(Console.ReadLine());

        switch (mes)
        {
            case 1: Console.WriteLine("Janeiro"); break;
            case 2: Console.WriteLine("Fevereiro"); break;
            case 3: Console.WriteLine("Março"); break;
            case 4: Console.WriteLine("Abril"); break;
            case 5: Console.WriteLine("Maio"); break;
            case 6: Console.WriteLine("Junho"); break;
            case 7: Console.WriteLine("Julho"); break;
            case 8: Console.WriteLine("Agosto"); break;
            case 9: Console.WriteLine("Setembro"); break;
            case 10: Console.WriteLine("Outubro"); break;
            case 11: Console.WriteLine("Novembro"); break;
            case 12: Console.WriteLine("Dezembro"); break;
            default: Console.WriteLine("Mês inválido!"); break;
        }
    }

    // ----------------------------------------------------------
    // Exercício 9 – Situação do aluno com duas notas
    // ----------------------------------------------------------
    static void Exercicio9()
    {
        Console.Write("Digite a nota 1: ");
        double nota1 = double.Parse(Console.ReadLine());

        Console.Write("Digite a nota 2: ");
        double nota2 = double.Parse(Console.ReadLine());

        double media = (nota1 + nota2) / 2;
        Console.WriteLine("Média: " + media.ToString("F2"));

        if (media >= 7)
        {
            Console.WriteLine("Aprovado");
        }
        else if (media >= 5) // aqui a média já é menor que 7
        {
            Console.WriteLine("Recuperação");
        }
        else
        {
            Console.WriteLine("Reprovado");
        }
    }

    // ----------------------------------------------------------
    // Exercício 10 – Maior entre três números
    // ----------------------------------------------------------
    static void Exercicio10()
    {
        Console.Write("Digite o primeiro número: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int n2 = int.Parse(Console.ReadLine());

        Console.Write("Digite o terceiro número: ");
        int n3 = int.Parse(Console.ReadLine());

        int maior;

        if (n1 >= n2 && n1 >= n3)
        {
            maior = n1;
        }
        else if (n2 >= n1 && n2 >= n3)
        {
            maior = n2;
        }
        else
        {
            maior = n3;
        }

        Console.WriteLine("O maior número é: " + maior);
    }

    // ----------------------------------------------------------
    // Desafio Extra – Nome, três notas, média e situação
    // ----------------------------------------------------------
    static void DesafioExtra()
    {
        Console.Write("Digite o nome do aluno: ");
        string nome = Console.ReadLine();

        Console.Write("Digite a nota 1: ");
        double nota1 = double.Parse(Console.ReadLine());

        Console.Write("Digite a nota 2: ");
        double nota2 = double.Parse(Console.ReadLine());

        Console.Write("Digite a nota 3: ");
        double nota3 = double.Parse(Console.ReadLine());

        // 1. Calcular a média
        double media = (nota1 + nota2 + nota3) / 3;

        // 2. Exibir o nome do aluno
        Console.WriteLine();
        Console.WriteLine("Aluno: " + nome);
        Console.WriteLine("Média: " + media.ToString("F2"));

        // 3. Informar a situação
        if (media >= 7)
        {
            Console.WriteLine("Situação: Aprovado");
        }
        else if (media >= 5)
        {
            Console.WriteLine("Situação: Recuperação");
        }
        else
        {
            Console.WriteLine("Situação: Reprovado");
        }
    }
}