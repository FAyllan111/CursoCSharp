// CONSTRUTORES E DESCOSTRUTORES - CLASSES PT 2

//CONSTRUTOR inicia os valores da classe, se nao for especificado vem o deault
//metodo construtor tem que ter o mesmo nome da classe 


class Jogador { //=> não definido modificador é publica
    //propriedades
    public int energia;
    public bool vivo;
    public int gols;
    public bool lesionado;
    public string titulos;
    public string equipe;
    public string nome;

    //definindo o metodo construtor => definidos valores padrões e iniciam as  variaveis  e vai ser isntanciado automativamente quando criar os argumensos da classe
    public Jogador(string nomeJogador) {
        energia = 100;
        vivo = true;
        lesionado = false;
        gols = 0;
        titulos = "";
        equipe = "";
        nome = nomeJogador;
    
    } // escopo local 

    //metodo destrutor => chama para destruir o metodo antes de o garbage colector atuar
    ~Jogador(){
        Console.WriteLine("Jogador deletado!");
    }

}


class Aula29{
    static void Main(){
        //criar um objeto da classe jogador
        
        string nome1;
        // ler o nome no teclado e adiconar ao nome do da classe jogador
        Console.WriteLine("Digite o nome do jogador:");
        nome1 = Console.ReadLine();
        Jogador j1 = new Jogador(nome1); //=> new = reserva o espaço da memoria para o objeto
        Jogador j2 = new Jogador("Ronaldihoo");

        Console.WriteLine($"O nome do jogador 1 é: {j1.nome}");
        Console.WriteLine($"O nome do jogador 2 é: {j2.nome}");

        

        /*
        //alterando as propriedades da classe 
        j1.energia = 95;
        j2.energia = 50;
        //ler propriedades da classe

        

        //criando o jogador 1
        j1.energia = 100;
        j1.vivo = true;
        j1.titulos = "Copa do Mundo";
        j1.lesionado = false;
        j1.equipe = "Flasco";
        j1.gols = 589;


        Console.WriteLine($"Dados jogador 1:");
        Console.WriteLine(j1.equipe);
        Console.WriteLine(j1.vivo);
        Console.WriteLine(j1.titulos);
        Console.WriteLine(j1.gols);
        Console.WriteLine(j1.lesionado);
        Console.WriteLine(j1.energia);
        */ 


    }
}