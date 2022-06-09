using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RiadaLite.Models.Ubigeo
{
    public class Departamento
    {
        [Key]
        public int Id { get; set; }
        public string ubigeo { get; set; }
        public string name { get; set; }
    }
}
