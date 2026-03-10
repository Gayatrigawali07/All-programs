//class binaryfile_handling
//{
//    void write_data()
//    {
//        string path = "C:\\Users\\Asus\\Downloads\\dotnet\\user.bin";
//        FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
//        BinaryWriter bw = new BinaryWriter(fs);

//    }
//    void read_data()
//    {
//        string path = "C:\\Users\\Asus\\Downloads\\dotnet\\user.bin";
//        FileStream fs2 = new FileStream(path, FileMode.Open);
//        BinaryReader br = new BinaryReader(fs2);
//        int num = br.ReadInt32();
//        string str = br.ReadString();
//        double d = br.ReadDouble();
//        bool b = br.ReadBoolean();

//        Console.WriteLine("Interger: " + num);
//        Console.WriteLine("String: " + str);
//        Console.WriteLine("Double: " + d);
//        Console.WriteLine("Boolean: " + b);
//        br.Close();
//        fs2.Close();
//    }
//    public static void Main(String[] args)
//    {
//        binaryfile_handling ob = new binaryfile_handling();
//        ob.write_data();
//        ob.read_data();
//    }
//}



