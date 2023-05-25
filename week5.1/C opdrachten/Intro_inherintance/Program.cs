/*
 Contents:
  - Base and derived (W05.1.C01)
  - Constructor ('base' keyword) (W05.1.C02)
  - Type checking ('is' keyword) (W05.1.C03)
  - virtual & override (W05.1.C04)
  - Multiple derived classes (W05.1.C05)
  - Derived further (W05.1.C06)
  - Overriding ToString() (W05.1.C07)
  - Safe/unsafe casting (W05.1.C08)

 Inheritance hierarchy:

                 Object
                   |
             +-----+-----+
             |           |
          Vehicle    USSEnterprise
             |
     +-------+-------+
     |               |
  GasCar        ElectricCar
     |
     |
   Truck

*/

public class Program
{
    public static void Main()
    {
        BaseAndDerived();
        //BaseKeyword();
        //TypeChecking();
        //VirtualAndOverride();
        //MultipleDerivedClasses();
        //DerivedFurther();
        //Overriding_ToString();
        //SafeUnsafeCasting();
    }

    public static void BaseAndDerived()
    {
        Console.WriteLine("=== Base & derived classes ===");

        Vehicle newHollandTractor = new("New Holland", "T7.270");
        Console.WriteLine("Tractor mileage: " + newHollandTractor.Mileage);
        newHollandTractor.Drive();
        Console.WriteLine("Tractor mileage: " + newHollandTractor.Mileage);

        Console.WriteLine("\nThe derived class 'GasCar' has access to its base class' members:");
        GasCar porsche911 = new("Porsche", "911 GT3");
        Console.WriteLine("Porsche mileage: " + porsche911.Mileage);
        porsche911.Drive();
        Console.WriteLine("Porsche mileage: " + porsche911.Mileage);
        Console.WriteLine();
    }

    public static void BaseKeyword()
    {
        Console.WriteLine("=== 'base' keyword ===");
        
        Console.WriteLine("When creating an instance of a derived class, " +
            "the base constructor needs to be called as well:\n");
        Console.WriteLine("public GasCar(string make, string model)" +
            " : base(make, model)\r\n{\r\n    HasNewSparkPlugs = true;\r\n}");
        Console.WriteLine();
    }

    public static void TypeChecking()
    {
        Console.WriteLine("=== Type checking ('is' keyword) ===");

        List<Vehicle> vehicles = new()
        {
            new Vehicle("New Holland", "T7.270"),
            new GasCar("Porsche", "911 GT3"),
        };

        foreach (Vehicle vehicle in vehicles)
        {
            Console.WriteLine($"The {vehicle.Make} {vehicle.Model}:");
            Console.WriteLine(" - has fresh tires: " + vehicle.HasFreshTires);

            if (vehicle is GasCar)
            {
                Console.WriteLine(" - is a GasCar");
                Console.WriteLine("   * has new spark plugs: "
                    + ((GasCar)vehicle).HasNewSparkPlugs);
            }

            Console.WriteLine();
        }
    }

    public static void VirtualAndOverride()
    {
        Console.WriteLine("=== virtual & override ===");
        Console.WriteLine("Virtual methods can overridden by derived class.\n");

        List<Vehicle> vehicles = new()
        {
            new Vehicle("New Holland", "T7.270"),
            new GasCar("Porsche", "911 GT3"),
        };

        foreach (Vehicle vehicle in vehicles)
        {
            Console.WriteLine($"Driving the {vehicle.Make} {vehicle.Model}...");
            vehicle.Drive(5);
            Console.WriteLine("Has fresh tires: " + vehicle.HasFreshTires);

            if (vehicle is GasCar)
                Console.WriteLine("Has new spark plugs: " + ((GasCar)vehicle).HasNewSparkPlugs);

            Console.WriteLine("\nPerforming maintenance...");
            vehicle.PerformMaintenance();
            Console.WriteLine("Has fresh tires: " + vehicle.HasFreshTires);

            if (vehicle is GasCar)
                Console.WriteLine("Has new spark plugs: " + ((GasCar)vehicle).HasNewSparkPlugs);

            Console.WriteLine();
        }
    }

