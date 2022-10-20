namespace FinalTask7.Library
{
    /// <summary>
    /// Базовый класс доставки
    /// </summary>
    public abstract class Delivery
    {
        public string Address;
    }

    /// <summary>
    /// Доставка домой
    /// </summary>
    public class HomeDelivery : Delivery
    {
        /* ... */
    }

    /// <summary>
    /// Доставка до автомата выдачи
    /// </summary>
    public class PickPointDelivery : Delivery
    {
        /* ... */
    }

    /// <summary>
    /// Доставка в магазин
    /// </summary>
    public class ShopDelivery : Delivery
    {
        /* ... */
    }
}
