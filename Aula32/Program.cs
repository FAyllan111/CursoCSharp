//OPERADOR THIS => sempre vai fazer referencia ao objeto pai, nao ao metodo objeto filho 

class Calculos{
    public int v1;
    public int v2; 

    public Calculos(int v1,int v2){
        //define para o v1 e v2 global tambem, ou seja nao esta definido qual v1 e v2 vai ser atribuido os valores
        // v1 = v1;
        // v2 = v2;
        // por isso se usa o this. definindo que o v1 pertence ao objeto e não ao parametro do metodo 
        this.v1 = v1;
        this.v2 = v2;
    }

    
    public int Somar(){
        return v1 + v2;
    }
}


class Aula32{
    static void Main(){

        Calculos c = new Calculos(15, 2);

        Console.WriteLine(c.Somar());
    }
}