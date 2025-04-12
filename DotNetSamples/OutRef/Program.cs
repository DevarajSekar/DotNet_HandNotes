public class Program
{
    public static void Main(string[] args)
    {
        // Declaring variables
        // without assigning values
        int a;
        int b;
        int c;

        ///Out sample
        ///// Pass multiple variable to 
        // the method using out keyword
        Sum(out a, out b, out c);
        Console.WriteLine("a = {0}", a);
        Console.WriteLine("b = {0}", b);
        Console.WriteLine("Out sample : a + b = {0}", c);
        ////


        ////Ref sample
        int d = 400;
        int e = 750;
        int f = 0;
        Subtract(ref d, ref e, ref f);
        Console.WriteLine("d = {0}", d);
        Console.WriteLine("e = {0}", e);
        Console.WriteLine("Ref sample : e - d = {0}", f);
        ////
    }

    private static void Subtract(ref int d, ref int e, ref int f)
    {
        f = e - d;
    }

    private static void Sum(out int a, out int b, out int c)
    {
        a = 100;
        b = 200;
        c = a + b;
    }
}