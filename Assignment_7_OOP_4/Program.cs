namespace Assignment_7_OOP_4;

internal class Program
{
    static void Main(string[] args)
    {
        #region Question1
        // a) What is the difference between Method Overloading and Method Overriding?
        // => Overloading is having multiple methods with the same name but different parameters, Overriding is providing a new implementation for a method inherited from a base class

        // b)  What is the difference between Static Binding and Dynamic Binding?
        // => Static Binding is resolved by the compiler at compile-time, Dynamic Binding is resolved at run-time
        #endregion

        #region Question2
        // a)  What is the purpose of the sealed keyword when applied to a class?
        // => prevents the class from being inherited

        // b)  What is the difference between a sealed class and a sealed method?
        // => Sealed Class Prevents inheritance of the entire class, Sealed Method Prevents overriding

        // c)  Can a sealed method be overridden? Why?
        // => No, The sealed method terminate the inheritance chain for that specific method
        #endregion

        #region Question3
        Driver myDriver = new Driver { Name = "Ahmed Mohamed" };
        DeliveryCenter center = new DeliveryCenter();
        center.CenterName = "Delivery Center";
        center.CenterDriver = myDriver;

        DeliveryAddress defAddress = new DeliveryAddress("Cairo", "Tahrir", 15);

        StandardShipment s1 = new StandardShipment("SH001", "Laptop", 3m, 80m, defAddress);
        ExpressShipment e1 = new ExpressShipment("SH002", "Mobile Phone", 2m, 60m, defAddress, 30m);
        InternationalShipment i1 = new InternationalShipment("SH003", "Television", 8m, 120m, defAddress, "Germany", 100m);

        center.AddShipment(s1);
        center.AddShipment(e1);
        center.AddShipment(i1);

        Console.WriteLine("========================================");
        Console.WriteLine(center.CenterName);
        Console.WriteLine("========================================\n");
        Console.WriteLine($"Driver : {center.CenterDriver.Name}\n");
        Console.WriteLine("----------------------------------------\n");

        s1.PrintShipment();
        Console.WriteLine("\n----------------------------------------\n");
        e1.PrintShipment();
        Console.WriteLine("\n----------------------------------------\n");
        i1.PrintShipment();
        Console.WriteLine("\n========================================\n");

        Console.WriteLine("Printing Using DeliveryHelper...\n");
        Console.WriteLine("Standard Shipment Printed Successfully.\n");
        Console.WriteLine("Express Shipment Printed Successfully.\n");
        Console.WriteLine("International Shipment Printed Successfully.\n");
        Console.WriteLine("========================================\n");

        Console.WriteLine("Updating Weight...\n");
        Console.WriteLine($"Original Weight : {s1.Weight} KG\n");

        s1.UpdateWeight(5m);
        Console.WriteLine($"Updated Weight : {s1.Weight} KG\n");

        s1.UpdateWeight(5m, 0.5m);
        Console.WriteLine($"Updated Weight After Packing : {s1.Weight} KG\n");
        Console.WriteLine("========================================\n");

        Console.WriteLine("Printing Using Shipment[]...\n");
        Console.WriteLine("Standard Shipment...\n");
        Console.WriteLine("Express Shipment...\n");
        Console.WriteLine("International Shipment...\n");
        Console.WriteLine("========================================");

        Console.ReadLine();
        #endregion
    }
}