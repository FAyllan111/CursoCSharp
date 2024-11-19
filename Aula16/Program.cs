// GO TO -> gera um desvio para um ponto indicado pelo programador 

class Aula16{
    static void Main(){

        int tempo;
        char escolha;

        inicio:   //um label um checkpoint que o goto pode enviar e pode ser usado como um menu, mais facil que usar o switch total, preferivel usar os comandos de repetição

        Console.Clear(); // limpa o console

        Console.WriteLine("Calculo de viagem");
        Console.WriteLine("Escolha o transporte: [a] Avião | [c] Carro | [o] Onibus | [b] Bicicleta | [p] Caminhando");
        escolha = char.Parse(Console.ReadLine());
 

        // estrutura do switch tem que ter o case e o break, bem como o default para casos que caiam no processo fora do padrão definido

        switch(escolha){
            case 'a':
            case 'A':// suwitch e case para duas opções no caso de maiusculo e minusculo
                tempo = 58;
                break;
            case 'c':
            case 'C':
                tempo = 468;
                break;
            case 'o':
            case 'O':
                tempo = 796;
                break;
            case 'b':
            case 'B':
                tempo = 1589;
                break;
            case 'P':
            case 'p':
                tempo = 10598;
                break;
            default:// caso nenhuma esteja nas opções
                tempo = -1;
                break;
        }

        if(tempo <0){
            Console.WriteLine("Valor inválido!");

        }else{
            Console.WriteLine($"O tempo de viagem é de : {tempo} minutos");
        }

        //ler o escolha

        Console.WriteLine("Deseja Calcular outro transporte? [S/N] : ");
        escolha = char.Parse(Console.ReadLine());
        if (escolha == 'S' || escolha == 's'){
            goto inicio; // usando o goto -> goto label 
        }else{
            Console.Clear();
            Console.WriteLine("Programa finalizado");
        }

    }
}