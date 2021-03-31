using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ScrumPoker.Model
{
    public class Card
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public double Point { get; set; }

        [ForeignKey("Room")]
        public int RoomId { get; set; }
        public Room Room { get; set; }
    }
}
