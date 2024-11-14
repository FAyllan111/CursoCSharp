//ENUM

// usado para definir um tipo personalizado e defino os valores do meu tipo


class Aula10{
    enum DiasSemana{Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sábado}; // valores que a variavel pode assumir 


    static void Main(){

        DiasSemana ds = DiasSemana.Domingo; // definindo o dia

        Console.WriteLine(ds);

        // usando os indices

        ds = (DiasSemana)3;

        Console.WriteLine(ds);

        // fazendo o contrario 

        int di = (int)DiasSemana.Sexta; 
        // converte o indice em numero e retorna o valor o indice do enumerador

        Console.WriteLine(di);

    }
}