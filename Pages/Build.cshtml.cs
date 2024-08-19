using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ElectraASP.Models;

namespace ElectraASP.Pages
{
    public class BuildModel : PageModel
    {
        public List<Computer> ComputerList { get; set; }
        private readonly ThisContext _context;

        public BuildModel(ThisContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            this.ComputerList = _context.Computers.ToList();
        }
    }
}
