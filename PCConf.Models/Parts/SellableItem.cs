namespace PCConf.Models.Parts
{
    public class SellableItem : BaseDbModel
    {
        public Brand Brand { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public string ImageUrl { get; set; }

        public int WarrantyPeriod { get; set; }
    }
}
