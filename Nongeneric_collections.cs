//using System;
//using System.Collections;
//using System.Threading;   

//class Nongeneric_collections
//{
//    void ng_collection()
//    {
//        ArrayList al = new ArrayList(); //[101,"Payal",76.5]

//        al.Add(101);
//        al.Add("payal");
//        al.Add(76.5);

//        foreach (object studentdata in al)
//        {
//            Console.WriteLine(studentdata);
//            Thread.Sleep(1000);
//        }

//        Console.WriteLine("contains 101?? " + al.Contains(101));
//        Console.WriteLine("count: " + al.Count);
//        Console.WriteLine("index of payal: " + al.IndexOf("payal"));

//        al.Insert(0, 'A');

//        for (int i = 0; i < al.Count; i++)
//        {
//            Console.WriteLine(al[i]);
//            Thread.Sleep(1000);
//        }

//        // remove, removeat, lastindexof, reverse
//        // removerange, add range, insertrange, toarray, tostring

//        al.Clear(); // remove all objects
//    }

//    public static void Main(string[] args)
//    {
//        Nongeneric_collections al = new Nongeneric_collections();
//        al.ng_collection();
//    }
//}