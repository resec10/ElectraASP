using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ElectraASP.Models;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;

namespace ElectraASP.Pages
{
    public class ShopModel : PageModel
    {
        private readonly ThisContext _context;
        public List<CPU> BoughtCPU;
        public List<Cooler> BoughtCooler;
        public List<Case> BoughtCase;
        public List<Motherboard> BoughtMotherboard;
        public List<Power> BoughtPower;
        public List<RAM> BoughtRAM;
        public List<SSD> BoughtSSD;
        public List<VideoCard> BoughtVideoCard;
        [BindProperty] public int id { get; set; }
        [BindProperty] public string type { get; set; }
        [BindProperty] public string Type { get; set; }
        [BindProperty] public string ItemID { get; set; }
        public ShopModel(ThisContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            BoughtCPU = _context.ShoppingCart.Select(c => c.Processor).ToList();
            if (BoughtCPU.Any() == false) BoughtCPU = new List<CPU>();
            BoughtCooler = _context.ShoppingCart.Select(c => c.ComputerCooler).ToList();
            if (BoughtCooler.Any()==false) BoughtCooler = new List<Cooler>();
            BoughtCase = _context.ShoppingCart.Select(c => c.ComputerCase).ToList();
            if (BoughtCase.Any() == false) BoughtCase = new List<Case>();
            BoughtMotherboard = _context.ShoppingCart.Select(c => c.PC_Motherboard).ToList();
            if (BoughtMotherboard.Any() == false) BoughtMotherboard = new List<Motherboard>();
            BoughtPower = _context.ShoppingCart.Select(c => c.PowerSupply).ToList();
            if (BoughtPower.Any() == false) BoughtPower = new List<Power>();
            BoughtRAM = _context.ShoppingCart.Select(c => c.Memory).ToList();
            if (BoughtRAM.Any() == false) BoughtRAM = new List<RAM>();
            BoughtSSD = _context.ShoppingCart.Select(c => c.Storage).ToList();
            if (BoughtSSD.Any() == false) BoughtSSD = new List<SSD>();
            BoughtVideoCard = _context.ShoppingCart.Select(c => c.GraphicsCard).ToList();
            if (BoughtVideoCard.Any() == false) BoughtVideoCard = new List<VideoCard>();
        }

