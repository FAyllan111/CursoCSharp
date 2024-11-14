//LENDO VALORES DO TECLADO -INPUTS

class Aula08{
    static void Main(){
        int v1, v2, soma;
        string nome;

        Console.Write("Digite seu nome:");
        nome = Console.ReadLine();
        Console.WriteLine($"Olá {nome}!");
        Console.WriteLine("Digite o primeiro valor:");
        v1 = int.Parse(Console.ReadLine());// metodo conversão 1
        Console.WriteLine("Digite o segundo valor:");
        v2 = Convert.ToInt32(Console.ReadLine()); // metodo conversao 2
        soma = v1 + v2;
        Console.WriteLine($"{nome} a soma do {v1} e {v2} é igual a : {soma}");
    }
}