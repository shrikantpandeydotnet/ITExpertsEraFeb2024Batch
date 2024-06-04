

namespace ITExpertsEraFeb2024Batch
{
    public class Car
    {
        // properties. 

        public string Brand { get; set; }

        public string Name { get ; set; }

        public int NoOfSeats { get; set; }

        public string Color { get; set; }

        // Methods

        // Access Modifier | Return Type | Method Name | Method Parameters
        public void Accelerator(int Pressure)
        {
            int speed = Pressure * 10; 

            Console.WriteLine("Speed of the car is " + speed);
        }

        public void Brake(int Pressure)
        {
            int speed = Pressure / 10;

            Console.WriteLine("Speed of the car is " + speed);
        }
    }
}
