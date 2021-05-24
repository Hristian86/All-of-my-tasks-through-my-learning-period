using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Senior.Task.Common.Models;

namespace Senior.Task.Domains.Entities
{
    public class Employee : BaseDeletableModel<int>
    {
        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Company { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(120)]
        public string Project { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Role { get; set; }
    }
}