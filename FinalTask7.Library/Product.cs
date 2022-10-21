using System.Numerics;

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

        /// <summary>
        /// сумма двух продуктов
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static List<Product> operator + (Product a, Product b)
        {
            List<Product> list = new List<Product>();
            list.Add(a);
            list.Add(b);
            return list;
        }
    }
}
