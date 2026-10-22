namespace Classes
{
    // ===================== Exercício 3 =====================
    // Classe Aluno com atributos públicos (ainda sem encapsulamento)
    public class Aluno
    {
        public string Nome;
        public int Idade;
        public string Turma;

        public void Exibir()
        {
            Console.WriteLine($"Aluno: {Nome} | Idade: {Idade} | Turma: {Turma}");
        }
    }

    // ===================== Exercício 4 =====================
    public class Livro
    {
        public string Titulo;
        public string Autor;
        public int QuantidadePaginas;

        public void Exibir()
        {
            Console.WriteLine($"Livro: {Titulo} | Autor: {Autor} | Páginas: {QuantidadePaginas}");
        }
    }

    // ===================== Exercício 6 =====================
    // Classe Produto com atributos privados, getters e setters
    public class Produto
    {
        private string nome;
        private double preco;

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public double GetPreco()
        {
            return preco;
        }

        public void SetPreco(double preco)
        {
            this.preco = preco;
        }
    }

    // ===================== Exercício 7 =====================
    // Classe Pessoa com validação no SetIdade()
    public class Pessoa
    {
        private int idade;

        public int GetIdade()
        {
            return idade;
        }

        public void SetIdade(int idade)
        {
            if (idade >= 0)
            {
                this.idade = idade;
            }
            else
            {
                Console.WriteLine($"Erro: a idade não pode ser negativa ({idade}).");
            }
        }
    }

    // ===================== Exercício 8 =====================
    // Aluno com construtor (nome diferente para não conflitar com a classe Aluno do Exercício 3)
    public class AlunoMatricula
    {
        private string nome;
        private string matricula;

        public AlunoMatricula(string nome, string matricula)
        {
            this.nome = nome;
            this.matricula = matricula;
        }

        public string GetNome()
        {
            return nome;
        }

        public string GetMatricula()
        {
            return matricula;
        }
    }

    // ===================== Exercício 9 =====================
    public class Veiculo
    {
        private string marca;
        private string modelo;
        private int ano;

        public Veiculo(string marca, string modelo, int ano)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.ano = ano;
        }

        public void Exibir()
        {
            Console.WriteLine($"Veículo: {marca} {modelo} | Ano: {ano}");
        }
    }

    // ===================== Exercício 10 =====================
    public class ContaBancaria
    {
        private string titular;
        private double saldo;

        public ContaBancaria(string titular)
        {
            this.titular = titular;
            this.saldo = 0.0; // saldo inicial R$ 0,00
        }

        public void Depositar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Erro: o valor do depósito deve ser positivo.");
                return;
            }
            saldo += valor;
            Console.WriteLine($"Depósito de R$ {valor:F2} realizado.");
        }

        public void Sacar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Erro: o valor do saque deve ser positivo.");
            }
            else if (valor > saldo)
            {
                Console.WriteLine($"Erro: saldo insuficiente para sacar R$ {valor:F2}.");
            }
            else
            {
                saldo -= valor;
                Console.WriteLine($"Saque de R$ {valor:F2} realizado.");
            }
        }

        public double ConsultarSaldo()
        {
            return saldo;
        }

        public string GetTitular()
        {
            return titular;
        }
    }
}