namespace ElectraASP.Models
{
    public class Cooler : Part
    {
        public required int ID { get; set; }
        public required string FanRPM { get; set; }
        public required float NoiseLevel { get; set; }
        public required string Color { get; set; }
        public required int RadiatorSize { get; set; }
        public Cooler(int id, string imageLink, string title, string description, float price, int width, int height, Computer computer, string fanRPM, float noiseLevel, string color, int radiatorSize) : base(imageLink, title, description, price, width, height, computer)
        {
            this.ID = id;
            FanRPM = fanRPM;
            NoiseLevel = noiseLevel;
            Color = color;
            RadiatorSize = radiatorSize;
        }

        public Cooler(int id, string imageLink, string title, float price, int width, int height, string fanRPM, float noiseLevel, string color, int radiatorSize) : base(imageLink, title, price, width, height)
        {
            this.ID = id;
            FanRPM = fanRPM;
            NoiseLevel = noiseLevel;
            Color = color;
            RadiatorSize = radiatorSize;
        }

        public Cooler() : base()
        {
            ID = 1;
            FanRPM = " ";
            NoiseLevel = 0;
            Color = " ";
            RadiatorSize = 0;
        }
    }
}
