//class properties_thread
//{
//    static void display()
//    {
//        Console.WriteLine("both thread is executing");
//        Console.WriteLine("Name of the thread-"+Thread.CurrentThread.Name);
//        Console.WriteLine("Id of the thread-"+Thread.CurrentThread.ManagedThreadId);
//    }

//public static void Main(string[] args)
//    {
//        Thread t1 = new Thread(displayname);
//        Console.WriteLine(t1.ThreadState);
//        t1.Name = "first thread";
//        t1.Start();
//        Console.WriteLine(t1.ThreadState);
//        t1.Priority = ThreadPriority.Highest;
//        Console.WriteLine("first thread priority: " + t1.Priority);

//        Console.WriteLine("-------------------------------");
//        Thread t2 = new Thread(displayname);
//        t2.Name = "second thread";
//        t2.Start();
//        t2.Priority = ThreadPriority.Lowest;
//        Console.WriteLine("second thread priority: " + t2.Priority);
//        Console.WriteLine("thread 1 is alive???" + t1.IsAlive);
//        Console.WriteLine("thread 2 is alive???" + t2.IsAlive);

//    }

//    private static void displayname(object? obj)
//    {
//        throw new NotImplementedException();
//    }
//}

