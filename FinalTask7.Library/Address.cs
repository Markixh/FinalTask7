namespace FinalTask7.Library
{
    public class Address
    {
        /// <summary>
        /// индекс
        /// </summary>
        private string ind;
        /// <summary>
        /// Область
        /// </summary>
        private string region;
        /// <summary>
        /// Район
        /// </summary>
        private string area;
        /// <summary>
        /// Город
        /// </summary>
        private string city;
        /// <summary>
        /// Улица
        /// </summary>
        private string street;
        /// <summary>
        /// Дом
        /// </summary>
        private string house;

        public Address( string ind, string region, string area, string city, string street, string house)
        {
            this.ind = ind;
            this.region = region;
            this.area = area;
            this.city = city;
            this.street = street;
            this.house = house;
        }

        /// <summary>
        /// Возращает адрес
        /// </summary>
        /// <returns></returns>
        public string GetAddress()
        {
            return $"{ind}, {region}, {area}, {city}, {street}, {house}";
        }
    }
}
