internal class Program
{
    private static void Main(string[] args) //acessando o args
    {
        Console.WriteLine("Argumentos");
        if(args.GetLength(0)>0){
            Console.Write(args.GetValue(0));
        }
    }
}