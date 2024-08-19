namespace ElectraASP.Models
{
    public class RAM : Part
    {
        public required int ID { get; set; }
        public required string Speed { get; set; }
        public required string Modules { get; set; }
        public required string Color { get; set; }
        public required int FirstWordLatency { get; set; }
        public required int CASLatency { get; set; }
        public RAM(int id, string imageLink, string title, string description, float price, int width, int height, Computer computer, string speed, string modules, string color, int firstWord, int cas) : base(imageLink, title, description, price, width, height, computer)
        {
            this.ID = id;
            this.Speed = speed;
            this.Modules = modules;
            this.Color = color;
            this.FirstWordLatency = firstWord;
            this.CASLatency=cas;
        }

        public RAM(int id, string imageLink, string title, float price, int width, int height, string speed, string modules, string color, int firstWord, int cas) : base(imageLink, title, price, width, height)
        {
            this.ID = id;
            this.Speed = speed;
            this.Modules = modules;
            this.Color = color;
            this.FirstWordLatency = firstWord;
            this.CASLatency = cas;
        }

        public RAM() : base()
        {
            ID = 1;
            Speed = " ";
            Modules= " ";
            Color = " ";
            FirstWordLatency = 0;
            CASLatency = 0;
        }
    }
}
