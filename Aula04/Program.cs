using System.Globalization;


// ESCOPOS 
class Aula04{ // escopos de vatiaveis -> onde e visivel se é globalmente ou localmente

    int num1 = 34; // variavel de escopo global que está no contexto da classe inteira
    static void Main (){
        int num = 1; // acessado no metodo main, o que for por fora a variavel nao tem visibilidade=> variavel local
        // ese o metodo é static a varavel global tambem tem que ser static , no caso de variaveis globais tem que ter o mesmo tipo do metodo
    }

    // declarando um metodo
    void Teste(){
        int num = -2; // tambem é uma variavel local 
        Console.WriteLine(num);
    }
} 