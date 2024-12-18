/*
2 - Herança Básica: Crie uma classe Animal com o método fazerSom. Em seguida,
crie duas subclasses: Cachorro e Gato, cada uma com uma implementação específica do método fazerSom.

Fazer uma altenativa

2 - Herança Básica: Crie uma classe Carro com o método Aceleração. Em seguida,
   crie duas subclasses: Convercível e Normal, cada uma com uma implementação específica do método acelerar.
 */

using System;

public class Animal {
    public string Cor;
    public int Idade;

    public virtual void FazerSom() {
        Console.WriteLine("Fazendo som aleatório");
    }
}

public class Gato : Animal {
    public string Raca;

    public override void FazerSom() {
        Console.WriteLine("Miau, miau");
    }
}

public class Cachorro : Animal {
    public string Mordida;

    public override void FazerSom() {
        Console.WriteLine("Au, au");
    }
}

class Program {
    static void Main(string[] args) {
        Animal meuGato = new Gato();
        Animal meuCachorro = new Cachorro();

        meuGato.FazerSom();
        meuCachorro.FazerSom();
    }
}


// Alternativa atividade

/*
2 - Herança Básica: Crie uma classe Carro com o método Aceleração. Em seguida,
crie duas subclasses: Convercível e Normal, cada uma com uma implementação específica do método acelerar.
*/
 
using System;

public class Carro{
    public string Modelo;
    public int Ano;
    
    public virtual void Acelerar(){
        Console.WriteLine("Acelerando normal");
    }
}

public class Conversivel : Carro {
    public string Capota;
    
    public override void Acelerar(){
        Console.WriteLine("Acelerando conversivelmente");
    }
}

public class Normal : Carro {
    public string ProtecaoChuva;
    
    public override void Acelerar(){
        Console.WriteLine("Acelerando protegendo da chuva");
    }
}

class Program{
    static void Main(string[] args){
        Carro meuConversivel = new Conversivel();
        Carro meuNormal = new Normal();
        
        meuConversivel.Acelerar();
        meuNormal.Acelerar();
    }
}
