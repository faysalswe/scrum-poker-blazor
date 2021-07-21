using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ScrumPoker.Model
{
    public class Room
    {
        public string Id { get; set; }
        public bool IsShowPoint { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}