namespace FinalTask7.Library
{
    /// <summary>
    /// склад
    /// </summary>
    public class Stock
    {
        /// <summary>
        /// Список продуктов на складе
        /// </summary>
        private List<Product> products;

        /// <summary>
        /// размер склада
        /// </summary>
        private int size;

        private Address address;

        /// <summary>
        /// создание склада на основании списка продуктов
        /// </summary>
        /// <param name="products"></param>
        public Stock(List<Product> products, Address address)
        {
            this.address = address;
            size = products.Count;
            this.products = products;
        }

        /// <summary>
        /// создание пустого склада с определенным размером
        /// </summary>
        /// <param name="size"></param>
        public Stock(Address address, int size = 10)
        {
            this.size = size;
            products = new List<Product>();
            this.address = address;
        }

        public Stock(int size = 10)
        {
            this.size = size;
            products = new List<Product>();
            this.address = Address.ConstAdr;
        }

        /// <summary>
        /// добавление продуктов в склад
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public bool Add(Product product)
        {
            if (products.Count <= size)
            {
                products.Add(product);
                return true;
            }
            else return false;
        }

        /// <summary>
        /// Извлечение продукта со склада при наличии
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public bool Take(Product product)
        {
            if (products.Count > 0 && products.Contains(product))
            {                
                products.Remove(product);
                return true;
            }
            else return false;
        }
    }
}
