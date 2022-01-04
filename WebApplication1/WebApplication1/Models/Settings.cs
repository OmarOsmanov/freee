using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Settings
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Logo { get; set; }
        [MaxLength(150)]
        public string Location { get; set; }
        [MaxLength(50)]
        public string HomeTiitle { get; set; }
        [MaxLength(500)]
        public string HomeSubTitle { get; set; }
        [MaxLength(50)]
        public string ProfileImage { get; set; }
    }
}
