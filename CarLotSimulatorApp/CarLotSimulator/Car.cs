using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool Isdriveable { get; set; }

        public void MakeEngineNoise()
        {
        Console.WriteLine("Vroom");
        }

        public void MakeHonkNoise ()
        {
            Console.WriteLine("Honk-Honk!");
        }
       
       
    }

    public class CarLot { }
    public string ListOfCars { get; set; }

}
