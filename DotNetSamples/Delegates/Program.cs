using System.Runtime.CompilerServices;

public class Delegates
{
    //Creating a delegate - Basic delegates
    public delegate void MyDelegate(string textitem);

    public delegate void MyASYNCDelegate(string textitem);
    public static void Main(string[] args)
    {
        //Instantiating the delegate and assigning which method to be called for my delegate,
        //this method should match my delegate with method parameter and return type of the method
        MyDelegate myDelegate = MethodForMyDelegate;
        myDelegate("Sending and Loading my Delegate string");

        Console.ReadKey();

        MyASYNCDelegate myasyncDelegate = MethodForMyDelegate;
        ASYNCstyleDelegate(4, 5, myDelegate);
        Console.ReadKey();
    }

    public static void MethodForMyDelegate(string stringItem)
    {
        Console.WriteLine(stringItem);
    }

    public static void ASYNCstyleDelegate(int x, int y, MyDelegate myDelegate)
    {
        myDelegate("The total is X + Y = " + (x + y).ToString() + " sample for passing delegate into method");
    }
}