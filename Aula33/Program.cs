//PRIVATE VS PUBLIC

class Jogador{
    private int energia;
    private string nome; // so pode ser usado por dentro da classe, no caso nos construtores
    // nao pode mudar fora da classe 

    public Jogador(string nome){
        this.nome = nome; //=> atribuindo o nome do jogador no nome la de fora
        energia = 100;
    }

    //obter os valores agora que estão privados

    public int getEnergia(){
        return energia;
    }

    public string getNome(){
        return nome;
    }

    //alterar os valores dos metodos privados cria um metodo publico para modificar dentro da propria classe 
    
    public void setEnergia(int e){
        if(e<0){
            if(energia + e <0){
                energia = 0;
            }else{
                energia += e;
            }
        }else if(e>0){
            if(energia + e > 100){
                energia = 100;
            }else{
                energia += e;
            }
        }
    }

}
class Aula33{
    static void Main(){

        Jogador j1 = new Jogador("Didi");

        j1.setEnergia(-120);


        Console.WriteLine(j1.getNome());
        Console.WriteLine(j1.getEnergia());

    }
}