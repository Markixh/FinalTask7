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
            Console.WriteLine(delivery.Status.GetStatus());
        }

        /// <summary>
        /// Добавление продуктов в заказ
        /// </summary>
        /// <param name="product"></param>
        public void Add(Product product)
        {
            products.Add(product);
        }

        /// <summary>
        /// Список продуктов в заказе (индексатор)
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Product this[int i]
        {
            get { return products[i]; }
        }
    }

    /// <summary>
    /// наследование обобщенного класса
    /// </summary>
    public class InternetOrder : Order<HomeDelivery>
    {

    }
}
