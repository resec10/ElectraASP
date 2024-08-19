using System.ComponentModel.DataAnnotations;

namespace ElectraASP.Models
{
    public class Case : Part
    {
        public required int ID { get; set; }
        public required string Type { get; set; }
        public required string Color { get; set; }
        public required string PowerSupply { get; set; } //If a power supply is attached to the case or not
        public required string SidePanel { get; set; }
        public Case(int id, string imageLink, string title, string description, float price, int width, int height, Computer computer, string type, string color, string powerSupply, string sidePanel) : base(imageLink, title, description, price, width, height, computer)
        {
            this.ID = id;
            this.Type = type;
            this.Color = color;
            this.PowerSupply = powerSupply;
            this.SidePanel = sidePanel;
        }

        public Case(int id, string imageLink, string title, float price, int width, int height, string type, string color, string powerSupply, string sidePanel) : base(imageLink, title, price, width, height)
        {
            this.ID = id;
            this.Type = type;
            this.Color = color;
            this.PowerSupply = powerSupply;
            this.SidePanel = sidePanel;
        }

        public Case() : base()
        {
            ID = 1;
            Type = " ";
            Color = " ";
            PowerSupply = " ";
            SidePanel = " ";
        }
    }
}
