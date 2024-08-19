namespace ElectraASP.Models
{
    public class CPU : Part
    {
        public required int ID { get; set; }
        public required int CoreCount { get; set; }
        public required double PerformanceCoreBoost { get; set; }
        public required double PerformanceBoostClock { get; set; }
        public required int TDP { get; set; }
        public required string IntegratedGraphics { get; set; }
        public CPU(int id, string imageLink, string title, string description, float price, int width, int height, Computer computer, int coreCount, double coreBoost, double boostClock, int tdp, string integrated) : base(imageLink, title, description, price, width, height, computer)
        {
            this.ID = id;
            this.CoreCount = coreCount;
            this.PerformanceCoreBoost = coreBoost;
            this.PerformanceBoostClock = boostClock;
            this.TDP = tdp;
            this.IntegratedGraphics = integrated;
        }

        public CPU(int id, string imageLink, string title, float price, int width, int height, int coreCount, double coreBoost, double boostClock, int tdp, string integrated) : base(imageLink, title, price, width, height)
        {
            this.ID = id;
            this.CoreCount = coreCount;
            this.PerformanceCoreBoost = coreBoost;
            this.PerformanceBoostClock = boostClock;
            this.TDP = tdp;
            this.IntegratedGraphics = integrated;
        }

        public CPU() : base()
        {
            ID = 1;
            CoreCount = 0;
            PerformanceCoreBoost=0;
            PerformanceBoostClock=0;
            TDP = 0;
            IntegratedGraphics = "";
        }
    }
}
