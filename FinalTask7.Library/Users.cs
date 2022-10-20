namespace FinalTask7.Library
{
    /// <summary>
    /// пользователь
    /// </summary>
    abstract class User
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
    class Buyer : User
    {
        private string address;
        public string Address { get { return address; } }
        public Buyer(string name, string address) : base(name)
        {
            this.address = address;
        }
    }
}
