//class T_properties_thread
//    {
//        static void display()
//        {
//            Console.WriteLine("both thread is executing");
//            Console.WriteLine("Name of the thread-" + Thread.CurrentThread.Name);
//            Console.WriteLine("Id of the thread-" + Thread.CurrentThread.ManagedThreadId);
//        }

//        public static void Main(string[] args)
//        {
//            Thread Anita = new Thread(displayname);
//            Console.WriteLine(Anita.ThreadState);
//            Anita.Name = "first thread";
//            Anita.Start();
//            Console.WriteLine(Anita.ThreadState);
//            Anita.Priority = ThreadPriority.Highest;
//            Console.WriteLine("Going to market Anita : " + Anita.Priority);

//            Console.WriteLine("-------------------------------------------");
//            Thread Kavita = new Thread(displayname);
//            Kavita.Name = "second thread";
//            Kavita.Start();
//            Kavita.Priority = ThreadPriority.Lowest;
//            Console.WriteLine("Going to market kavita: " + Kavita.Priority);
//            Console.WriteLine("thread 1 is alive???" + Anita.IsAlive);
//            Console.WriteLine("thread 2 is alive???" + Anita.IsAlive);

//        }

//        private static void displayname(object? obj)
//        {
//            throw new NotImplementedException();

//        }
//    }

