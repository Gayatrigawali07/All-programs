//class Multi
//{
//    //entry point of the program
//    public static void Main(String[] args)
//    {
//        // Jagged array: 4 departments
//        //jagged array (array of arrays) storing employees of each department.
//        string[][] employees =
//        {
//            new string[] { "Amit", "Sagar" },           // Development
//            new string[] { "Priya" },                   // Testing
//            new string[] { "Vijay", "Anil", "Sneha" }, // Operations
//            new string[] { "Rahul", "Pooja" }          // Management
//        };
//        //string[] deptNames = array storing department names.
//        string[] deptNames = { "Development", "Testing", "Operations", "Management" };

//        //Outer loop (i) = goes through each department.
//        for (int i = 0; i < employees.Length; i++)
//        {
//            Console.Write(deptNames[i] + " : ");

//            //Inner loop (j) = goes through each employee in that department.
//            for (int j = 0; j < employees[i].Length; j++)
//                Console.Write(employees[i][j] + "  ");

//            Console.WriteLine();
//        }
//    }
//}
