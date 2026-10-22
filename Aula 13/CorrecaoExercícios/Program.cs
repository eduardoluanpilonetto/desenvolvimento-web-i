/*
 * Programa principal: cria as instâncias das classes do arquivo Classes.cs
 */
using System;
using System.Text;
using Classes;

public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8; // para exibir acentos corretamente

        // ===== Exercício 3 =====
        Console.WriteLine("=== Exercício 3: Aluno ===");
        Aluno aluno1 = new Aluno();
        aluno1.Nome = "João";
        aluno1.Idade = 15;
        aluno1.Turma = "1º A";

        Aluno aluno2 = new Aluno();
        aluno2.Nome = "Maria";
        aluno2.Idade = 16;
        aluno2.Turma = "2º B";

        aluno1.Exibir();
        aluno2.Exibir();

        // ===== Exercício 4 =====
        Console.WriteLine("\n=== Exercício 4: Livro ===");
        Livro livro1 = new Livro();
        livro1.Titulo = "Dom Casmurro";
        livro1.Autor = "Machado de Assis";
        livro1.QuantidadePaginas = 256;

        Livro livro2 = new Livro();
        livro2.Titulo = "O Cortiço";
        livro2.Autor = "Aluísio Azevedo";
        livro2.QuantidadePaginas = 304;

        Livro livro3 = new Livro();
        livro3.Titulo = "Vidas Secas";
        livro3.Autor = "Graciliano Ramos";
        livro3.QuantidadePaginas = 176;

        livro1.Exibir();
        livro2.Exibir();
        livro3.Exibir();

        // ===== Exercício 6 =====
        Console.WriteLine("\n=== Exercício 6: Produto ===");
        Produto produto = new Produto();
        produto.SetNome("Teclado");
        produto.SetPreco(149.90);
        Console.WriteLine($"Produto: {produto.GetNome()} | Preço: R$ {produto.GetPreco():F2}");

        produto.SetPreco(129.90); // alterando o preço via setter
        Console.WriteLine($"Novo preço: R$ {produto.GetPreco():F2}");

        // ===== Exercício 7 =====
        Console.WriteLine("\n=== Exercício 7: Pessoa ===");
        Pessoa pessoa = new Pessoa();
        pessoa.SetIdade(25);
        Console.WriteLine($"Idade: {pessoa.GetIdade()}");
        pessoa.SetIdade(-5); // deve exibir mensagem de erro
        Console.WriteLine($"Idade continua: {pessoa.GetIdade()}");

        // ===== Exercício 8 =====
        Console.WriteLine("\n=== Exercício 8: Aluno com construtor ===");
        AlunoMatricula a1 = new AlunoMatricula("Pedro", "2026001");
        Console.WriteLine($"Aluno: {a1.GetNome()} | Matrícula: {a1.GetMatricula()}");

        // ===== Exercício 9 =====
        Console.WriteLine("\n=== Exercício 9: Veículo ===");
        Veiculo v1 = new Veiculo("Volkswagen", "Gol", 2020);
        Veiculo v2 = new Veiculo("Honda", "Civic", 2023);
        v1.Exibir();
        v2.Exibir();

        // ===== Exercício 10 =====
        Console.WriteLine("\n=== Exercício 10: ContaBancaria ===");
        ContaBancaria conta = new ContaBancaria("Carlos"); // 1. Cria a conta
        conta.Depositar(500.00);                            // 2. Depósito
        conta.Sacar(200.00);                                // 3. Saque
        conta.Sacar(1000.00);                               // tentativa inválida (saldo insuficiente)
        Console.WriteLine($"Saldo final de {conta.GetTitular()}: R$ {conta.ConsultarSaldo():F2}"); // 4. Saldo final
    }
}