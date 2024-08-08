namespace _2._3_AirplaneApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Airplane airplane = new Airplane();
            Airplane newAirplane = airplane.GenerateAirplane("Airbus 750");
            Console.WriteLine("======= Pre Depurture Checks =======");
            Console.WriteLine();
            Console.WriteLine("===== Airplane Info =====");
            Console.WriteLine("Airplane Modal: " + newAirplane.modal);
            Console.WriteLine("Fuel Consumption: " + newAirplane.fuelConsumption + " ltr/km");
            Console.WriteLine("Passangers Capacity: " + newAirplane.passangerCapacity);
            Console.WriteLine("Distance Fly Range: " + newAirplane.range);
            Console.WriteLine("Fuel Tank Capacity: " + newAirplane.fuelCapacity);
            Console.WriteLine();
            Console.WriteLine("===== Trip Info =====");
            Console.WriteLine("Current Fuel Level: " + newAirplane.fuelLevel + " ltr");
            Console.WriteLine("Distance To Travel: " + newAirplane.distance + " kms");
            Console.WriteLine("Refuel Requirement: " + newAirplane.reFuelRequirement + " ltr");
            Console.WriteLine("Passangers Travelling: " + (newAirplane.passangerTravelling));
            Console.WriteLine();
            Console.WriteLine("===== Passaangers Info =====");
            foreach (RandomPerson passanger in newAirplane.passangers)
            {
                Console.WriteLine((passanger.GetId()+1) + " " + passanger.GetName() + ", Gender: " + passanger.GetGender() + ", Age: " + passanger.GetAge());
            }
            Console.WriteLine();
            Console.WriteLine("======= After Travel Checks =======");
            Console.WriteLine("Fuel Balance After Travel: " + newAirplane.fuelBalance + " ltr");

        }
    }
}


