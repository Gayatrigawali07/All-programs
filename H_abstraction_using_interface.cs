////Online Exam System
//abstract class OnlineExam   // Parent Class
//{
//    public abstract void StartExam();
//    public abstract void SubmitExam();

//    public void Rules()
//    {
//        Console.WriteLine("Follow exam rules strictly.");
//    }
//}

//class DotNetExam : OnlineExam   // Child Class
//{
//    public override void StartExam()
//    {
//        Console.WriteLine("DotNet Exam Started");
//    }

//    public override void SubmitExam()
//    {
//        Console.WriteLine("DotNet Exam Submitted");
//    }
//}

//class H_abstraction_using_interface
//{
//    public static void Main(string[] args)
//    {
//        DotNetExam obj = new DotNetExam();
//        obj.Rules();
//        obj.StartExam();
//        obj.SubmitExam();
//    }
//}