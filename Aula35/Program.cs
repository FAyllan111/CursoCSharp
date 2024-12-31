// CADEIAS DE HERANÇA

class Veiculo{//classe base
    public int velMax;
    private bool ligado;
    private int rodas;

    public Veiculo(int rodas){
        this.rodas = rodas;
    }
    public void ligar(){
        ligado = true;
    }

    public void desligar(){
        ligado = false;
    }

    public string getLigado(){
        //usando o operador ternario:
        return (ligado ? "Sim" : "Não");
        //return ('condição que quer se testar' ? 'resposta se for verdadeiro' : 'resposta caso seja falso')

        /* 
        if(ligado){
            return "Sim";
        }else{
            return "Não";
        } */

    }

    public int getRodas(){
        return rodas;
    }

    public void setRodas(int rodas){
        if(rodas<0){
            this.rodas = rodas;
        }else if (rodas > 20){
            this.rodas = 20;
        }
    }

   
}

//classe que vai herdar de veiculo

//classe derivada:classe base
class Carro:Veiculo{ // derivada

    public string nome;
    public string cor;
    public Carro(string nome,string cor):base(3){// instanciando o construtor da classe pai
        //ligado = false; // ao trazer propriedades privadas nao podem ser acessados fora da classe original
        desligar();
        //rodas = 4; => tornou privado na classe pai 
        velMax = 112;
        this.nome = nome;
        this.cor = cor;
        
    }
}

//cadeia de herança, herança da classe filho anterior (carro)

class carroCombate:Carro{

    public int municao;

    public carroCombate():base("Batmovel","Verde"){
        municao = 100;
        setRodas(6);
    }
}

class Aula35
{
    static void Main()
    {
        Carro c1 = new Carro("Civic", "Vermelho");
        carroCombate cc1 = new carroCombate();

        //c1.ligado = true; não funciona mais pois e privada

        Console.WriteLine($"Modelo: { c1.nome}");
        Console.WriteLine($"Cor: { c1.cor}");
        Console.WriteLine($"Rodas: { c1.getRodas()}");
        Console.WriteLine($"Vel. Maxima: { c1.velMax}");
        c1.ligar();
        Console.WriteLine($"Ligado: { c1.getLigado()}");
        Console.WriteLine("_______________________________");

        Console.WriteLine($"Modelo: { cc1.nome}");
        Console.WriteLine($"Cor: { cc1.cor}");
        Console.WriteLine($"Rodas: { cc1.getRodas()}");
        Console.WriteLine($"Vel. Maxima: { cc1.velMax}");
        cc1.ligar();
        Console.WriteLine($"Ligado: { cc1.getLigado()}");
        Console.WriteLine($"Ligado: { cc1.municao}");


    }
}