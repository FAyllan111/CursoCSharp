//FORMATACAO NA SAIDA DO CONSOLE

class Aula06{

    static void Main(){
        int n1, n2, n3;

        n1 = 54;
        n2 = 009;
        n3 = 001992;

        Console.Write(n1 + "," + n2 + "," + n3);// concatenando com +
        Console.Write("n1 = {0}, n2= {1} , n3={2}",n1,n2,n3);// usando indices caracteres de escapes \n \t , caracteres de formatacao


        double valorCompra = 69.8;
        double valorVenda;
        double lucro = 0.15;
        string produto = "Coxinha";

        valorVenda = valorCompra + (valorCompra * lucro);

        Console.WriteLine("Produto...........:{0,15}",produto);
        Console.WriteLine("Val. Compra...........:{0,15:c}",valorCompra);// formato de saida :c -> monetario
        Console.WriteLine("Val. Venda...........:{0,15:c}",valorVenda);
        Console.WriteLine("Lucro...........:{0,15:p}",lucro);// porcentagem

    }
}