namespace FinalTask7.Library
{
    public static class DeliveryExtensions
    {
        public static string GetStatus(this Delivery.EStatus status)
        {
            switch ((int)status)
            {
                case 0:
                    return "Заказ создан";
                case 1:
                    return "Заказ собран";
                case 2:
                    return "Заказ отправлен";
                case 3:
                    return "Заказ доставлен";
                case 4:
                    return "Заказ получен";
                default: return "Статус не известен";
            }
        }
    }
}
