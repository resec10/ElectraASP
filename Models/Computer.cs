using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ElectraASP.Models
{
    public class Computer
    {
        [Key] public int ID { get; set; }
        [Required] public string Title { get; set; }
        [Required] public string Subtitle { get; set; }
        [Required] public string ImageLink { get; set; }

        public Computer(int id, string title, string subtitle, string imageLink)
        {
            ID = id;
            Title = title;
            Subtitle = subtitle;
            ImageLink = imageLink;
        }

        public Computer()
        {
            ID = 1;
            Title = "";
            Subtitle = "";
            ImageLink = "";
        }
    }
}
