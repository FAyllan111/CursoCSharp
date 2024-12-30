// metodos
// conjuntos de instruções,blocos que podem ser chamados depois 

class Aula24{
    static void Main(){
        //chamando o metodo void
        mtd();

        /*
        //usando metodo no for
        for(int i=0;i<5;i++){
            mtd();
        }*/

        //chamar metodo com valores de entrada, chama atribuindo os valores
        soma(5, 9); // valores do primeiro argumento e segundo

        // metodo lendo os valores do teclado
        int v1, v2,r;
        Console.WriteLine("Digite o primeiro número do método:");
        v1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo número do método:");
        v2 = Convert.ToInt32(Console.ReadLine());
        soma(v1, v2);
        //atibuir a variavel que vai receber os valores e retornar para o usuário
        r = soma2(v1, v2);
        Console.WriteLine($"A soma de {v1} e {v2} é {r}");
        

    }

    static void mtd(){ // metodo basico( simples) ; estrutura=> tipo (static) ,  void = retorna nada , nome do metodo e parentesis , e chaves delimitadoras
        Console.WriteLine("Curso C#");
        Console.WriteLine("aula tuentifou");
        Console.WriteLine("CFB Cursos");

    }

    //metodo com argumentos de entrada e retorna um valor
    static void soma(int n1, int n2){

        int soma = n1 + n2;
        Console.WriteLine($"A soma de {n1} e {n2} = {soma}");
    }

    // metodo que retornam apenas os valores e tem que se definir o tipo de dado que vai ser retornada no lugar do void
    static int soma2(int n1, int n2){
        int res = n1 + n2;
        return res;
    }
}