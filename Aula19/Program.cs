
// iteração usando for
using System.Globalization;

class Aula19{
    static void Main(){
        // for usado mais quando sei exatamente quantas vezes se quer repetir o comando

        
        //for(e1;e2;e3){}

        //e1- inicio da contagem, onde vai iniciar a repetição, quanridade de vezes que quer iniciar
        //e2- definicao do mumero de vezes que se vai repetir, expressao logica que enquanto for verdadeiro vai repetir o loop e quando retornar false vai quebrar o laço 
        //e3-iterador , incremento/ decremento feito aqui ex 1 em 1 -> ++ pulando mais numeros -> += X

        for(int num = 0; num < 10;num+=2) {
            Console.WriteLine($"Contando o numero: {num}");
        }

        // para percorer array
        int[] arr = new int[10];

        for(int i=0; i<10; i++){
            arr[i] = 0;
            Console.WriteLine(arr[i]);
        }
    }
}