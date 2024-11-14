// OPERADORES DE BITWISE OU OPERADORES DE SHIFT 

// operadores que deslocam os bits para a direita ou para a esquerda

/* 
opoerador de bitwise para a esquerda vai dobrar o valor da variavel e para a direita vai reduzir pela metade o valor da variavel



<<(esq): -> desloca os ultimos 5 bits paea a esquerda e e preenchido com bits zero

EX: 10 - 00001010
-> deslocamento esquerda = no caso adiciona um zero no final
EX: 00010100 - 20


>>(dir): desloca os ultimos 5 bits paea a direita e e preenchido com bits zero

EX: 00011010 - 26
> deslocamento direita = no caso o ultimo bit é excluido e adiciona zero no inicio
EX: 00001101 - 13


*/

class Aula09{
    static void Main(){

        int num = 10;

        num = num << 1; // deslocar para esquerda

        Console.WriteLine(num);

        num = num >> 1; // deslocar para a direita

        Console.WriteLine(num);

        num = 13;

        num = num >> 1;

        Console.WriteLine(num);

    }
}