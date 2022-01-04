using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(150)]
        public string Fulname { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        [MaxLength(100)]
        public string Phone { get; set; }
        [MaxLength(150)]
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<PortFolio> PortFolios { get; set; }
    }
}
