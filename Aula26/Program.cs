//Metodos => out
// faz o metodo retornar mais de um valor de saida e é semelhante ao ref para ser declarado
//out é ilimitado, podendo gerar retorno de mais valores,

class Aula26{
    static void Main(){
        int c1, b1, quoc, rest;
        c1 = 10;
        b1 = 3;
        quoc = divide(c1, b1, out rest);

        Console.WriteLine($"A divisão de {c1} por {b1} é : {quoc} e o resto é: {rest}");
    }

    static int divide(int cima,int baixo,out int resto){
        int res;
        resto = cima%baixo;
        res = cima / baixo;
        //return => retornando um valor só
        return res; // resultado
    }
}