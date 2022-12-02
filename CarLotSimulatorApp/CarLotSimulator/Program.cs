using System;
using System.Collections.Concurrent;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car


            Console.WriteLine("First Car");
            Console.WriteLine(" I will use STANDARD MEMBER INITIALIZATION BELOW!");

            Car myCar = new Car();
            myCar.Year = 2000;
            myCar.Make = "Chevy";
            myCar.Model = "Cruise";
            myCar.Isdriveable = false;

            myCar.MakeEngineNoise();
            myCar.MakeHonkNoise();

            Console.WriteLine($" {myCar.Year} {myCar.Make} {myCar.Model} {myCar.Isdriveable}");


            Console.WriteLine("Second Car");
            Console.WriteLine(" I will use SMI and Object Initializer Syntax Below!");

            Car myCar2 = new Car();
            myCar2.Year = 2005;
            myCar2.Make = "Chevy";
            myCar2.Model = "Tahoe";
            myCar2.Isdriveable = false;

            myCar2.MakeEngineNoise();
            myCar2.MakeHonkNoise();

            Console.WriteLine($" {myCar2.Year} {myCar2.Make} {myCar2.Model} {myCar2.Isdriveable}");

            Car car2 = new Car() { Year = 2005, Make = "Chevy", Model = " Tahoe", Isdriveable = false };

            Console.WriteLine("Third Car");
            Console.WriteLine(" I will use SMI and Constructor Initializer Below!");

            Car car3 = new Car(2010, "Chevy", "Malibu", Isdriveable);   

            Car myCar3 = new Car();
            myCar3.Year = 2010;
            myCar3.Make = "Chevy";
            myCar3.Model = "Malibu";
            myCar3.Isdriveable = false;

            myCar3.MakeEngineNoise();
            myCar3.MakeHonkNoise();

            Console.WriteLine($" {myCar3.Year} {myCar3.Make} {myCar3.Model} {myCar3.Isdriveable}");

            Car myCar4 = new Car();
            myCar4.Year = 2010;
            myCar4.Make = "Chevy";
            myCar4.Model = "Corvette";
            myCar4.Isdriveable = false;

            myCar4.MakeEngineNoise();
            myCar4.MakeHonkNoise();

            Console.WriteLine($" {myCar4.Year} {myCar4.Make} {myCar4.Model} {myCar4.Isdriveable}");

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        
        
        
        
        }


    }
}
