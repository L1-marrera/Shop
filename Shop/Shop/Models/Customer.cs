namespace Shop.Models
{
    public class Customer
    {
        #region Properties
        public int Id{ get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string AddressReference { get; set; }
        public string NumberPhone { get; set; }
        public string Email { get; set; }
        #endregion
    }
}
