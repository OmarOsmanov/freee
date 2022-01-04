using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ContactMe
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(200)]
        public string FullName { get; set; }
        [MaxLength(200)]

        public string Email { get; set; }
        [MaxLength(50)]

        public string PhoneNumber { get; set; }
        [Column(TypeName = "nText")]
        public string Message { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
