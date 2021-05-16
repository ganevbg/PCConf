namespace PCConf.Models.Parts
{
    public class Processor : SellableItem
    {
        public string Model { get; set; }
        
        public CpuSocket CpuSocket { get; set; }

        public int PhysicalCores { get; set; }

        public int LogicalCores { get; set; }

        public double Frequency { get; set; }
        
        public double TurboBoostFrequency { get; set; }

        public int Cache { get; set; }

        public RamType RamType { get; set; }

        public bool IntegratedGraphics { get; set; }
    }
}
