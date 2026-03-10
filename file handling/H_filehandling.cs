//class H_filehandling
//{
//    public static void Main(string[] args)
//    {
//        H_filehandling obj = new H_filehandling();
//        obj.filestaticclass();
//        obj.fileinfoclass();
//    }

//    void filestaticclass()
//    {
//        Console.WriteLine("--------------File Static Class-------------------");

//        string file_path = "C:\\Users\\Asus\\Downloads\\dotnet\\stationary.txt";

//        // User input
//        Console.WriteLine("Enter Item Name:");
//        string item = Console.ReadLine();

//        Console.WriteLine("Enter Quantity:");
//        int qty = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Enter Price:");
//        double price = Convert.ToDouble(Console.ReadLine());

//        double total = qty * price;

//        string data = "\nItem: " + item +
//                      "\nQuantity: " + qty +
//                      "\nPrice: " + price +
//                      "\nTotal: " + total +
//                      "\n---------------------------";

        
//        File.AppendAllText(file_path, data);

//        if (File.Exists(file_path))
//        {
//            Console.WriteLine("Data saved successfully using File static class.");
//        }
//        else
//        {
//            Console.WriteLine("File not created.");
//        }

//        Console.WriteLine("Creation Time: " + File.GetCreationTime(file_path));
//    }

//    void fileinfoclass()
//    {
//        Console.WriteLine("\n----------File Info Class---------------------");

//        string file_dest = "C:\\Users\\Asus\\Downloads\\dotnet\\stationary.txt";

//        FileInfo fi = new FileInfo(file_dest);

//        if (fi.Exists)
//        {
//            Console.WriteLine("File Exists!");
//        }
//        else
//        {
//            Console.WriteLine("File does not exist!");
//        }

//        Console.WriteLine("Name: " + fi.Name);
//        Console.WriteLine("Full Name: " + fi.FullName);
//        Console.WriteLine("Creation Time: " + fi.CreationTime);
//        Console.WriteLine("Directory Name: " + fi.DirectoryName);
//        Console.WriteLine("File Size (bytes): " + fi.Length);
//    }
//}
