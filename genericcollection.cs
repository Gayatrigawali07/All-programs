//using System;
//using System.Collections.Generic;

//class genericcollection
//{
//    public void generic()
//    {
//        List<int> numbers = new List<int>();

//        //Initial elements
//        numbers.Add(89);
//        numbers.Add(345);
//        numbers.Add(1279);

//        Console.WriteLine("Original List:");
//        foreach (int no in numbers)
//        {
//            Console.WriteLine(no);
//        }

//        //1. Remove 345 using index.
//        numbers.RemoveAt(1);

//        //2.Add 208 at index 0.
//        numbers.Insert(0, 208);

//        //3. Check whether 87 object is present in the collection.
//        if (numbers.Contains(87))
//        {
//            Console.WriteLine("87 is present in collection");
//        }
//        else
//        {
//            Console.WriteLine("87 is not present in collection");
//        }

//        //4.print count of objects
//        Console.WriteLine("Total elements in collection: " + numbers.Count);

//        //5.Reverse the collection
//        numbers.Reverse();

//        Console.WriteLine("Final List after operations:");
//        foreach (int no in numbers)
//        {
//            Console.WriteLine(no);
//        }
//    }

//    public static void Main(string[] args)
//    {
//        genericcollection ob = new genericcollection();
//        ob.generic();
//    }
//}
////1.remove 345 using index.
////2.remove add 208 integer at index 0.
////3.check wheater 87 object present in the collection.
////4. print the count of all objects in collection.
////5. reverse the collection

////1. check character arraylist contains character 'z' without contains method.