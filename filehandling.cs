//class filehandling
//{
//    public static void Main(string[] args)
//    {
//        filehandling obj = new filehandling();
//        obj.filestaticclass();
//        obj.fileinfoclass();

//    }
//    void fileinfoclass()
//    {
//        Console.WriteLine("----------File info class---------------------");
//        string file_dest = "C:\\Users\\Asus\\Downloads\\dotnet\\myfile.txt";
//        FileInfo fi = new FileInfo(file_dest);
//        fi.Create();
//        //if file is exist then display message file created successfully

//        if (fi.Exists)
//        {
//            fi.Delete();
//            if (fi.Exists)
//            {
//                Console.WriteLine("file is not deleted");
//            }
//            else
//            {
//                Console.WriteLine("file is deleted successfully");
//            }
//        }
//        else
//        {
//            Console.WriteLine("file is not exist!");
//        }

//        Console.WriteLine("Name:" + fi.Name);
//        Console.WriteLine("FullName:" + fi.FullName);
//        Console.WriteLine("creationtime:" + fi.CreationTime);
//        Console.WriteLine("directory name:" + fi.DirectoryName);
//    }

//    void filestaticclass()
//    {
//        Console.WriteLine("--------------File static class-------------------");
//        string file_path = "C:\\Users\\Asus\\Downloads\\dotnet\\holi.txt";
//        File.Create(file_path);
//        //if file is exist then display message file created successfully
//        if (File.Exists(file_path))
//        {
//            Console.WriteLine("File created successfully");
//        }
//        else
//        {
//            Console.WriteLine("File is not created");
//        }
//        Console.WriteLine("creation time: " + File.GetCreationTime(file_path));
//    }
//}
