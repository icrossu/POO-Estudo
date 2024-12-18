    /*
    3 - Encapsulamento: Crie uma classe Pessoa com atributos privados como nome e idade. Crie métodos para acessar e modificar esses atributos
    (getNome, setNome, getIdade, setIdade).

    Fazer alternativa

    3 - Encapsulamento: Crie uma classe Carro com atributos privados como Modelo, Ano, Tipo. Crie métodos para acessar e modificar esses atributos
       (getNome, setNome, getIdade, setIdade).
    */

    using System;

    public class Pessoa
    {
        private string nome;
        private int idade;

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public int Idade
        {
            get
            {
                return idade;
            }
            set
            {
                idade = value;
            }
        }
        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa("Pablo", 30);

            Console.WriteLine("Nome da pessoa: ", pessoa.Nome);
            Console.WriteLine("Idade da pessoa: ", pessoa.Idade);
            
            pessoa.Nome = "Papita";
            pessoa.Idade = 30;

            Console.WriteLine("Novo nome: " + pessoa.Nome);
            Console.WriteLine("Nova idade: " + pessoa.Idade);
        }
    }

    /*
    3 - Encapsulamento: Crie uma classe Carro com atributos privados como Modelo, Ano, Tipo. Crie métodos para acessar e modificar esses atributos
       (getNome, setNome, getIdade, setIdade).
    */

    /*
   3 - Encapsulamento: Crie uma classe Carro com atributos privados como Modelo, Ano, Tipo. Crie métodos para acessar e modificar esses atributos
      (getNome, setNome, getIdade, setIdade).
   */
    using System;

    public class Carro
    {
        private string modelo;
        private string tipo;
        private int ano;

        public string Modelo
        {
            get
            {
                return modelo;
            }
            set
            {
                modelo = value;
            }
        }

        public string Tipo
        {
            get
            {
                return tipo;
            }
            set
            {
                tipo = value;
            }
        }

        public int Ano
        {
            get
            {
                return ano;
            }
            set
            {
                ano = value;
            }
        }

        public Carro(string modelo, string tipo, int ano)
        {
            this.modelo = modelo;
            this.tipo = tipo;
            this.ano = ano;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro("Volkswagen", "Sedan", 20);

            Console.WriteLine("Modelo do carro: " + carro.Modelo);
            Console.WriteLine("Tipo do carro: " + carro.Tipo);
            Console.WriteLine("Ano do carro: " + carro.Ano);
        }
    }
