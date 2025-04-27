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

        ////////SAMPLE 1
        //MyDelegate myDelegate = MethodForMyDelegate;
        //myDelegate("Sending and Loading my Delegate string");

        //Console.ReadKey();

        //MyASYNCDelegate myasyncDelegate = MethodForMyDelegate;
        //ASYNCstyleDelegate(4, 5, myDelegate);
        //Console.ReadKey();
        //////////////
        ///

        //////////SAMPLE 2

        SenderDelegateSample senderDelegateSample = new SenderDelegateSample();
        senderDelegateSample.Sender = Receiver;

        //senderDelegateSample.SomeHugProcess();

        Thread thread = new Thread(new ThreadStart(senderDelegateSample.SomeHugProcess));
        thread.Start();

        Console.WriteLine("Main thread");
        Console.ReadLine();

        ////////////////
    }

    /// <summary>
    /// Sample 2
    /// </summary>
    /// <param name="x"></param>
    public static void Receiver(int x)
    {
        Console.WriteLine("Received sender value " + x.ToString());
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

public class SenderDelegateSample
{
    public delegate void SenderDelegate(int i);//Delegate declaration
    public SenderDelegate Sender = null;//Delegate initialization

    public void SomeHugProcess()
    {
        for (int i = 0; i < 3; i++)
        {
            Thread.Sleep(5000);
            Sender(i);//Delegate assigning
        }
    }
}