namespace PCConf.Models.Parts
{
    public class VideoCard : SellableItem
    {
        public string Chipset { get; set; }

        public string GraphicsProcessor { get; set; }

        public int VideoRam { get; set; }

        public VideoRamType VideoRamType { get; set; }

        public int BusWidth { get; set; }

        public Interface Interface { get; set; }

        public int Length { get; set; }

        public int WarrantyPeriod { get; set; }
    }
}
