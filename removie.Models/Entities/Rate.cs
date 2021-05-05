using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace removie.Models.Entities
{
    [Table("Rate")]
    public class Rate
    {
        public int Id { get; set; }
        public int Value { get; set; }
    }
}
