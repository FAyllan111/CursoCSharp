//VARIAVEIS// 
class Aula03{
    static void Main(){
        //tipos primitivos:
        byte n1 = 10; // tabela de bytes 
        int num = -10; // declarar a variavel
        char letra = 'a';
        float valor = 3.1415f;

        //tipo referencia 
        string nome = "Ayllan";

        // especial 
        var auxiliar = 10; // o VAR nao especifica o tipo da variavel , definido pela atribuição durante a compilação, ou seja e dinamicaa

        // declarando mais de uma variavel do mesmo tipo e realizando operações nelas
        
        int num1, num2, res;
        num1 = 10;
        num2 = 2;
        res = num1 + num2;

        Console.WriteLine($" A soma de {num1}, mais {num2} é igual a {res}");

        // escrever a variavel
        Console.WriteLine(nome);
        Console.WriteLine(" Exemplo de concatenação " + auxiliar);


    }
}