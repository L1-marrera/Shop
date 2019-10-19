namespace Shop.Models
{
    public class Product
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; }
        public bool IsProductOfTheWeek { get; set; }
        public string InStock { get; set; }
        #endregion
    }
}
