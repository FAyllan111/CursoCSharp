//SOBRECARGA DE CONSTRUTORES 
//criar mais de um construtor para a classe, modificando apenas os valores de parametros

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
    public Jogador() {
        energia = 100;
        vivo = true;
        lesionado = false;
        gols = 0;
        titulos = "";
        equipe = "";
        nome = Jogador;
    
    } // escopo local 

    public Jogador(string nomeJogador) {
        energia = 100;
        vivo = true;
        lesionado = false;
        gols = 0;
        titulos = "";
        equipe = "";
        nome = nomeJogador;
    
    } // escopo local

    public Jogador(string nomeJogador,int e) {
        energia = e;
        vivo = true;
        lesionado = false;
        gols = 0;
        titulos = "";
        equipe = "";
        nome = nomeJogador;
    
    } // escopo local
   
    public Jogador(string nomeJogador,int e,bool v) {
        energia = e;
        vivo = v;
        lesionado = false;
        gols = 0;
        titulos = "";
        equipe = "";
        nome = nomeJogador;
    
    } // escopo local

    public info(){
        Console.WriteLine(nome);
        Console.WriteLine(vivo);
        Console.WriteLine(lesionado);
        Console.WriteLine(gols);
        Console.WriteLine(titulos);
        Console.WriteLine(energia);

    }

}


class Aula30
{
    static void Main()
    {
        //criar um objeto da classe jogador

        string nome1;
        // ler o nome no teclado e adiconar ao nome do da classe jogador
        Jogador j1 = new Jogador(); //=> new = reserva o espaço da memoria para o objeto
        Jogador j2 = new Jogador("Ancara Meççi");
        Jogador j3 = new Jogador("Ronaldino",85);
        Jogador j4 = new Jogador("Pele",0,false);

        j1.info();
        j2.info();
        j3.info();
        j4.info();
    }
} 