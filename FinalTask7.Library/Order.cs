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
            random = new Random();
            this.number = random.Next(100000000);
            this.buyer = new("Гость", Address.ConstAdr);
            products = new List<Product>();
        }

        public Order(Buyer buyer) : this()
        {
            this.buyer = buyer;
        }

        /// <summary>
        /// отображение адреса доставки
        /// </summary>
        public void DisplayStatus()
        {
            switch ((int)delivery.Status)
            {
                case 0:
                    Console.WriteLine("Заказ создан");
                    break;
                case 1:
                    Console.WriteLine("Заказ собран");
                    break;
                case 2:
                    Console.WriteLine("Заказ отправлен");
                    break;
                case 3:
                    Console.WriteLine("Заказ доставлен");
                    break;
                case 4:
                    Console.WriteLine("Заказ получен");
                    break;                
            }
        }

        public void Add(Product product)
        {
            products.Add(product);
        }

        public List<Product> Products { get { return products; } }
    }
}
