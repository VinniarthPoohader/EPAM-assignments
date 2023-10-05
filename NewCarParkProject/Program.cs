using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using NewCarParkProject;

internal class Program
{
    private static void Main(string[] args)
    {
        var vechicles = new List<Vehicle>()
        {
            new Car()
            {
                Engine = new Engine()
                {
                    HP = 150,
                    Capacity = 1000,
                    EngineNumber = "432575247",
                    EngineType = "V"
                },
                Chassis = new Chassis()
                {
                    chassisnumber = "1346",
                    permissibleLoad = 3000,
                    wheels = 4
                },
                transmission = new Transmission()
                {
                    gears = 5,
                    manufacturer = "BMW",
                    transmissionType = "auto"
                }
            },
            new Scooter()
            {
                Engine = new Engine()
                {
                    HP = 50,
                    Capacity = 1,
                    EngineNumber = "435346",
                    EngineType = ""
                },
                Chassis = new Chassis()
                {
                    chassisnumber = "1",
                    permissibleLoad = 2000,
                    wheels = 2
                },
                transmission = new Transmission()
                {
                    gears = 3,
                    manufacturer = "1",
                    transmissionType = ""
                }
            },
            new Truck()
            {
                Engine = new Engine()
                {
                    HP = 500,
                    Capacity = 2,
                    EngineNumber = "67456468",
                    EngineType = ""
                },
                Chassis = new Chassis()
                {
                    chassisnumber = "1987654",
                    permissibleLoad = 30000,
                    wheels = 6
                },
                transmission = new Transmission()
                {
                    gears = 5,
                    manufacturer = "1",
                    transmissionType = ""
                }
            },
            new Bus()
            {
                Engine = new Engine()
                {
                    HP = 500,
                    Capacity = 1,
                    EngineNumber = "",
                    EngineType = ""
                },
                Chassis = new Chassis()
                {
                    chassisnumber = "1",
                    permissibleLoad = 15000,
                    wheels = 8
                },
                transmission = new Transmission()
                {
                    gears = 5,
                    manufacturer = "VW",
                    transmissionType = ""
                }
            }
            };

        foreach (var vechicle in vechicles)
        {
            Console.WriteLine($"{vechicle.Name}");
            Console.WriteLine($"{vechicle.Engine.HP} {vechicle.Engine.Capacity} {vechicle.Engine.EngineNumber} {vechicle.Engine.EngineType}");
            Console.WriteLine($"{vechicle.Chassis.chassisnumber} {vechicle.Chassis.permissibleLoad} {vechicle.Chassis.wheels}");
            Console.WriteLine($"{vechicle.transmission.gears} {vechicle.transmission.manufacturer} {vechicle.transmission.transmissionType}");

        }
    }
}


class Car : Vehicle
{
    public Car()
    {
        Name = "Passenger Car";
    }
}
class Scooter : Vehicle
{
    public Scooter()
    {
        Name = "Scooter";
    }
}
class Truck : Vehicle
{
    public Truck()
    {
        Name = "Truck";
    }
}
class Bus : Vehicle
{
    public Bus()
    {
        Name = "Bus";
    }
}