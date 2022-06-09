using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RiadaLite.Models.Users
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string DocumentId { get; set; }
        public string TypeDocumentId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string LastName2 { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }
        public DateTime BaptismDate { get; set; }
        
    }
}
