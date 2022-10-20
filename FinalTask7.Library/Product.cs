namespace FinalTask7.Library
{
    /// <summary>
    /// Товар
    /// </summary>
    public class Product
    {
        /// <summary>
        /// наименование товара
        /// </summary>
        private string name;

        /// <summary>
        /// цена товара
        /// </summary>
        private decimal price;

        //свойства
        public string Name { get { return name; } }
        public decimal Price { get { return price; } }

        /// <summary>
        /// создание продукта
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        public Product(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
