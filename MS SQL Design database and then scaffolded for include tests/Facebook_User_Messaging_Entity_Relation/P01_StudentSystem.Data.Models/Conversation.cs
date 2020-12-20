using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace P01_StudentSystem.Data.Models
{
    public class Conversation
    {
        public Conversation()
        {
        }

        [Key]
        public int Id { get; set; }

        [ForeignKey("UserId"),Column(Order = 0)]
        public int UserOneId { get; set; }

        public User UserOne { get; set; }

        [ForeignKey("UserId"), Column(Order = 1)]
        public int UserTwoId { get; set; }

        public User UserTwo { get; set; }
    }
}
