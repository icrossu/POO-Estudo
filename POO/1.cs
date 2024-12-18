/*
1 - Criação de Classes Simples: Crie uma classe Carro com atributos como modelo, cor e ano. A classe deve ter um
método ligar que imprime uma mensagem indicando que o carro está ligado.

Fazer uma alternativa

1 - Criação de Classes Simples: Crie uma classe Animal com atributos como raça, cor e idade. A classe deve ter um
   método morder que imprime uma mensagem indicando que o animal está mordendo.
 */

using System;

class Program {
    class Carro {
        public string Modelo;
        public string Cor;
        public int Ano;

        public void Ligar() {
            Console.WriteLine("Carro está ligado.");
        }
    }

    static void Main(string[] args) {
        Carro meuCarro = new Carro();
        meuCarro.Modelo = "Fusca";
        meuCarro.Cor = "Azul";
        meuCarro.Ano = 1975;

        meuCarro.Ligar();

        Console.WriteLine($"Modelo: {meuCarro.Modelo}");
        Console.WriteLine($"Cor: {meuCarro.Cor}");
        Console.WriteLine($"Ano: {meuCarro.Ano}");
    }
}

/*
 * 1 - Criação de Classes Simples: Crie uma classe Animal com atributos como raça, cor e idade. A classe deve ter um
   método morder que imprime uma mensagem indicando que o animal está mordendo.
 */

using System;

class Programa {
    class Animal
    {
        public string Raca;
        public string Cor;
        public int Idade;
    }

    public void Mordida()
    {
        Console.WriteLine("Está mordendo");
    }

    static void Main(string[] args)
    {
        Animal meuAnimal = new Animal();
    
        meuAnimal.Raca = "Siamês";
        meuAnimal.Cor = "Bege e preto";
        meuAnimal.Idade = 1;
    
        Console.WriteLine($"Raca: {meuAnimal.Raca}");
        Console.WriteLine($"Cor: {meuAnimal.Cor}");
        Console.WriteLine($"Idade: {meuAnimal.Idade}");
    }
}
