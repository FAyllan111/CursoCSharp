// Condicional if 

using System.Xml.Schema;

class Aula12{
    static void Main(){
        // se (exressa logica = verdadeira ){faz a condição dentro do bloco} falso sai do i
        // < , > , >= ,<= , == ,!= 

        /*  Exemplo inserindo apenas uma nota

         int nota =0 ;
         string resultado = "Reprovado";

         Console.Write("Digite sua nota:");
         nota = int.Parse(Console.ReadLine());

         if(nota >= 60)
         {
             resultado = "Aprovado";

         }

         Console.WriteLine(resultado);
         */

        int n1, n2, n3, n4;

        string resultado = "Reprovado";

        Console.Write("Digite a nota 1:");
        n1 = int.Parse(Console.ReadLine());
        Console.Write("Digite a nota 2:");
        n2 = int.Parse(Console.ReadLine());
        Console.Write("Digite a nota 3:");
        n3 = int.Parse(Console.ReadLine());
        Console.Write("Digite a nota 4:");
        n4 = int.Parse(Console.ReadLine());

        double media = (n1 + n2 + n3 + n4) / 4;

        if (media >= 6.0){

            resultado = "Aprovado";
        }

        Console.WriteLine(resultado + " com a média : " + media);

    }
}