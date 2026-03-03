//class Temperature
//{
//    // Rule 1: Data member should be private
//    // variable temperature value store karto
//    private double celsius;

//    // Setter method
//    // method temperature set karayla use hoto
//    public void setTemperature(double celsius)
//    {
//        // Validation check (valid temperature range)
//        if (celsius >= -50 && celsius <= 100)
//        {
//            // this.celsius refers to class variable
//            // right side celsius refers to method parameter
//            this.celsius = celsius;
//        }
//        else
//        {
//            // Invalid value asel tar message show hoto
//            Console.WriteLine("Invalid Temperature!");
//        }
//    }

//    // Getter method
//    // method private variable chi value return karto
//    public double getTemperature()
//    {
//        return this.celsius;
//    }

//    // Main class
//    class H_encapsulation
//    {
//        public static void Main(string[] args)
//        {
//            // Object create kela
//            Temperature obj = new Temperature();

//            // Setter method call karun value set keli
//            obj.setTemperature(30);

//            // Getter method call karun value print keli
//            Console.WriteLine("Current Temperature: " + obj.getTemperature() + "°C");
//        }
//    }
//}