//  ordem de execução dos construtores

class Base{
    public Base(){
        Console.WriteLine("Construtor da classe Base");
    }
}

class DerivadaFilha:Base{
    public DerivadaFilha(){
        Console.WriteLine("Construtor da classe Derivada filha");
    }
}

class DerivadaNeta:DerivadaFilha{
    public DerivadaNeta(){
        Console.WriteLine("Construtor da classe Derivada Neta");
    }
}

class Aula37{
    static void Main(){
        DerivadaNeta neta = new DerivadaNeta();

    }
}