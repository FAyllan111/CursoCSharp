//Classes e objetos - inicio da poo

// nova classe => classe = letra maiucula 

class Jogador { //=> não definido modificador é publica
    //propriedades
    public int energia = 100;
    public bool vivo;
    public int gols;
    public bool lesionado;
    public string titulos;
    public string equipe;

}


class Aula28{
    static void Main(){
        //criar um objeto da classe jogador
        Jogador j1 = new Jogador(); //=> new = reserva o espaço da memoria para o objeto
        Jogador j2 = new Jogador();


        //alterando as propriedades da classe 
        j1.energia = 95;
        j2.energia = 50;
        //ler propriedades da classe

        Console.WriteLine($"A energia do jogador 1 é: {j1.energia}");
        Console.WriteLine($"A energia do jogador 2 é: {j2.energia}");

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
    }
}

/*
CLASSES

A base do objeto ela que define como vai ser os objetos, a partir pode mser instanciados de acordo com a classe e cada objeto é individual  , chama a classe com new


=> sintaxe padrão:

[ModificadorClasse] class NOME_DA_CLASSE{
    variaveis => são chamadas de PROPRIEDADES na orientação a objeto
    [EspecificadorAcesso] tipo NOME_PROPRIEDADE;

    /Metodos
    [EspecificadorAcesso] retorno NOME_MÉTODO([arg1,...]){
        /corpo do metodo
    }
}

=> ModificadorClasse: Define a visibilidade da classe
    OBS: caso nao seja definido a visibilidade automaticamente ela é publica
    -public: Publica, sem restrição de visualização ou acesso
    -abstract : Classe -Base para outras classes e não podem ser instanciados a objetos desta classe não pode gerar objetos por ela
    -sealed: classe não pode ser herdada
    -static: classe não permite a instanciação de objetos e seus membros devem ser static tambem e podem acessar os membros dessa classe 

=> EspecificadorAcesso: Onde um membro da classe pode ser acessado para metodos e propriedades

    -public: sem restrição de acesso
    -private: so podem ser acessados pela propria classe, precisa de um metodo para poder manipular os dados da classe
    -protected : podem ser acessados na propria classe e nas classes derivadas ( herança)
    -abstract: os metodos nao tem implementação sobre os cabeçalhos,não tem a definção do metodo, sem o que a classe faz, sendo usada apenas para servir como classe pai e as classes filhas é que vão implementar os metodos () ações)
    -sealed: o metodo nao pode ser redefinido , metodo padrão imutavel
    -virtual: o metodo pode ser redefinido em uma classe derivada, que está herdando dessa classe pai
    -static: o metodo pode ser chamado mesmo sem a instanciação de um objeto da classe,não é necessário usar o new para instanciar algum elemento da classe 


*/