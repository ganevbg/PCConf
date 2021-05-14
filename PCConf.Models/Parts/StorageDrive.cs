namespace PCConf.Models.Parts
{
    public class StorageDrive : SellableItem
    {
        public string Model { get; set; }

        public int Capacity { get; set; }

        public int WriteSpeed { get; set; }

        public int ReadSpeed { get; set; }

        public StorageDriveType Type { get; set; }
    }
}
