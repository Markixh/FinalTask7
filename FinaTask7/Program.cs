﻿using FinalTask7.Library;

namespace FinalTask7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock(); //создаем склад размером на 10 едениц товара
            //заполняем склад
            stock.Add(new Product(name: "Принтер", price: 10000.00m));
            stock.Add(new Product(name: "Сканер", price: 5000.00m));
            stock.Add(new Product(name: "Мышь", price: 500.00m));
            stock.Add(new Product(name: "Клавиатура", price: 1000.00m));
            
            //Покупателя
            Buyer user = new Buyer("Андрей", Address.ConstAdr);
            //Создаем заказ
            Order<HomeDelivery> order = new Order<HomeDelivery>(user);
            order.Add(new Product(name: "Мышь", price: 500.00m));
            order.Add(new Product(name: "Клавиатура", price: 1000.00m));
        }
    }
}