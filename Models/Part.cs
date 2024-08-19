using Microsoft.EntityFrameworkCore;

namespace ElectraASP.Models
{
    [Keyless]
    public class Part
    {
        public required string ImageLink { get; set; }
        public required string Name { get; set; }
        public required double Price { get; set; }
        public string? Description { get; set; }
        public required int ImageWidth { get; set; }
        public required int ImageHeight { get; set; }
        public Computer? Computer { get; set; }

        public Part()
        {
            ImageLink = "";
            Name = "";
            Price = 1.00;
            ImageWidth = 1;
            ImageHeight = 1;
            Computer = new Computer();
        }

        public Part(string imageLink, string name, double price, int width, int height)
        {
            this.ImageLink = imageLink;
            this.Name = name;
            this.Price = price;
            this.ImageHeight = height;
            this.ImageWidth = width;
        }

        public Part(string imageLink, string name, string description, double price, int width, int height, Computer computer)
        {
            this.ImageLink = imageLink;
            this.Name = name;
            this.Price = price;
            this.Description = description;
            this.ImageHeight = height;
            this.ImageWidth = width;
            Computer = computer;
        }

    }
}
