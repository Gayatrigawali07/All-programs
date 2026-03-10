////Incrementation operations with 3 threads using synchronisation
//class H_synchronizations
//{
//    static int count = 0;
//    static object obj = new object();

//    public static void Add()
//    {
//        lock (obj)
//        {
//            for (int i = 1; i <= 3; i++)
//            {
//                count++;
//                Console.WriteLine(Thread.CurrentThread.Name + " Count = " + count);
//            }
//        }
//    }

//    public static void Main(string[] args)
//    {
//        Thread t1 = new Thread(Add);
//        Thread t2 = new Thread(Add);
//        Thread t3 = new Thread(Add);

//        t1.Name = "Thread1";
//        t2.Name = "Thread2";
//        t3.Name = "Thread3";

//        t1.Start();
//        t2.Start();
//        t3.Start();
//    }
//}