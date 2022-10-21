namespace FinalTask7.Library
{
    /// <summary>
    /// Базовый класс доставки
    /// </summary>
    public abstract class Delivery
    {
        private protected string address;
        private EStatus status;

        public string Address { get { return address; } }
        public virtual EStatus Status
        {
            get { return status; }
            set { status = value; }
        }

        public Delivery()
        {
            status = EStatus.Created;
        }

        public enum EStatus
        {
            Created = 0,
            Assembled,
            Sent,
            Delivered,
            Received
        }
    }

    /// <summary>
    /// Доставка домой
    /// </summary>
    public class HomeDelivery : Delivery
    {
        public HomeDelivery(Buyer buyer) : base()
        {
            address = buyer.Address;
        }
        public override EStatus Status { get => base.Status; set => base.Status = value; }
        public HomeDelivery()
        {
            Status = EStatus.Created;
        }
    }

    /// <summary>
    /// Доставка до автомата выдачи
    /// </summary>
    public class PickPointDelivery : Delivery
    {
        public PickPointDelivery(Point pickPoint) : base()
        {
            address = pickPoint.Address;
        }
        public override EStatus Status { get => base.Status; set => base.Status = value; }
        public PickPointDelivery()
        {
            Status = EStatus.Created;
        }
    }

    /// <summary>
    /// Доставка в магазин
    /// </summary>
    public class ShopDelivery : Delivery
    {
        public ShopDelivery(Point shop) : base()
        {
            address = shop.Address;
        }
        public override EStatus Status { get => base.Status; set => base.Status = value; }
        public ShopDelivery()
        {
            Status = EStatus.Created;
        }
    }
}
