using ElectraASP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Storage.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace ElectraASP.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ThisContext _context;
        public List<Computer> ComputerList { get; set; }

        public IndexModel(ILogger<IndexModel> logger, ThisContext context)
        {
            _logger = logger;
            _context = context;

        }


        public void OnGet()
        {
            ComputerList=_context.Computers.ToList();
        }
    }
}
