////Class that contains the program
//class H_StudentNames
//{
//   // Entry point of the program
//    public static void Main(String[] args)
//    {
//        //Console.ReadLine() → Takes input from the user
//        Console.Write("How many students do you want to enter? : ");
//        //int.Parse() → Converts string input into integer
//        int size = int.Parse(Console.ReadLine());

//        //string[] students → Array to store student names
//        string[] students = new string[size];

//        //for loop → Used to take multiple student names
//        for (int i = 0; i < size; i++)
//        {
//            Console.Write("Enter the student name " + (i + 1) + " : ");
//            //students[i] = Console.ReadLine(); → Stores name in the array
//            students[i] = Console.ReadLine();
//        }

//        Console.WriteLine("\nStudent Names are:");
//        //Second for loop → Displays all student names
//        for (int i = 0; i < size; i++)
//        {
//            Console.WriteLine((i + 1) + ". " + students[i]);
//        }
//    }
//}
