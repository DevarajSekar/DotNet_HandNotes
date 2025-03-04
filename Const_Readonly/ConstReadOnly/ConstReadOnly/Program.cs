namespace ConstReadOnly
{
    //Youtube link - https://www.youtube.com/watch?v=vNPBWNNlDwM
    class Program
    {
        //To use it in static construtctor we have added static key word
        public const int cmToMts = 100; // Compile time constants -> Used to declare for values which are de-finite like sure shot value
        public static readonly double PI = 3.14; // Run time constants -> Used to declare for values from app settings

        static Program()
        {
            PI = 23.2323; // Readonly can be updated, modified at constructor level
        }

        static void Main(string[] args)
        {
            //cmToMts = 200;// Cant be changed after declaaration

            Console.WriteLine("Constant value = {0}", cmToMts);
            Console.WriteLine("Readonly value = {0}", PI);
        }
    }
}
 