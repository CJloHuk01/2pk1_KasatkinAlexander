using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_18
{
    enum TypeOfProduct { clothes, shoes, accessories }
    internal class Product
    {
        string _name;
        decimal _price;
        decimal _priceOfDiscount = 0;
        public static int countOfProduct = 0;
        public static decimal totalOfPrice = 0;
        public static decimal averagePrice = 0;
        public static decimal totalPriceOfDiscount;
        public static decimal averagePriceOfDiscount;
        public string Name
        {
            get => _name;
            set
            {
                if (value == "")
                {
                    Console.WriteLine("Название не может быть пустым. Введите название");
                    _name = Console.ReadLine();
                }
                else _name = value;
            }
        }
        public decimal Price
        {
            get => _price;
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Цена не может быть нулевой. Введите цену");
                    _price = Convert.ToUInt32(Console.ReadLine());
                }
                else _price = value;
            }
        }
        public TypeOfProduct Type { get; set; }


        public Product(string name, decimal price, TypeOfProduct type)
        {
            Name = name;
            Price = price;
            Type = type;
            countOfProduct++;
            totalOfPrice += _price;
            averagePrice = totalOfPrice / countOfProduct;


        }

        public override string ToString()
        {
            return $"Названиме товара: {Name}\n" +
                $"Цена товара: {Price}\n" +
                $"Категория товара: {Type}";
        }

        public void Discount()
        {
            int procent;
            if (Type == TypeOfProduct.clothes)
            {
                procent = 5;
                _priceOfDiscount = _price - _price * procent / 100;
                Console.WriteLine($"Цена после скидки: {_priceOfDiscount}\n");
            }
            else if (Type == TypeOfProduct.shoes)
            {
                procent = 7;
                _priceOfDiscount = _price - _price * procent / 100;
                Console.WriteLine($"Цена после скидки: {_priceOfDiscount}\n");
            }
            else if (Type == TypeOfProduct.accessories)
            {
                procent = 10;
                _priceOfDiscount = _price - _price * procent / 100;
                Console.WriteLine($"Цена после скидки: {_priceOfDiscount}\n");
            }
            totalPriceOfDiscount = totalPriceOfDiscount + _priceOfDiscount;
            averagePriceOfDiscount += _priceOfDiscount / countOfProduct;
        }

        public static void ProductInfo()
        {
            Console.WriteLine($"Кол-во всего товара: {Product.countOfProduct}");
            Console.WriteLine($"Цена всего товара: {Product.totalOfPrice}");
            Console.WriteLine($"Средняя цена всего товара: {Product.averagePrice}");
            Console.WriteLine($"Цена всего товара со скидкой: {Product.totalPriceOfDiscount}");
            Console.WriteLine($"Средняя цена всего товара со скидкой: {Product.averagePriceOfDiscount}\n");
        }

        public static void Sell(Product tw)
        {
            countOfProduct--;
            totalOfPrice -= tw._price;
            averagePrice = totalOfPrice / countOfProduct;
            totalPriceOfDiscount -= tw._priceOfDiscount;
            averagePriceOfDiscount = totalPriceOfDiscount / countOfProduct;


            Console.WriteLine($"Продали {tw._name}\n");
        }

    }
}
