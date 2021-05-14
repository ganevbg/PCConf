namespace PCConf.Models.Parts
{
    public class PowerSuply : SellableItem
    {
        public string Model { get; set; }

        public int Output { get; set; }

        public Certificate Certificate { get; set; }


    }
}
