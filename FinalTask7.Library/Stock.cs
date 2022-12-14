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
        /// список продуктов (Индексатор)
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Product this[int i]
        {
            get 
            {
                if (i < products.Count && i > 0) return products[i];
                else return null;
            }
        }

        ///<summary>
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
        public Product Take(int ind)
        {
            var take = products[ind];
            products.RemoveAt(ind);
            return take;
        }

        /// <summary>
        /// Получить продукт со склада
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Product Take(string name)
        {
            foreach (var product in products)
            {
                if (product.Name == name)
                {
                    var take = product;
                    products.Remove(product);
                    return take;
                }
            }
            return null;
        }
    }
}
