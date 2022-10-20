namespace FinalTask7.Library
{
    /// <summary>
    /// Базовый класс доставки
    /// </summary>
    public abstract class Delivery
    {
        public string Address;
        public Delivery()
        {

        }
    }

    /// <summary>
    /// Доставка домой
    /// </summary>
    public class HomeDelivery : Delivery
    {
        public HomeDelivery():base(){}
        /* ... */
    }

    /// <summary>
    /// Доставка до автомата выдачи
    /// </summary>
    public class PickPointDelivery : Delivery
    {
        public PickPointDelivery() : base() { }
        /* ... */
    }

    /// <summary>
    /// Доставка в магазин
    /// </summary>
    public class ShopDelivery : Delivery
    {
        public ShopDelivery() : base() { }
        /* ... */
    }
}
