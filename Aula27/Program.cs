//metodos
//params => permite a entrada de 0 ou mais argumentos para uma função/metodo, nele ja definido, ou seja deixa informar a quantidade de valores a serem inseridos dinaicamente
class Aula27{
    static void Main(){
        somap(1,10,55,954,5484,265,451,1578);
    }

    // declaração normal, onde se fosse adicioanar mais um numero tinha que adicionar manualmente no codigo
    static void soma(int n1,int n2){
        int res = n1 + n2;
        Console.WriteLine($"A soma de {n1} e {n2} é : {res} ");
    }

   //usando params
   // verificar os valoes, se nao foi adicionado nenhum valor =faz nada; se for um mostra o valor inserido; se for mais de um vai percorrer o array e fazer a operação
   static void somap(params int[]n){
        int res=0;

        //verificar o tamanho do array
        if(n.Length<1){
            Console.WriteLine("Não existem valores a serem somados!");
        }else if(n.Length <2){
            Console.WriteLine($"Valores insuficientes para realizar a operação! ");
        }else{
            for(int i=0;i<n.Length;i++){
                res += n[i]; // soma dos valores
            }
            Console.WriteLine($"A soma dos valores é : {res}");
        }
    }
}