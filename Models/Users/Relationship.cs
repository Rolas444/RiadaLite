using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RiadaLite.Models.Users
{
    public class Relationship
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }


    }
}
