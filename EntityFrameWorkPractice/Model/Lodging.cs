using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityFrameWorkPractice.Model
{
    public class Lodging
    {
        [Key]
        public int LogdingId { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public bool IsResort { get; set; }
        public Destination Destination { get; set; }
    }
}