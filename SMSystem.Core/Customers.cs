﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SMSystem.Core
{
    public class Customers
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string location { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }

        // Navigation
        public virtual List<ConscienceCard> conscienceCards { get; set; }
    }
}
