using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class PortFolio
    {
        [Key]
        public int PortfolioId { get; set; }
        [MaxLength(250),Required]
        public string PortTittle { get; set; }
        [Column(TypeName = "nText"),Required]
        public string PortContent { get; set; }
        [MaxLength(1000)]
        public string PortImage { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
