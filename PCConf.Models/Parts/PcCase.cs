namespace PCConf.Models.Parts
{
    using System.Collections.Generic;

    public class PcCase : SellableItem
    {
        public string Model { get; set; }

        public IEnumerable<PcCaseFormat> Formats { get; set; }

        public string SidePanel { get; set; }

        public int MaxCoolerSize { get; set; }
        
        public int MaxVideoCardSize { get; set; }

        public double Weight { get; set; }
    }
}
