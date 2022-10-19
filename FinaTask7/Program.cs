namespace FinaTask7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        /// <summary>
        /// Базовый класс доставки
        /// </summary>
        abstract class Delivery
        {
            public string Address;
        }

        /// <summary>
        /// Доставка домой
        /// </summary>
        class HomeDelivery : Delivery
        {
            /* ... */
        }

        /// <summary>
        /// Доставка до автомата выдачи
        /// </summary>
        class PickPointDelivery : Delivery
        {
            /* ... */
        }

        /// <summary>
        /// Доставка в магазин
        /// </summary>
        class ShopDelivery : Delivery
        {
            /* ... */
        }

        /// <summary>
        /// Заказ
        /// </summary>
        /// <typeparam name="TDelivery"></typeparam>
        class Order<TDelivery> where TDelivery : Delivery
        {
            /// <summary>
            /// вид доставки заказа
            /// </summary>
            public TDelivery Delivery;

            /// <summary>
            /// номер заказа
            /// </summary>
            public int Number;

            /// <summary>
            /// Описание заказа
            /// </summary>
            public string Description;

            /// <summary>
            /// отображение адреса доставки
            /// </summary>
            public void DisplayAddress()
            {
                Console.WriteLine(Delivery.Address);
            }

            // ... Другие поля
        }
    }
}