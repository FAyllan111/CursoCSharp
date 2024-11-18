// if aninhado,if´s dentro de if´s
class Aula14{
    static void Main(){
                        int n1, n2, n3, n4;

        string resultado;

        Console.Write("Digite a nota 1:");
        n1 = int.Parse(Console.ReadLine());
        Console.Write("Digite a nota 2:");
        n2 = int.Parse(Console.ReadLine());
        Console.Write("Digite a nota 3:");
        n3 = int.Parse(Console.ReadLine());
        Console.Write("Digite a nota 4:");
        n4 = int.Parse(Console.ReadLine());

        double media = (n1 + n2 + n3 + n4) / 4;

        // media >= 6-> aprovado
        //media <= 5 || >= 4 -> recuperacao
        // media <4 -> reprovado

        /*
            //if e else
        if (media > 10)
        {
            Console.WriteLine(" Notas inválidas!! A média doi maior que 10, sendo inválida!");
        }
        else
        {
            //if aninhado
            if (media >= 6.0)
            {

                resultado = "Aprovado";
            }
            else if (media < 6)
            {
                resultado = "Recuperação";
            }
            else
            {
                resultado = "reprovado";
            }

            Console.WriteLine(resultado + " com a média : " + media);
        }
        */

        if (media >= 6){
            if (media >= 9){
                resultado = "Aprovado com louvor";
            }else{
                resultado = "Aprovado";
            }
        }else{
            if(media > 4){
                resultado = "Recuperação";
            }else{
                resultado = "Reprovado";
            }
        }

        Console.WriteLine(resultado + " com a média : " + media);
    }
}