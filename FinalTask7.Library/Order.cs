namespace FinalTask7.Library
{
    /// <summary>
    /// Заказ
    /// </summary>
    /// <typeparam name="TDelivery"></typeparam>
    class Order<TDelivery> where TDelivery : Delivery
    {
        private Product[] products;
        private Buyer buyer;

        /// <summary>
        /// вид доставки заказа
        /// </summary>
        public TDelivery Delivery;

        /// <summary>
        /// номер заказа
        /// </summary>
        public int Number;

        /// <summary>
        /// Индексатор - коллекция товаров
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Product this[int index]
        {
            get { return (index >= 0 && index < products.Length) ? products[index] : null; }
        }

        public Buyer Buyer { get { return buyer; } }

        /// <summary>
        /// отображение адреса доставки
        /// </summary>
        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }
    }
}
