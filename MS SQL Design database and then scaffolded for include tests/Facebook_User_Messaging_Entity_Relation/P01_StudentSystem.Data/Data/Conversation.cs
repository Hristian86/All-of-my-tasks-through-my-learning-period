using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P01_StudentSystem.Data.Data
{
    public partial class Conversation
    {
        public Conversation()
        {
            ConversationReply = new HashSet<ConversationReply>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("user_one")]
        public int UserOne { get; set; }
        [Column("user_two")]
        public int UserTwo { get; set; }
        [Column("ip")]
        [StringLength(20)]
        public string Ip { get; set; }

        [ForeignKey(nameof(UserOne))]
        [InverseProperty(nameof(User.ConversationUserOneNavigation))]
        public virtual User UserOneNavigation { get; set; }

        [ForeignKey(nameof(UserTwo))]
        [InverseProperty(nameof(User.ConversationUserTwoNavigation))]
        public virtual User UserTwoNavigation { get; set; }

        [InverseProperty("Conversation")]
        public virtual ICollection<ConversationReply> ConversationReply { get; set; }
    }
}
