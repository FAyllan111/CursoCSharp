// Type Casting 


class Aula11{
    static void Main(){
        int n1 = 10;
        float n2 = n1; // conversao implicita

        Console.WriteLine(n2);

        //float para int -> cast implicito

        float n3 = 5.6f;
        int n4 = (int)n3; //type casting

        Console.WriteLine(n4);

        int vint = 19;
        short vshort = (short)vint; // 

        Console.WriteLine(vshort);


    }
}