//Events sample

//namespace sampleApp
//{
//    public delegate string MyEventDelegate(string name);
//    public class EventClass
//    {
//        public event MyEventDelegate MyEvent;

//        public EventClass()
//        {
//            MyEvent += new MyEventDelegate(CallEventMethod);
//        }

//        private string CallEventMethod(string name)
//        {
//            return "My name is: " + name;
//        }


//        public static void Main(string[] args)
//        {
//            EventClass eventClass = new EventClass();
//            string result = eventClass.MyEvent("Devaraj");
//            Console.WriteLine(result);
//            Console.ReadLine();
//            string result2 = eventClass.MyEvent("Jayanthi");
//            Console.WriteLine(result2);
//        }
//    }
//}


//Events using Delegates
namespace sampleApp2
{
    public delegate void Notify(string message);
    class User
    {
        public event Notify UserLoggedIn;

        public void Login(string username)
        {
            Console.WriteLine($"{username} logged in successfully.");
            UserLoggedIn?.Invoke($"Notification: {username} has logged in.");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            User user = new User();
            user.UserLoggedIn += User_UserLoggedIn;
            user.Login("dev");
        }

        private static void User_UserLoggedIn(string message)
        {
           Console.WriteLine (message);
        }
    }
}


        