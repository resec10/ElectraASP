namespace ElectraASP.Models
{
    public class VideoCard : Part
    {
        public required int ID { get; set; }
        public required string Chipset { get; set; }
        public required int Memory { get; set; }
        public required int CoreClock { get; set; }
        public required int BoostClock { get; set; }
        public required string Color { get; set; }
        public VideoCard(int id, string imageLink, string title, string description, float price, int width, int height, Computer computer, string chipset, int memory, int coreClock, int boostClock, string color) : base(imageLink, title, description, price, width, height, computer)
        {
            this.ID = id;
            Chipset = chipset;
            Memory = memory;
            CoreClock = coreClock;
            BoostClock = boostClock;
            Color = color;
        }

        public VideoCard(int id, string imageLink, string title, float price, int width, int height, string chipset, int memory, int coreClock, int boostClock, string color) : base(imageLink, title, price, width, height)
        {
            this.ID = id;
            Chipset = chipset;
            Memory = memory;
            CoreClock = coreClock;
            BoostClock = boostClock;
            Color = color;
        }

        public VideoCard() : base()
        {
            ID = 1;
            Chipset = " ";
            Memory = 0;
            CoreClock = 0;
            BoostClock = 0;
            Color = " ";
        }
    }
}
