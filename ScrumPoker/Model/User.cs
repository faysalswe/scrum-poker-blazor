using ScrumPoker.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ScrumPoker.Model
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        [Required]
        [RegexValidator(Pattern = @"\s|[A-Z]")]
        public string UserName { get; set; }
        [Required]
        public string FullName { get; set; }
        public double Point { get; set; }
        public bool IsAdmin { get; set; }

        [ForeignKey("Room")]
        public string RoomId { get; set; }
        public Room Room { get; set; }

    }
}
