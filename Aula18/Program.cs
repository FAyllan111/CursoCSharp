// Arrays bidimensionais -> matrizes
class Aula18{
    static void Main(){
        int[,] n = new int[3, 5]; //matriz sem valores definidos 
        // matriz usa a virgula entre os colchetes e passa o tamanho da matriz dentro da coluna 

        int[,] num = new int[2, 2] { { 10, 20 },{ 30, 40 } }; //matriz com valores dedinidos
        /* matriz do exemplo: 3 linhas e 5 colunas:

        | x1 x2 x3 x4 x5     |
        |  x6 x7 x8 x9 x10   |
        |x11 x12 x13 x14 x15 |

        10 20 30 40 50
        60 70 80 90 15
        25 35 45 55 65

        */

        //atribuindo elementos na matriz [ linha, coluna]= valor;

        n[0, 0] = 10; n[0, 1] = 20; n[0, 2] = 30; n[0, 3] = 40; n[0, 4] = 50;
        n[1, 0] = 60; n[1, 1] = 70; n[1, 2] = 80; n[1, 3] = 90; n[1, 4] = 15;
        n[2, 0] = 25; n[2, 1] = 35; n[2, 2] = 45; n[2, 3] = 55; n[2, 4] = 65;

        // imprimir valor especifico
        Console.WriteLine(n[1, 3]);
        Console.WriteLine(n[2, 4]);

        Console.WriteLine(num[0,1]);
        Console.WriteLine(num[1,0]);

    }
}