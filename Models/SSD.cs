namespace ElectraASP.Models
{
    public class SSD : Part
    {
        public required int ID { get; set; }
        public required int Capacity { get; set; }
        public required string Type { get; set; }
        public required int Cache { get; set; }
        public required string FormFactor { get; set; }
        public required string Interface { get; set; }
        public SSD(int id, string imageLink, string title, string description, float price, int width, int height, Computer computer, int capacity, string type, int cache, string formFactor, string _interface) : base(imageLink, title, description, price, width, height, computer)
        {
            this.ID = id;
            Capacity = capacity;
            Type = type;
            Cache = cache;
            FormFactor = formFactor;
            Interface = _interface;
        }

        public SSD(int id, string imageLink, string title, float price, int width, int height, int capacity, string type, int cache, string formFactor, string _interface) : base(imageLink, title, price, width, height)
        {
            this.ID = id;
            Capacity = capacity;
            Type = type;
            Cache = cache;
            FormFactor = formFactor;
            Interface = _interface;
        }

        public SSD() : base()
        {
            ID = 1;
            Capacity = 0;
            Type = " ";
            Cache = 0;
            FormFactor = " ";
            Interface = " ";
        }
    }
}
