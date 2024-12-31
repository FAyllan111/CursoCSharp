//HERANÇA

class Veiculo{//classe base
    public int velMax;
    private bool ligado;
    public int rodas;

    public void ligar(){
        ligado = true;
    }

    public void desligar(){
        ligado = false;
    }

    public string getLigado(){
        if(ligado){
            return "Sim";
        }else{
            return "Não";
        }
    }

   
}

//classe que vai herdar de veiculo

//classe derivada:classe base
class Carro:Veiculo{ // derivada

    public string nome;
    public string cor;
    public Carro(string nome,string cor){
        //ligado = false; // ao trazer propriedades privadas nao podem ser acessados fora da classe original
        desligar();
        rodas = 4;
        velMax = 112;
        this.nome = nome;
        this.cor = cor;

    }
}



class Aula34
{
    static void Main()
    {
        Carro c1 = new Carro("Civic", "Vermelho");

        //c1.ligado = true; não funciona mais pois e privada

        Console.WriteLine($"Modelo: { c1.nome}");
        Console.WriteLine($"Cor: { c1.cor}");
        Console.WriteLine($"Rodas: { c1.rodas}");
        Console.WriteLine($"Vel. Maxima: { c1.velMax}");
        Console.WriteLine($"Ligado: { c1.getLigado()}");


    }
}