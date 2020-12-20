using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace P01_StudentSystem.Data.Models
{
    public class ConversationReply
    {
        [Key]
        public int Id { get; set; }

        public string ReplayText { get; set; }

        [ForeignKey("UserId")]
        public int User_fkId { get; set; }

        public virtual User User_fk { get; set; }

        public int ConversationId { get; set; }

        public virtual Conversation Conversation { get; set; }
    }
}
