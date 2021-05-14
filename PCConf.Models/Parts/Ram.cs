namespace PCConf.Models.Parts
{
    public class Ram : SellableItem
    {
        public string Model { get; set; }

        public RamType Type { get; set; }

        public int Size { get; set; }
        
        public int ModulesCount { get; set; }
        
        public int SingleModuleSize { get; set; }

        public int Frequency { get; set; }

        public int WarrantyPeriod { get; set; }
    }
}
