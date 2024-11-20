// iteravao for each iterar e LER elementos de uma coleção
class Aula22{
    static void Main(){

        
        int[] num = new int[3] { 11, 13, 42 };


        // lendo um vetor com for
        Console.WriteLine("Lendo no FOR:");
        for(int i=0;i<num.Length;i++){
            Console.WriteLine(num[i]);
        }

        //lendo com o foreach
        Console.WriteLine("Lendo no FOREACH:");
        foreach(int n in num){
            Console.WriteLine(n);
        }
    }
}