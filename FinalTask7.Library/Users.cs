namespace FinalTask7.Library
{
    /// <summary>
    /// пользователь
    /// </summary>
    public abstract class User
    {
        private string name;
        public string Name { get { return name; } }

        public User(string name)
        {
            this.name = name;
        }
    }

    /// <summary>
    /// Покупатель
    /// </summary>
    public class Buyer : User
    {
        private Address address;

        public string Address { get { return address.GetAddress(); } }

        public Buyer(string name, Address address) : base(name)
        {
            this.address = address;
        }
    }
}
