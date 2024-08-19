namespace ElectraASP.Models
{
    public class Motherboard : Part
    {
        public required int ID { get; set; }
        public required string Socket { get; set; }
        public required string FormFactor { get; set; }
        public required int MaxMemory { get; set; }
        public required int MemorySlots { get; set; }
        public required string Color { get; set; }
        public Motherboard(int id, string imageLink, string title, string description, float price, int width, int height, Computer computer, string socket, string formFactor, int maxMemory, int memorySlots, string color) : base(imageLink, title, description, price, width, height, computer)
        {
            this.ID = id;
            Socket = socket;
            FormFactor = formFactor;
            MaxMemory = maxMemory;
            MemorySlots = memorySlots;
            Color = color;
        }

        public Motherboard(int id, string imageLink, string title, float price, int width, int height, string socket, string formFactor, int maxMemory, int memorySlots, string color) : base(imageLink, title, price, width, height)
        {
            this.ID = id;
            Socket = socket;
            FormFactor = formFactor;
            MaxMemory = maxMemory;
            MemorySlots = memorySlots;
            Color = color;
        }

        public Motherboard() : base()
        {
            ID = 1;
            Socket = " ";
            FormFactor = " ";
            MaxMemory = 0;
            MemorySlots = 0;
            Color = " ";
        }
    }
}
