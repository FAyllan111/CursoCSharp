// metodos pt 2 
//passagem por referencia -> usa-se o ref 
// tem que usar o ref ao definir o valor e ao chamar que ai sim vai utilizar-se do mesmo espaço de memoria
//ref => usa o endereço de memoria da variavel passada como argumento e nao cria uma novo endereço de memoria para o metodo e copia o valor da posição

class Aula25{
    static void Main(){
        int num = 10;
        dobrar(ref num); //passagem por referencia
        dobrar1(num); // passagem por valor
        Console.WriteLine(num);
    }

    //pasagem por referencia 
    static void dobrar(ref int valor){
        valor *= 2;
        //Console.WriteLine(valor);
    }

    //passagem por valor
    static void dobrar1(int valor){
        valor *= 2;
        //Console.WriteLine(valor);
    }
}