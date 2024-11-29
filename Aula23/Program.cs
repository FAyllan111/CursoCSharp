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
        Console.WriteLine("M1:BinarySearch");
        int procurado = 1;
        int pos = Array.BinarySearch(vetor1, procurado);
        Console.WriteLine($"Valor{procurado} esta na posição{pos}");
        Console.WriteLine("______________________________________________");

        //public static void Copy(array_origem,array_destino,Qntd_elementos);
        Console.WriteLine("M2:Copy");
        Array.Copy(vetor1, vetor2, vetor1.Length);// copiando todos os elementos do array 1 para o aray2
        foreach (int n in vetor2)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("_______________________________________________");// percorrendo o array 2 para verificar

        //public void CopyTo(array_destino,a_partir_dessa_posição_copie);
        Console.WriteLine("M3: CopyTo");
        vetor1.CopyTo(vetor3, 0);
        foreach (int n in vetor3)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("________________________________________________");

        //publix long GetLongLength(dimensao);
        Console.WriteLine("M4: GetLongLength");
        long qntdElementosVetor = vetor1.GetLongLength(0);
        Console.WriteLine($"Quantidade de elementos : {qntdElementosVetor}");
        Console.WriteLine("_____________________________________________________");

        /*
        //public int GetLowerBound(dimensao);
        Console.WriteLine("M5: GetLongBound");
        int MenorIndiceVetor = vetor1.GetLowerBound(0).ToString();
        int MenorIndiceMatriz = MenorIndiceMatriz.GetLowerBound(0).ToString();
        Console.WriteLine($"Menor Indice do vetor1 {MenorIndiceVetor}");
        Console.WriteLine("______________________________________________________");

        //public int GetUpperBound(dimensao);
        Console.WriteLine("M6: GetUpperBound");
        int MaiorIndiceVetor = vetor1.GetUpperBound(0).ToString();
        int MaiorIndiceMatriz = MaiorIndiceMatriz.GetUpperBound(0).ToString();
        Console.WriteLine($"O maior indice do vetor1 é {MaiorIndiceVetor}");
        Console.WriteLine("_____________________________________________________");
        */

        //public  object GetValue(Long,indice);
        Console.WriteLine("M7: GetValue");
        int valor0 = Convert.ToInt32(vetor1.GetValue(3));
        int valor1 = Convert.ToInt32(matriz.GetValue(1, 3));
        Console.WriteLine($"Valor da posicao 3 do vetor1 : {valor0}");
        Console.WriteLine("_____________________________________________________");

        //public static int IndexOf(array,valor);
        Console.WriteLine("M8:IndexOf");
        int indice1 = Array.IndexOf(vetor1, 3);
        Console.WriteLine($"Indice do primeiro valor 3: {indice1}");
        Console.WriteLine("______________________________________________________");

        //public static int LastIndexOf(array,valor);
        Console.WriteLine("M9:LastIndexOf");
        int indice2 = Array.LastIndexOf(vetor1, 3);
        Console.WriteLine($"Indice do ultimo valor 33: {indice2}");
        Console.WriteLine("______________________________________________________");

        //public static void Reverse(array);
        Console.WriteLine("M10:Reverse");
        Array.Reverse(vetor1);
        foreach (int n in vetor1)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("______________________________________________________");

        //public void SetValue(object valor,long pos);
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
    }
}



