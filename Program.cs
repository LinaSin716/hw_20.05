using System.Security.Principal;

namespace hw_20._05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            House house = new House()
            {
                Type = "house",
                Address = "house_address",
                CountFloor = 3,
                CountRooms = 15,
                Square = 500,
                SquareLand = 1000,
            };
            BuyingProperty<House> buyingHouse = new BuyingProperty<House>
                ("qwe ewq", "asd dsa", house, 500m);

            Flat flat = new Flat()
            {
                Type = "flat",
                Address = "flat_address",
                Square = 200,
                CountRooms = 3,
                Floor = 14,
                HasBalcony = true,
                HasGas = true
            };
            BuyingProperty<Flat> buyingFlat = new BuyingProperty<Flat>
                ("poi iop", "lkj jkl", flat, 20000m);

            Console.WriteLine("Первая покупка:\n" + buyingFlat.Information(flat));
            Console.WriteLine("Стоимость квадратного метра: " + buyingFlat.PriceProperty(flat));

            Console.WriteLine("\nВторая покупка:\n" + buyingHouse.Information(house));
            Console.WriteLine("Стоимость квадратного метра: " + buyingHouse.PriceProperty(house));

        }
    }
}