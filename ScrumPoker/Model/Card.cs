﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ScrumPoker.Model
{
    public class Card
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double Point { get; set; }
    }
}
