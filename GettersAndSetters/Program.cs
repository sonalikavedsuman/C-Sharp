namespace GettersAndSetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating an object myCar
            Car myCar = new Car();
            myCar.SetName("myCar2");
            //myCar.SetName("");
            Console.WriteLine($"My Car is:- {myCar.GetName()} with horse power of {myCar.GetHp()}");
            myCar.Details();

            //creating an object audi
            Car audi = new Car("Audi A4", 350, "Black");

            //creating an object bmw
            Car bmw = new Car("BMW M5", 450);

            Console.Read();
        }
    }
}