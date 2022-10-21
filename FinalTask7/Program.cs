using FinalTask7.Library;

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
            
            //Покупатель
            Buyer user = new Buyer("Андрей", Address.ConstAdr);
            
            //Создаем заказ
            Order<HomeDelivery> order = new(user);
            order.Add(stock.Take("Мышь"));
            order.Add(stock.Take("Клавиатура"));
            
            order.Delivery.Status = Delivery.EStatus.Assembled;
            order.DisplayStatus();

            order.Delivery.Status = Delivery.EStatus.Sent;
            order.DisplayStatus();

            order.Delivery.Status = Delivery.EStatus.Delivered;
            order.DisplayStatus();

            order.Delivery.Status = Delivery.EStatus.Received;
            order.DisplayStatus();
        }
    }
}