        public void OnPost()
        {
            OnGet();
            if (this.Type != null && ItemID != null)
            {
                var shoppingCart = _context.ShoppingCart.FirstOrDefault(sc => sc.ID == 1);
                switch (Type)
                {
                    case "CPU":
                    var cpu = _context.CPU_Table.FirstOrDefault(c => c.ID == Convert.ToInt32(ItemID));
                    if (cpu != null)
                    {
                        if (shoppingCart != null)
                        {
                            shoppingCart.ProcessorID = Convert.ToInt32(ItemID);
                            _context.SaveChanges();
                            var item = _context.CPU_Table.FirstOrDefault(c => c.ID == Convert.ToInt32(ItemID));
                            BoughtCPU.Add(item);
                        }
                    }
                    break;
                case "Cooler":
                    var cooler = _context.Coolers.FirstOrDefault(c => c.ID == Convert.ToInt32(ItemID));
                    if (cooler != null)
                    {
                        if (shoppingCart != null)
                        {
                            shoppingCart.CoolerID = Convert.ToInt32(ItemID);
                            _context.SaveChanges();
                            var item = _context.Coolers.FirstOrDefault(c => c.ID == Convert.ToInt32(ItemID));
                            BoughtCooler.Add(item);
                        }
                    }
                        break;
                    case "Motherboard":
                        var moth = _context.Motherboards.FirstOrDefault(c => c.ID == Convert.ToInt32(ItemID));
                        if (moth != null)
                        {
                            if (shoppingCart != null)
                            {
                                shoppingCart.MotherboardID = Convert.ToInt32(ItemID);
                                _context.SaveChanges();
                                var item = _context.Motherboards.FirstOrDefault(c => c.ID == Convert.ToInt32(ItemID));
                                BoughtMotherboard.Add(item);
                            }
                        }
                        break;
                    case "RAM":
                        var ram = _context.RAM_Table.FirstOrDefault(c => c.ID == Convert.ToInt32(ItemID));
                        if (ram != null)
                        {
                            if (shoppingCart != null)
                            {
                                shoppingCart.MemoryID = Convert.ToInt32(ItemID);
                                _context.SaveChanges();
                                var item = _context.RAM_Table.FirstOrDefault(c => c.ID == Convert.ToInt32(ItemID));
                                BoughtRAM.Add(item);
                            }
                        }
                        break;
                    case "SSD":
                        var ssd = _context.SSD_Table.FirstOrDefault(c => c.ID == Convert.ToInt32(ItemID));
                        if (ssd != null)
                        {
                            if (shoppingCart != null)
                            {
                                shoppingCart.StorageID = Convert.ToInt32(ItemID);
                                _context.SaveChanges();
                                var item = _context.SSD_Table.FirstOrDefault(c => c.ID == Convert.ToInt32(ItemID));
                                BoughtSSD.Add(item);
                            }
                        }
                        break;
                    case "VideoCard":
                        var videoCard = _context.VideoCards.FirstOrDefault(c => c.ID == Convert.ToInt32(ItemID));
                        if (videoCard != null)
                        {
                            if (shoppingCart != null)
                            {
                                shoppingCart.GraphicsCardID = Convert.ToInt32(ItemID);
                                _context.SaveChanges();
                                var item = _context.VideoCards.FirstOrDefault(c => c.ID == Convert.ToInt32(ItemID));
                                BoughtVideoCard.Add(item);
                            }
                        }
                        break;
                    case "Case":
                        var cs = _context.Cases.FirstOrDefault(c => c.ID == Convert.ToInt32(ItemID));
                        if (cs != null)
                        {
                            if (shoppingCart != null)
                            {
                                shoppingCart.CaseID = Convert.ToInt32(ItemID);
                                _context.SaveChanges();
                                var item = _context.Cases.FirstOrDefault(c => c.ID == Convert.ToInt32(ItemID));
                                BoughtCase.Add(item);
                            }
                        }
                        break;
                    case "Power":
                        var pw = _context.Powers.FirstOrDefault(c => c.ID == Convert.ToInt32(ItemID));
                        if (pw != null)
                        {
                            if (shoppingCart != null)
                            {
                                shoppingCart.PowerSupplyID = Convert.ToInt32(ItemID);
                                _context.SaveChanges();
                                var item = _context.Powers.FirstOrDefault(c => c.ID == Convert.ToInt32(ItemID));
                                BoughtPower.Add(item);
                            }
                        }
                        break;
                }
            }
            OnGet();
        }

        public void OnPostDelete()
        {
            if (!string.IsNullOrEmpty(type))
            {
                var shoppingCart = _context.ShoppingCart.FirstOrDefault(c => c.ID == 1);
                int id;

                //This is meant for deleting the bundles

                switch (type)
                {
                    case "CPU":
                        id = _context.CPU_Table.FirstOrDefault(c => c.ID == shoppingCart.ProcessorID).ID;
                        shoppingCart.ProcessorID = null;
                        break;
                    case "Cooler":
                        id = _context.CPU_Table.FirstOrDefault(c => c.ID == shoppingCart.CoolerID).ID;
                        shoppingCart.CoolerID = null;
                        break;
                    case "Motherboard":
                        id = _context.CPU_Table.FirstOrDefault(c => c.ID == shoppingCart.MotherboardID).ID;
                        shoppingCart.MotherboardID = null;
                        break;
                    case "SSD":
                        id = _context.CPU_Table.FirstOrDefault(c => c.ID == shoppingCart.StorageID).ID;
                        shoppingCart.StorageID = null;
                        break;
                    case "RAM":
                        id = _context.CPU_Table.FirstOrDefault(c => c.ID == shoppingCart.MemoryID).ID;
                        shoppingCart.MemoryID = null;
                        break;
                    case "Case":
                        id = _context.CPU_Table.FirstOrDefault(c => c.ID == shoppingCart.CaseID).ID;
                        shoppingCart.CaseID = null;
                        break;
                    case "Power":
                        id = _context.CPU_Table.FirstOrDefault(c => c.ID == shoppingCart.PowerSupplyID).ID;
                        shoppingCart.PowerSupplyID = null;
                        break;
                    case "VideoCard":
                        id = _context.CPU_Table.FirstOrDefault(c => c.ID == shoppingCart.GraphicsCardID).ID;
                        shoppingCart.GraphicsCardID = null;
                        break;
                    default: id = 0; break;
                }
                if (id >= 1 && id <= 6)
                {
                    shoppingCart.ProcessorID = null;
                    shoppingCart.CoolerID = null;
                    shoppingCart.MotherboardID = null;
                    shoppingCart.StorageID = null;
                    shoppingCart.MemoryID = null;
                    shoppingCart.CaseID = null;
                    shoppingCart.PowerSupplyID = null;
                    shoppingCart.GraphicsCardID = null;
                }

                _context.SaveChanges();
            }
            OnGet();
        }
        
