using System.Drawing;

namespace FinalTask7.Library
{
    /// <summary>
    /// Заказ
    /// </summary>
    /// <typeparam name="TDelivery"></typeparam>
    public class Order<TDelivery> where TDelivery : Delivery, new()
    {
        private List<Product> products;
        private Buyer buyer;
        private TDelivery delivery;
        private int number;

        private Random random;

        /// <summary>
        /// вид доставки заказа
        /// </summary>
        public TDelivery Delivery { get { return delivery; } }

        /// <summary>
        /// номер заказа
        /// </summary>
        public int Number { get { return number; } }

        /// <summary>
        /// Покупатель
        /// </summary>
        public Buyer Buyer { get { return buyer; } }

        public Order()
        {
            this.delivery = new TDelivery();
            this.number = random.Next(100000000);
            this.buyer = new("Гость", Address.ConstAdr);
        }

        public Order(Buyer buyer)
        {
            this.delivery = new TDelivery();
            this.number = random.Next(100000000);
            this.buyer = new("Гость", Address.ConstAdr);
        }

        /// <summary>
        /// отображение адреса доставки
        /// </summary>
        public void DisplayAddress()
        {
            Console.WriteLine(delivery.Address);
        }

        public void Add(Product product)
        {
            products.Add(product);
        }
    }
}
