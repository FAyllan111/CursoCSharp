//iteração while
class Aula20{
    static void Main(){
        // usar quando nao se tem certeza de quantas vezes é pra repetir

        //while(e1){}
        // usa apenas uma expressao e enquanto ela for verdadeira ele continua executando, como usa apenas uma expressao e a variavel de contagem ou variavel de controle e é definida fora do contador e o incremento é realizado dentro do loop

        int[] num = new int[10];

        int i= 0;
        while(i<10){
            Console.WriteLine($"Texto Antes:{i}");
            i++; // testando a diferenca antes e depois do iterador
            Console.WriteLine($"Texto Depois: {i}");
        }
        Console.WriteLine("fora do loop");

        // para percorrer arrays 
        i = 0;
        while(i<num.Length){
            num[i] = 0;
            Console.WriteLine($"Array{num[i]} = {i}");
            i++;
            
        }

    }
}