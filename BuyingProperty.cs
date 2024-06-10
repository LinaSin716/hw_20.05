using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_20._05
{
    public class BuyingProperty<T>
    {
        public string Customer { get; set; }
        public string Seller { get; set; }
        public T Property { get; set; } 
        public decimal Price { get; set; }
        public BuyingProperty(string customer, string seller, T property, decimal price)
        {
            Customer = customer;
            Seller = seller;
            Property = property;
            Price = price;
        }

        public string Information(House property)
        {
            return $"\nПокупатель: {Customer}\n" +
                $"Продавец: {Seller}\n" +
                $"Вид недвижимости: {property.Type}\n" +
                $"Стоимость: {Price}\n" +
                $"Площадь: {property.Square}\n" +
                $"Количество комнат: {property.CountRooms}\n" +
                $"Адрес: {property.Address}\n" +
                $"Количество этажей: {property.CountFloor}\n" +
                $"Площадь участка: {property.SquareLand}\n" +
                $"Адрес: {property.Address}";
        }
        public string Information(Flat property)
        {
            string s_true = "есть";
            string s_false = "нет";
            return $"\nПокупатель: {Customer}\n" +
                $"Продавец: {Seller}\n" +
                $"Вид недвижимости: {property.Type}\n" +
                $"Стоимость: {Price}\n" +
                $"Площадь: {property.Square}\n" +
                $"Количество комнат: {property.CountRooms}\n" +
                $"Адрес: {property.Address}\n" +
                $"Балкон: {(property.HasBalcony ? s_true : s_false)}\n" +
                $"Газ: {(property.HasGas ? s_true : s_false)}\n" +
                $"Номер этажа: {property.Floor}";
        }
        public decimal PriceProperty(House property)
        {
            return Price / property.Square;
        }
        public decimal PriceProperty(Flat property)
        {
            return Price / property.Square;
        }
    }
}
