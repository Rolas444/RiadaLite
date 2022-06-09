using RiadaLite.Models.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RiadaLite.Models.Members
{
    public class Admonition
    {
        [Key]
        public int Id { get; set; }
        public string Detail { get; set; }
        public DateTime InDate { get; set; }
        public DateTime EndDate { get; set; }

        [ForeignKey("Persona")]
        public int PersonaId { get; set; }
        public Persona Persona { get; set; }
    }
}
