////Id
////degiganation
////salary
////year of experience
//class T_employee_binary
//{
//    private object str;

//    void writeemp_data()
//    {
//        string path = "C:\\Users\\Asus\\Downloads\\dotnet\\user.bin";
//        FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
//        BinaryWriter bw = new BinaryWriter(fs);

//        bw.Write(1);
//        bw.Write("Dhule");
//        bw.Write(20000);
//        bw.Write(2);
//        bw.Close();
//        bw.Close();
//    }
//    void reademp_data()
//    {
//        string path = "C:\\Users\\Asus\\Downloads\\dotnet\\user.bin";
//        FileStream fs2 = new FileStream(path, FileMode.Open);
//        BinaryReader br = new BinaryReader(fs2);

//        Console.Write("Enter id: ");
//        int id=int.Parse(br.ReadString());
//        Console.Write("Enter deg: ");
//        string deg = str.;
//        Console.Write("Enter salary: ");
//        int salary = int.Parse(br.ReadString());
//        Console.Write("Enter exp: ");
//        int exp = int.Parse(br.ReadString());

//        Console.WriteLine("id: " + id);
//        Console.WriteLine("deg: " + deg);
//        Console.WriteLine("salary: " + salary);
//        Console.WriteLine("exp: " + exp);
//        br.Close();
//        fs2.Close();
//    }
//    public static void Main(String[] args)
//    {
//        T_employee_binary ob = new T_employee_binary();
//        ob.writeemp_data();
//        ob.reademp_data();
//    }
//}

