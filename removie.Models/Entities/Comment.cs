using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace removie.Models.Entities
{
    [Table("Comment")]
    public class Comment
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public DateTime CreationTime { get; set; }
        public string Description { get; set; }
        public int FilmId { get; set; }
        public Film Film { get; set; }
        public int RateId { get; set; }
        public Rate Rate { get; set; }

    }
}
