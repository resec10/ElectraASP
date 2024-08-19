namespace ElectraASP.Models
{
    public class Power : Part
    {
        public required int ID { get; set; }
        public required string Type { get; set; }
        public required string EfficiencyRating { get; set; }
        public required int Wattage { get; set; }
        public required bool Modular { get; set; }
        public required string Color { get; set; }
        public Power(int id, string imageLink, string title, string description, float price, int width, int height, Computer computer, string type, string efficiencyRating, int wattage, bool modular, string color) : base(imageLink, title, description, price, width, height, computer)
        {
            this.ID = id;
            this.Type = type;
            this.EfficiencyRating = efficiencyRating;
            this.Wattage = wattage;
            this.Modular = modular;
            this.Color = color;
        }

        public Power(int id, string imageLink, string title, float price, int width, int height, string type, string efficiencyRating, int wattage, bool modular, string color) : base(imageLink, title, price, width, height)
        {
            this.ID = id;
            this.Type = type;
            this.EfficiencyRating = efficiencyRating;
            this.Wattage = wattage;
            this.Modular = modular;
            this.Color = color;
        }

        public Power() : base()
        {
            ID = 1;
            Type = " ";
            EfficiencyRating = " ";
            Wattage = 0;
            Modular = false;
            Color = " ";
        }
    }
}
