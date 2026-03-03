class H_FH_Registrationfrom
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Program started!");

        H_FH_Registrationfrom obj = new H_FH_Registrationfrom();
        obj.RegisterUser();
        obj.DisplayFileInfo();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    public void RegisterUser()
    {
        Console.WriteLine("----------User Registration Form------------------");

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Email: ");
        string email = Console.ReadLine();

        Console.Write("Enter Mobile Number: ");
        string mobile = Console.ReadLine();

        Console.Write("Enter Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Password: ");
        string password = Console.ReadLine();

        // Simple path to avoid folder issues
        string file_path = "registration.txt";

        string data = "\nName: " + name +
                      "\nEmail: " + email +
                      "\nMobile: " + mobile +
                      "\nAge: " + age +
                      "\nPassword: " + password +
                      "\n-------------------------------";

        File.AppendAllText(file_path, data);

        if (File.Exists(file_path))
            Console.WriteLine("Registration Data Saved Successfully!");
        else
            Console.WriteLine("Error: File not created!");

        Console.WriteLine("File Location: " + Path.GetFullPath(file_path));
    }

    public void DisplayFileInfo()
    {
        Console.WriteLine("\n----------File Info------------------");

        string file_path = "registration.txt";
        FileInfo fi = new FileInfo(file_path);

        if (fi.Exists)
        {
            Console.WriteLine("File Name: " + fi.Name);
            Console.WriteLine("Full Path: " + fi.FullName);
            Console.WriteLine("Creation Time: " + fi.CreationTime);
            Console.WriteLine("Directory: " + fi.DirectoryName);
            Console.WriteLine("File Size (bytes): " + fi.Length);
        }
        else
        {
            Console.WriteLine("File does not exist!");
        }
    }
}