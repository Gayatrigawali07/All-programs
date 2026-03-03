
//class startask
//{
//    // 1. Default Constructor
//    startask()
//    {
//        Console.WriteLine("Default Constructor Pattern:");

//        for (int i = 1; i <= 4; i++)
//        {
//            for (int j = 1; j <= 4; j++)
//            {
//                Console.Write("* ");
//            }
//            Console.WriteLine();
//        }
//    }

//    // 2. Parameterized Constructor
//    startask(int num)
//    {
//        Console.WriteLine("Parameterized Constructor Pattern:");

//        for (int i = 1; i <= 4; i++)
//        {
//            for (int j = 1; j <= 4; j++)
//            {
//                if (i == 1 || i == 4 || j == 1 || j == 4)
//                    Console.Write("* ");
//                else
//                    Console.Write("  ");
//            }
//            Console.WriteLine();
//        }
//    }

//    public static void Main(string[] args)
//    {
//        startask f = new startask();      // Default constructor
//        startask f2 = new startask(20);   // Parameterized constructor
//    }
//}
