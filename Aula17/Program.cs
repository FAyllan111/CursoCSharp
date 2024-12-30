//Array unidimensional-> vetores => colecao de tipos na mesma variavel

using System.Globalization;

class Aula17{
    static void Main(){
        //int n1, n2, n3, n4, n5;// sera substituido pelo array
        int[] n = new int[5]; // array inteiros, uma das formas de criar um array

        // adicionar elementos indicando a posição pelo indice, inciando com o indice 0 

        n[0] = 1; // atribuindo valor para o array
        n[1] = 234;
        n[3] = 1234;
        n[4] = 8955;
        n[2] = 8998;

        // imprimir uma posicção do array n indica o array e coloca a posução

        Console.WriteLine(n[2]);

        // outras formas de se declarar um array

        int[] num = new int[3] {59,684,97}; // array já iniciado com numeros
        Console.WriteLine(num[2]);

        //outra maneira 

        int[] num2 = { 48, 9852, 548,594 }; ; // sem usar o new e atribuindo, usando o tamanho do array com o numero que elementos que está inicializando 

        Console.WriteLine(num2[3]);

        //estrutura -> tipo string[] nome do array e pode criar de acordo com as maneiras anteriores

    }
}