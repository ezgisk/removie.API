using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace removie.Models.Entities
{
    [Table("Film")]
    public class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
