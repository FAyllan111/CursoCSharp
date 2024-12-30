// iteracao do  while
class Aula21{
    static void Main(){

        //garante que pelo menos uma vez o comando sera executado,poi se o while a condição ja e satisfeita ele não roda, while -> testa e executa; do while -> executa e depois testa

        /* sintaxe do while

            do{
            }while(cond){

            }
          */

        int num = 5;
        while(num<5){
            Console.WriteLine("imprimindo o while");
        } // condição nao satisfeita 
        Console.WriteLine("Fora do While");

        do
        {
            Console.WriteLine("Testando o Do/While");
        } while (num < 5);
        Console.WriteLine("Fora do Do/While");

        //outro exemplo com senha
        string senha = "123";
        string validarSenha;
        int tentativas=0;


        do
        {
            Console.Clear();
            Console.WriteLine("Digite sua senha:");
            validarSenha = Console.ReadLine();
            tentativas++;
            
        } while (senha != validarSenha);
        
        Console.WriteLine("Senha Correta!");
        Console.WriteLine($"Foram feitas : {tentativas} tentativas");
        
    }
}