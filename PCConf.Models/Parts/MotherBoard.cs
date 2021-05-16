namespace PCConf.Models.Parts
{
    public class MotherBoard : SellableItem
    {
        public string Model { get; set; }

        public CpuSocket CpuSocket { get; set; }

        public string Chipset { get; set; }

        public Format Format { get; set; }

        public RamType RamType { get; set; }

        public int RamSlotsCount { get; set; }

        public int MaxRamCapacity { get; set; }

        public bool DualChannelSupport { get; set; }
    }
}
