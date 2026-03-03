//using System;

//class H_AllInOne
//{
//    // Instance variable
//    int instanceVar = 10;

//    // Static variable
//    static int staticVar = 20;

//    // Default constructor
//    public H_AllInOne()
//    {
//        Console.WriteLine("Default Constructor Called!");
//    }

//    // Parameterized constructor
//    public H_AllInOne(int x)
//    {
//        instanceVar = x;
//        Console.WriteLine("Parameterized Constructor Called! instanceVar = " + instanceVar);
//    }

//    // Method without return and without parameters
//    public void DisplayMessage()
//    {
//        Console.WriteLine("Hello from DisplayMessage Method!");
//    }

//    // Method with return and with parameters
//    public int AddNumbers(int a, int b)
//    {
//        return a + b;
//    }

//    // Method without return but with parameters
//    public void MultiplyNumbers(int a, int b)
//    {
//        Console.WriteLine("Multiplication: " + (a * b));
//    }

//    // Method with return but without parameters
//    public string GetGreeting()
//    {
//        return "Welcome to C# Complete Example!";
//    }

//    static void Main()
//    {
//        // Creating objects for constructors
//        H_AllInOne obj1 = new H_AllInOne();   // Default constructor
//        H_AllInOne obj2 = new H_AllInOne(50);  // Parameterized constructor

//        Console.WriteLine("\n--- Variables ---");
//        int localVar = 100; // Local variable
//        Console.WriteLine("Local Variable: " + localVar);
//        Console.WriteLine("Instance Variable: " + obj2.instanceVar);
//        Console.WriteLine("Static Variable: " + H_AllInOne.staticVar);

//        Console.WriteLine("\n--- Methods ---");
//        obj1.DisplayMessage();
//        Console.WriteLine("Addition Result: " + obj1.AddNumbers(5, 10));
//        obj1.MultiplyNumbers(4, 6);
//        Console.WriteLine(obj1.GetGreeting());

//        Console.WriteLine("\n--- Loops ---");

//        // For loop
//        Console.Write("For Loop: ");
//        for (int i = 1; i <= 5; i++)
//        {
//            Console.Write(i + " ");
//        }
//        Console.WriteLine();

//        // While loop
//        Console.Write("While Loop: ");
//        int j = 1;
//        while (j <= 5)
//        {
//            Console.Write(j + " ");
//            j++;
//        }
//        Console.WriteLine();

//        // Do-While loop
//        Console.Write("Do-While Loop: ");
//        int k = 1;
//        do
//        {
//            Console.Write(k + " ");
//            k++;
//        } while (k <= 5);
//        Console.WriteLine();

//        // Foreach loop
//        Console.Write("Foreach Loop: ");
//        int[] numbers = { 1, 2, 3, 4, 5 };
//        foreach (int num in numbers)
//        {
//            Console.Write(num + " ");
//        }
//        Console.WriteLine();

//        Console.WriteLine("\n--- Data Types ---");
//        int intVar = 10;
//        float floatVar = 5.5f;
//        double doubleVar = 20.55;
//        char charVar = 'A';
//        string strVar = "C# Example Program";
//        bool boolVar = true;

//        Console.WriteLine("Integer: " + intVar);
//        Console.WriteLine("Float: " + floatVar);
//        Console.WriteLine("Double: " + doubleVar);
//        Console.WriteLine("Char: " + charVar);
//        Console.WriteLine("String: " + strVar);
//        Console.WriteLine("Boolean: " + boolVar);
//    }
//}
