using System;

namespace Visitor
{
    public interface IVisitor
    {
        void Accept(Car car);
        void Accept(Bike bike);
    }
    public interface IStore
    {
        void Visit(IVisitor visitor);
    }
    public class Car : IStore
    {
        public Car(string carName, double price, double carSpeed)
        {
            CarName = carName;
            Price = price;
            CarSpeed = carSpeed;
        }

        public string CarName { get; set; }
        public double Price { get; set; }
        public double CarSpeed { get; set; }

        public void Visit(IVisitor visitor)
        {
            visitor.Accept(this);
        }
    }

    public class Bike : IStore
    {
        public Bike(string bikeName, double price, double bikeSpeed)
        {
            BikeName = bikeName;
            Price = price;
            BikeSpeed = bikeSpeed;
        }

        public string BikeName { get; set; }
        public double Price { get; set; }
        public double BikeSpeed { get; set; }

        public void Visit(IVisitor visitor)
        {
            visitor.Accept(this);
        }
    }

    class SpeedVisitor : IVisitor
    {
        public void Accept(Car car)
        {
            Console.WriteLine($"Bu Masinin Sureti Maximum:{car.CarSpeed} ola biler");
        }

        public void Accept(Bike bike)
        {
            Console.WriteLine($"Bu Velisopedin Sureti Maximum:{bike.BikeSpeed} ola biler");
        }
    }

    class PriceVisitor : IVisitor
    {
        public void Accept(Car car)
        {
            Console.WriteLine($"Bu Masinin Qiymeti: {car.Price} AZN dir");
        }

        public void Accept(Bike bike)
        {
            Console.WriteLine($"Bu Velisopedin Qiymeti: {bike.Price} AZN dir");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Car Bugatti=new Car("Bugatti",70000,300);

            Bike Bmw = new Bike("BMW", 10000, 230);

            SpeedVisitor speedVisitor = new();

            Bugatti.Visit(speedVisitor);
            Bmw.Visit(speedVisitor);

            Console.WriteLine();
            Console.WriteLine();

            PriceVisitor priceVisitor = new();

            Bugatti.Visit(priceVisitor);
            Bmw.Visit(priceVisitor);

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
