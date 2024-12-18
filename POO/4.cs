/*
4 - Polimorfismo Simples: Crie uma classe Forma com um método area. Implemente duas subclasses, 
Circulo e Retangulo, que sobrescrevem o método area para calcular a área específica de cada forma.

Fazer alternativa
 */
     
    using System;

    public class Forma
    {
        public virtual double Area()
        {
            return 0; 
        }
    }

    public class Circulo : Forma
    {
        private double raio;

        public Circulo(double raio)
        {
            this.raio = raio; 
        }

        public override double Area()
        {
            return Math.PI * raio * raio;
        }
    }

    public class Retangulo : Forma
    {
        private double altura;
        private double largura;

        public Retangulo(double altura, double largura)
        {
            this.altura = altura;
            this.largura = largura;
        }

        public override double Area()
        {
            return altura * largura; 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Forma forma1 = new Circulo(5); 
            Forma forma2 = new Retangulo(4, 6); 

            Console.WriteLine("Área do círculo: " + forma1.Area());
            Console.WriteLine("Área do retângulo: " + forma2.Area());
        }
    }

/*
 * 4- Crie uma classe base Forma com métodos abstratos Area e Perimetro. Implemente subclasses Triangulo, Circulo e Retangulo que sobrescrevem esses métodos.
 * Em seguida, crie uma lista de objetos do tipo Forma e preencha-a com diferentes instâncias de Triangulo, Circulo e Retangulo.
 * Itere sobre a lista e imprima a área e o perímetro de cada forma.
*/
using System;

public abstract class Forma
{
    public abstract double Area();
    public abstract double Perimetro();
}

public class Circulo : Forma
{
    private double raio;

    public Circulo(double raio)
    {
        this.raio = raio;
    }

    public override double Area()
    {
        return Math.PI * raio * raio;
    }

    public override double Perimetro()
    {
        return 2 * Math.PI * raio;
    }
}

public class Triangulo : Forma
{
    private double lado1, lado2, lado3, altura, baseTriangulo;

    public Triangulo(double lado1, double lado2, double lado3, double altura, double baseTriangulo)
    {
        this.lado1 = lado1;
        this.lado2 = lado2;
        this.lado3 = lado3;
        this.altura = altura;
        this.baseTriangulo = baseTriangulo;
    }

    public override double Area()
    {
        return (baseTriangulo * altura) / 2;
    }

    public override double Perimetro()
    {
        return lado1 + lado2 + lado3;
    }

    public bool TipoEquilatero()
    {
        return lado1 == lado2 && lado1 == lado3;
    }
}

public class Retangulo : Forma
{
    private double largura;
    private double altura;

    public Retangulo(double largura, double altura)
    {
        this.largura = largura;
        this.altura = altura;
    }

    public override double Area()
    {
        return largura * altura;
    }

    public override double Perimetro()
    {
        return 2 * (largura + altura);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Forma forma1 = new Circulo(2);
        Forma forma2 = new Triangulo(3, 3, 3, 4, 5);
        Forma forma3 = new Retangulo(3, 7);

        Console.WriteLine("Área do círculo: " + forma1.Area());
        Console.WriteLine("Perímetro do círculo: " + forma1.Perimetro());

        Triangulo triangulo = (Triangulo)forma2; 
        Console.WriteLine("Área do triângulo: " + triangulo.Area());
        Console.WriteLine("Perímetro do triângulo: " + triangulo.Perimetro());
        Console.WriteLine("É equilátero? " + (triangulo.TipoEquilatero() ? "Sim" : "Não"));

        Console.WriteLine("Área do retângulo: " + forma3.Area());
        Console.WriteLine("Perímetro do retângulo: " + forma3.Perimetro());
    }
}
