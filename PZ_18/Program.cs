using System;

namespace PZ_18
{
    /*
     * ФИО студента: Касаткин Саша Геннадьевич и Дубровский Андрей Сергеевич
     * номер варианта: 4
     * условие задачи (скопировать из листа задания): Создайте класс описывающий товар в интернет-магазине.

     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Product tw1 = new Product("boots", 8000, TypeOfProduct.shoes);
            Product tw2 = new Product("jacket", 5150, TypeOfProduct.clothes);
            Product tw3 = new Product("hat", 1400, TypeOfProduct.accessories);
            Product tw4 = new Product("pants", 2500, TypeOfProduct.clothes);
            Product tw5 = new Product("jeans", 3000, TypeOfProduct.clothes);
            Product tw6 = new Product("ring", 5984, TypeOfProduct.accessories);
            Console.WriteLine(tw1);
            tw1.Discount();
            Console.WriteLine(tw2);
            tw2.Discount();
            Console.WriteLine(tw3);
            tw3.Discount();
            Console.WriteLine(tw4);
            tw4.Discount();
            Console.WriteLine(tw5);
            tw5.Discount();
            Console.WriteLine(tw6);
            tw6.Discount();
            Product.ProductInfo();
            Product.Sell(tw4);
            Product.Sell(tw1);
            Product.Sell(tw2);
            Product.Sell(tw3);
            Product.Sell(tw5);
            Product.ProductInfo();


        }
    }
}