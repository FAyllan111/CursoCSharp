//METODO STATIC=> Nao pode instanciar o objeto atravez dessa classe, classe static nao usam construtores, ou seja ela tem valor/posição fixa na memoria portanto não vai gerar uma nova posição atraves do new


static public class Jogador{ 
    //propriedades
    static public int energia;
    static public bool vivo;
    static public string nome;

    static public void iniciar(string nomeJogador) {
        energia = 100;
        vivo = true;
        nome = nomeJogador;
    } // escopo local 

    static public void info(){
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Energia: {energia}");
        Console.WriteLine($"Vivo: {vivo}");
    }

}

public class Inimigo{
    static public bool alerta; // alerta para todas as classes 

    public string nome;

    public Inimigo(string nomeInimigo){
        alerta = false;
        nome = nomeInimigo;
    }

    public void info(){
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Alerta: {alerta}");
        Console.WriteLine("____________________________________");

    }
}


class Aula31{    
    static void Main()
    {
        //acessando as propriedades do metodo jogador com ele sendo "static"

        Jogador.iniciar("Dede");
        Jogador.info();


        Inimigo i1 = new Inimigo("Gumba");
        Inimigo i2 = new Inimigo("Koopa");
        Inimigo i3 = new Inimigo("Browser");

        //mudando o alerta para true
        Inimigo.alerta = true;// como e static todos vão ter a modificação dna propriedade alerta 
        //como e static nao pode ser acessado por i1.alerta = true;

        i1.info();
        i2.info();
        i3.info();
    }
}