        public void OnPostBundle(string id, string CPU, string Case, string? Cooler, string Motherboard, string Power, string RAM, string SSD, string VideoCard)
        {
            OnGet();
            ItemID = id;
            var shoppingCart = _context.ShoppingCart.FirstOrDefault(sc => sc.ID == 1);
                var cpu = _context.CPU_Table.FirstOrDefault(c => c.ID == Convert.ToInt32(ItemID));
                if (cpu != null)
                {
                    if (shoppingCart != null)
                    {
                        shoppingCart.ProcessorID = Convert.ToInt32(ItemID);
                        _context.SaveChanges();
                        var item = _context.CPU_Table.FirstOrDefault(c => c.ID == Convert.ToInt32(ItemID));
                        BoughtCPU.Add(item);
                    }
                }
                if (!string.IsNullOrEmpty(Cooler))
                {
                    var cooler = _context.Coolers.FirstOrDefault(c => c.ID == Convert.ToInt32(ItemID));
                    if (cooler != null)
                    {
                        if (shoppingCart != null)
                        {
                            shoppingCart.CoolerID = Convert.ToInt32(ItemID);
                            _context.SaveChanges();
                            var item = _context.Coolers.FirstOrDefault(c => c.ID == Convert.ToInt32(ItemID));
                            BoughtCooler.Add(item);
                        }
                    }
                }
                var moth = _context.Motherboards.FirstOrDefault(c => c.ID == Convert.ToInt32(ItemID));
                if (moth != null)
                {
                    if (shoppingCart != null)
                    {
                        shoppingCart.MotherboardID = Convert.ToInt32(ItemID);
                        _context.SaveChanges();
                        var item = _context.Motherboards.FirstOrDefault(c => c.ID == Convert.ToInt32(ItemID));
                        BoughtMotherboard.Add(item);
                    }
                }
                var ram = _context.RAM_Table.FirstOrDefault(c => c.ID == Convert.ToInt32(ItemID));
                if (ram != null)
                {
                    if (shoppingCart != null)
                    {
                        shoppingCart.MemoryID = Convert.ToInt32(ItemID);
                        _context.SaveChanges();
                        var item = _context.RAM_Table.FirstOrDefault(c => c.ID == Convert.ToInt32(ItemID));
                        BoughtRAM.Add(item);
                    }
                }
                var ssd = _context.SSD_Table.FirstOrDefault(c => c.ID == Convert.ToInt32(ItemID));
                if (ssd != null)
                {
                    if (shoppingCart != null)
                    {
                        shoppingCart.StorageID = Convert.ToInt32(ItemID);
                        _context.SaveChanges();
                        var item = _context.SSD_Table.FirstOrDefault(c => c.ID == Convert.ToInt32(ItemID));
                        BoughtSSD.Add(item);
                    }
                }
                var videoCard = _context.VideoCards.FirstOrDefault(c => c.ID == Convert.ToInt32(ItemID));
                if (videoCard != null)
                {
                    if (shoppingCart != null)
                    {
                        shoppingCart.GraphicsCardID = Convert.ToInt32(ItemID);
                        _context.SaveChanges();
                        var item = _context.VideoCards.FirstOrDefault(c => c.ID == Convert.ToInt32(ItemID));
                        BoughtVideoCard.Add(item);
                    }
                }
                var cs = _context.Cases.FirstOrDefault(c => c.ID == Convert.ToInt32(ItemID));
                if (cs != null)
                {
                    if (shoppingCart != null)
                    {
                        shoppingCart.CaseID = Convert.ToInt32(ItemID);
                        _context.SaveChanges();
                        var item = _context.Cases.FirstOrDefault(c => c.ID == Convert.ToInt32(ItemID));
                        BoughtCase.Add(item);
                    }
                }
                var pw = _context.Powers.FirstOrDefault(c => c.ID == Convert.ToInt32(ItemID));
                if (pw != null)
                {
                    if (shoppingCart != null)
                    {
                        shoppingCart.PowerSupplyID = Convert.ToInt32(ItemID);
                        _context.SaveChanges();
                        var item = _context.Powers.FirstOrDefault(c => c.ID == Convert.ToInt32(ItemID));
                        BoughtPower.Add(item);
                    }
                }
            OnGet();
            }
    }
}
