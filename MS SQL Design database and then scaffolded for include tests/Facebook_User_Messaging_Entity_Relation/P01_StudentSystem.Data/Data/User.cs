using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P01_StudentSystem.Data.Data
{
    public partial class User
    {
        public User()
        {
            ConversationReply = new HashSet<ConversationReply>();
            ConversationUserOneNavigation = new HashSet<Conversation>();
            ConversationUserTwoNavigation = new HashSet<Conversation>();
        }

        [Key]
        [Column("user_id")]
        public int UserId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [InverseProperty("User")]
        public virtual ICollection<ConversationReply> ConversationReply { get; set; }

        [InverseProperty(nameof(Conversation.UserOneNavigation))]
        public virtual ICollection<Conversation> ConversationUserOneNavigation { get; set; }
        [InverseProperty(nameof(Conversation.UserTwoNavigation))]
        public virtual ICollection<Conversation> ConversationUserTwoNavigation { get; set; }
    }
}
