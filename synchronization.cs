//class Synchronization
//{
//    static object o = new object();

//    public static void increment()
//    {
//        lock (o) // other thread will wait until first thread finishes execution
//        {
//            Console.WriteLine(Thread.CurrentThread.Name + " thread is executing");
//        }
//    }

//    public static void Main(string[] args)
//    {
//        Thread user1 = new Thread(increment);
//        Thread user2 = new Thread(increment);

//        user1.Name = "First user";
//        user2.Name = "Second user";

//        user1.Start();
//        user2.Start();
//    }
//}