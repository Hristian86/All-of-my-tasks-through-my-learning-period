using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace P01_StudentSystem.Data.Models
{
    public class User
    {
        public User()
        {
            this.Conversations = new HashSet<Conversation>();
            this.ConversationReplies = new HashSet<ConversationReply>();
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [InverseProperty("User")]
        public virtual ICollection<ConversationReply> ConversationReply { get; set; }

        [InverseProperty(nameof(Conversation.UserOne))]
        public virtual ICollection<Conversation> Conversations { get; set; }

        [InverseProperty(nameof(Conversation.UserTwo))]
        public virtual ICollection<ConversationReply> ConversationReplies { get; set; }
    }
}
