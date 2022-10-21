namespace FinalTask7.Library
{
    /// <summary>
    /// точка для доставки
    /// </summary>
    public abstract class Point
    {
        private protected string name;
        private protected string address;

        public string Name { get { return name; } }
        public string Address { get { return address; } }

        public Point(string name, string address)
        {
            this.name = name;
            this.address = address;
        }   
    }

    /// <summary>
    /// ПикПоинт
    /// </summary>
    public class PicPoint : Point
    {
        public PicPoint(string name, string address) : base(name, address)
        {

        }
    }

    /// <summary>
    /// Магазин
    /// </summary>
    public class Shop : Point
    {
        public Shop(string name, string address) : base(name, address)
        {

        }
    }

    /// <summary>
    /// Дом
    /// </summary>
    public class Home : Point
    {
        public Home(string name, string address) : base(name, address)
        {

        }
    }
}
