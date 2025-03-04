namespace Val_Ref
{
    class Program() ////Reference type - will be stored in Heap memory
    {

        //#sample explanation code

        //Even the intMemeber and BoolMmeber are value type, but it is part of class object (reference type), it will be considered as reference type values
        public int intMember = 10; //value type - will be stored in stack memory
        public bool boolMember = true; ////value type - will be stored in stack memory

        public void SampleMethod(int X) //Here X will be stored in the Stack and it is considered to be Value type
        {

        }

        public int[] arr = { 0, 1, 2, 3, 4 };//Even int is value type - Arrays will be Ref type by defauls and it ll be stored in Heap memory

        //#end region

        static void Main(string[] args)
        {
            User user1 = new User() { };
            User user2 = user1;
            

            Console.WriteLine("User 1 age = {0}", user1.age);
            Console.WriteLine("User 2 age = {0}", user2.age);

            user2.age = 45; //Both user 1 and 2 will be updated, since it is a reference type
            Console.WriteLine("User 1 age = {0}", user1.age);
            Console.WriteLine("User 2 age = {0}", user2.age);

            user1.age = 55; ////Both user 1 and 2 will be updated, since it is a reference type
            Console.WriteLine("User 1 age = {0}", user1.age);
            Console.WriteLine("User 2 age = {0}", user2.age);
        }
    }

    public class User
    {
        public int age = 32;
    }
}