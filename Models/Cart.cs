namespace ElectraASP.Models
{
    public class Cart
    {
        public int ID { get; set; }
        public int? CaseID { get; set; }
        public Case? ComputerCase { get; set; }
        public int? CoolerID { get; set; }
        public Cooler? ComputerCooler { get; set; }
        public int? ProcessorID { get; set; }
        public CPU? Processor { get; set; }
        public int? MotherboardID { get; set; }
        public Motherboard? PC_Motherboard { get; set; }
        public int? PowerSupplyID { get; set; }
        public Power? PowerSupply { get; set; }
        public int? MemoryID { get; set; }
        public RAM? Memory { get; set; }
        public int? StorageID { get; set; }
        public SSD? Storage { get; set; }
        public int? GraphicsCardID { get; set; }
        public VideoCard? GraphicsCard { get; set; }
    }
}
