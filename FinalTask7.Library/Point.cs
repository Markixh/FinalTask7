namespace FinalTask7.Library
{
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

    public class PicPoint : Point
    {
        public PicPoint(string name, string address) : base(name, address)
        {

        }
    }

    public class Shop : Point
    {
        public Shop(string name, string address) : base(name, address)
        {

        }
    }

    public class Home : Point
    {
        public Home(string name, string address) : base(name, address)
        {

        }
    }
}
