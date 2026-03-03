////uber ride

//// Abstract class: Parent class for ride booking
//abstract class RideBooking   // Parent Class
//{
//    public abstract void CalculateFare(double distance);    //Child must define fare calculation
//    public abstract void AssignDriver();    //Child must define driver assignment

//    public void BookingMessage()
//    {
//        Console.WriteLine("Your ride request is being processed...");   // Common message
//    }
//}

//// BikeRide class inherits RideBooking
//class BikeRide : RideBooking   // Child Class
//{
//    public override void CalculateFare(double distance)
//    {
//        double fare = distance * 8;   // 8 Rs per km
//        Console.WriteLine("Bike Ride Fare: Rs." + fare);
//    }

//    public override void AssignDriver()
//    {
//        Console.WriteLine("Bike driver assigned successfully.");
//    }
//}

//class H_abstraction_using_abstractclass
//{
//    public static void Main(string[] args)
//    {
//        BikeRide obj = new BikeRide();
//        obj.BookingMessage();
//        obj.CalculateFare(12);// Calculate fare for 12 km
//        obj.AssignDriver();
//    }
//}

