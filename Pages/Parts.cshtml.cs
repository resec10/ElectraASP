using ElectraASP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace ElectraASP.Pages
{
    public class PartsModel : PageModel
    {
        public required string LinkName { get; set; }
        [BindProperty] public required string ToBeSent { get; set; }
        public required List<Part> Items { get; set; }
        public List<Part> ToBeBought { get; set; }
        public readonly ThisContext _context;

        public PartsModel(ThisContext context)
        {
            _context = context;

        }
        public IActionResult OnGet(string name)
        {
            LinkName = name;
            switch(LinkName)
            {
                case "Case": Items=_context.Cases.ToList<Part>(); break;
                case "Cooler": Items= _context.Coolers.ToList<Part>(); break;
                case "CPU": Items=_context.CPU_Table.ToList<Part>(); break;
                case "Motherboard": Items=_context.Motherboards.ToList<Part>(); break;
                case "Power": Items=_context.Powers.ToList<Part>(); break;
                case "RAM": Items=_context.RAM_Table.ToList<Part>(); break;
                case "SSD": Items=_context.SSD_Table.ToList<Part>(); break;
                case "VideoCard": Items=_context.VideoCards.ToList<Part>(); break;
                default: return NotFound();
            }
            return Page();
        }
    }
}
