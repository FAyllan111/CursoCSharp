// metodos para vetores e matrizes - parte 1
class Aula23
{
    static void Main()
    {
        int[] vetor1 = new int[5];// vetores apenas definidos
        int[] vetor2 = new int[5];
        int[] vetor3 = new int[5];
        int[,] matriz = new int[2, 5] { { 25, 28, 38, 489, 59 }, { 98, 488, 84, 5484, 584 } };

        Random random = new Random();
        for (int i = 0; i < vetor1.Length; i++)
        {
            vetor1[i] = random.Next(50);
        } // gerou numeros aleatorios com a classe random e gera numeros preenchendo o vetor 1

        Console.WriteLine("Elementos vetor 1");
        foreach (int n in vetor1)
        {
            Console.WriteLine(n);
        } // imprimindo os valores do vetor 1
        Console.WriteLine("______________________________________________");
        
        // public static int BinarySearch(array, valor);
        // retorna um inteiro relacionado com a posição do array, se retornar -1 não existe aquele elemento no array
        Console.WriteLine("M1:BinarySearch");
        int procurado = 45;//valor pesquisar
        int pos = Array.BinarySearch(vetor1, procurado);//chama direto da classe Array
        Console.WriteLine($"Valor {procurado} esta na posição {pos}");
        Console.WriteLine("______________________________________________");

        //public static void Copy(array_origem,array_destino,Qntd_elementos);
        //retorna um void e chamado pela classe Array
        Console.WriteLine("M2:Copy");
        Array.Copy(vetor1, vetor2, vetor1.Length);// copiando todos os elementos do array 1 para o aray2
        foreach (int n in vetor2)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("_______________________________________________");// percorrendo o array 2 para verificar

        //public void CopyTo(array_destino,a_partir_dessa_posição_copie);
        //metodo chamado apartir do vetor de origem nao da classe Array
        Console.WriteLine("M3: CopyTo");
        vetor1.CopyTo(vetor3, 0);
        foreach (int n in vetor3)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("________________________________________________");

        //public long GetLongLength(dimensao);
        //retorna a quantidade de elementos dentro do array/matriz
        Console.WriteLine("M4: GetLongLength");
        long qntdElementosVetor = vetor1.GetLongLength(0);
        Console.WriteLine($"Quantidade de elementos : {qntdElementosVetor}");
        Console.WriteLine("_____________________________________________________");

        
        //public int GetLowerBound(dimensao);
        // retorna o menor indice do array ou matriz 
        Console.WriteLine("M5: GetLongBound");
        int MenorIndiceVetor = vetor1.GetLowerBound(0);
        int MenorIndiceMatriz = matriz.GetLowerBound(1);// matriz indica qual opção quer obter
        Console.WriteLine($"Menor Indice do vetor1 {MenorIndiceVetor}");
        Console.WriteLine($"O menor indice da matriz é {MenorIndiceMatriz}");
        Console.WriteLine("______________________________________________________");

        //public int GetUpperBound(dimensao);
        // retorna o maior indice do array ou matriz,mantendo o mesmo do lower
        Console.WriteLine("M6: GetUpperBound");
        int MaiorIndiceVetor = vetor1.GetUpperBound(0);
        int MaiorIndiceMatriz = matriz.GetUpperBound(1);
        Console.WriteLine($"O maior indice do vetor1 é {MaiorIndiceVetor}");
        Console.WriteLine($"O maior indice da matriz é {MaiorIndiceMatriz}");
        Console.WriteLine("_____________________________________________________");
        

        //public  object GetValue(Long,indice);
        //retorna o valor apartir de um indice, retornando como object e para retornar como o tipo desejado tem que fazer o cast, nesse caso cast para inteiro
        Console.WriteLine("M7: GetValue");
        int valor0 = Convert.ToInt32(vetor1.GetValue(3));
        int valor1 = Convert.ToInt32(matriz.GetValue(1, 3));
        Console.WriteLine($"Valor da posicao 3 do vetor1 : {valor0}");
        Console.WriteLine($"Valor da posicao 3 da dimensao 1 da matriz é : {valor1}");
        Console.WriteLine("_____________________________________________________");

        //public static int IndexOf(array,valor);
        //retorna o indice do valor procurado, e em caso de repetição retorna a posicao do primeiro valor encontrado
        Console.WriteLine("M8:IndexOf");
        int indice1 = Array.IndexOf(vetor1, 3);
        Console.WriteLine($"Indice do primeiro valor 3: {indice1}");
        Console.WriteLine("______________________________________________________");

        //public static int LastIndexOf(array,valor);
        //retorna o indice do valor procurado, e em caso de repetição retorna a posicao do ultimo valor encontrado
        Console.WriteLine("M9:LastIndexOf");
        int indice2 = Array.LastIndexOf(vetor1, 3);
        Console.WriteLine($"Indice do ultimo valor 33: {indice2}");
        Console.WriteLine("______________________________________________________");

        //public static void Reverse(array);
        //inverte a ordem dos elementos 
        Console.WriteLine("M10:Reverse");
        Array.Reverse(vetor1);
        foreach (int n in vetor1)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("______________________________________________________");

        //public void SetValue(object valor,long pos);
        //definir um valor na posicao do vetor,valor que quer colocar e a posição que quer setar o valor
        Console.WriteLine("M11: SetValue");
        vetor2.SetValue(99, 0);
        for (int i = 0; i < vetor2.Length; i++)
        {
            vetor2.SetValue(0, i);
        }
        Console.WriteLine("Vetor 2:");
        foreach (int n in vetor2)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("______________________________________________________");

        //public static void Sort(array);
        //ordenar em ordem crescente o array dos elementos menor para o maior
        
        Console.WriteLine("M12:Sort");
        Array.Sort(vetor1);
        Array.Sort(vetor2);
        Array.Sort(vetor3);
        Console.WriteLine("Vetor1:");
        foreach (int n in vetor1)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("Vetor2:");
        foreach (int n in vetor2)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("Vetor3:");
        foreach (int n in vetor3)
        {
            Console.WriteLine(n);
        }

        //DICA: para trazer em ordem decrescente pode-se usar o sort e depois o reverse 

        Console.WriteLine("Ordem decrescente do sort");
        Array.Reverse(vetor1);
        Array.Reverse(vetor2);
        Array.Reverse(vetor3);
        Console.WriteLine("Vetor1:");
        foreach(int n in vetor1){
            Console.WriteLine(n);
        }
        Console.WriteLine("Vetor2:");
        foreach(int n in vetor2){
            Console.WriteLine(n);
        }
        Console.WriteLine("Vetor3:");
        foreach(int n in vetor3){
            Console.WriteLine(n);
        }
    }
}



