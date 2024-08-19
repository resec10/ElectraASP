using ElectraASP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ElectraASP.Pages
{
    public class ItemModel : PageModel
    {
        private readonly ThisContext _context;
        public List<Computer> ComputerList { get; set; }
        public Computer computer { get; set; }
        public List<Part> Parts { get; set; }
        public int BuyID { get; set; }

        public ItemModel(ThisContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(int id)
        {
            BuyID = id;
            ComputerList = _context.Computers.ToList();
            Parts = new List<Part>();
            computer = _context.Computers.FirstOrDefault(x => x.ID == id);
            Parts.Add(_context.CPU_Table.FirstOrDefault(c => c.ID == id)); //0
            Parts.Add(_context.Cases.FirstOrDefault(c => c.ID == id)); //1
            if(_context.Coolers.FirstOrDefault(x => x.ID == id) != null)
                Parts.Add(_context.Coolers.FirstOrDefault(c => c.ID == id)); //2
            Parts.Add(_context.Motherboards.FirstOrDefault(c => c.ID == id)); //3
            Parts.Add(_context.Powers.FirstOrDefault(c => c.ID == id)); //4
            Parts.Add(_context.RAM_Table.FirstOrDefault(c => c.ID == id)); //5
            Parts.Add(_context.SSD_Table.FirstOrDefault(c => c.ID == id)); //6
            Parts.Add(_context.VideoCards.FirstOrDefault(c=>c.ID==id)); //7
            if (computer == null) return NotFound();
            return Page();
        }
    }
}