    public static void MultipleDerivedClasses()
    {
        Console.WriteLine("=== Multiple derived classes ===");
        Console.WriteLine("A base class can have any number of derived classes:");

        List<Vehicle> vehicles = new()
        {
            new GasCar("Porsche", "911 GT3"),
            new ElectricCar("Tesla", "Model X"),
        };

        foreach (var vehicle in vehicles)
        {
            Console.WriteLine($"The {vehicle.Make} {vehicle.Model}:");
            Console.WriteLine(" - has fresh tires: " + vehicle.HasFreshTires);
            //We can create an object immediately!
            //This is called pattern matching type casting
            //(You don't need to remember this.)
            if (vehicle is GasCar gasCar) //Pattern matching type cast
                Console.WriteLine(" - has new spark plugs: "
                    + gasCar.HasNewSparkPlugs);
            if (vehicle is ElectricCar electricCar)
                Console.WriteLine(" - has a battery capacity of: "
                    + electricCar.BatteryCapacity);
            Console.WriteLine();
        }
    }

    public static void DerivedFurther()
    {
        Console.WriteLine("=== Derived and derived further ===");
        Console.WriteLine("A derived class can have its own derived classes:");
        Console.WriteLine();

        List<GasCar> gasCars = new()
        {
            new GasCar("Porsche", "911 GT3"),
            new Truck("DAF", "XF", 52),
        };

        foreach (var gasCar in gasCars)
        {
            Console.WriteLine($"The {gasCar.Make} {gasCar.Model}:");
            Console.WriteLine(" - has fresh tires: " + gasCar.HasFreshTires);
            Console.WriteLine(" - has new spark plugs: " + gasCar.HasNewSparkPlugs);
            if (gasCar is Truck truck)
                Console.WriteLine(" - has a cargo space capacity (m3) of: "
                    + truck.CargoCapacity);
            
            Console.WriteLine();
        }
    }

    public static void Overriding_ToString()
    {
        Console.WriteLine("=== Overriding ToString() ===");
        Console.WriteLine("Each class is ultimately derived from the Object class.");
        Console.WriteLine("Hence classes can override the Object class' virtual ToString() method.\n");

        List<Vehicle> vehicles = new()
        {
            new Vehicle("New Holland", "T7.270"),
            new GasCar("Porsche", "911 GT3"),
            new Truck("DAF", "XF", 52),
            new ElectricCar("Tesla", "Model X"),
        };

        foreach (var vehicle in vehicles)
        {
            //Printing an object automatically call ToString()
            Console.WriteLine(vehicle);
        }

        Console.WriteLine();
    }

    public static void SafeUnsafeCasting()
    {
        Console.WriteLine("=== Safe vs unsafe casting ===");
        Console.WriteLine("Casting can be done in two ways.");

        List<Object> objects = new()
        {
            new Truck("DAF", "XF", 52),
            new USSEnterprise()
        };

        Console.WriteLine("\nUnsafe casting can cause an InvalidCastException");
        //NOTE: exception handling is NOT the correct approach.
        //It is done here merely for demonstration purposes.
        foreach (var obj in objects)
        {
            try
            {
                Console.WriteLine($"Driving the Vehicle...");
                ((Vehicle)obj).Drive();
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine($"{obj} is not a Vehicle.");
                Console.WriteLine(ex); //ToString is automatically called here also
                Console.WriteLine(ex.Message);
            }
        }

        foreach (var obj in objects)
        {
            Console.WriteLine("\nSafe casting can result in a 'null'");
            Vehicle vehicle = obj as Vehicle;
            if (vehicle != null)
            {
                Console.WriteLine($"Driving the Vehicle...");
                vehicle.Drive();
            }
            else
            {
                Console.WriteLine($"{obj} is not a Vehicle");
            }

            Console.WriteLine("Alternatively, you can use the null-coalescing operator:");
            Console.WriteLine($"Driving the Vehicle...");
            vehicle?.Drive();
        }
    }
}