using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P01_StudentSystem.Data.Data
{
    [Table("conversation_reply")]
    public partial class ConversationReply
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("reply")]
        [StringLength(100)]
        public string Reply { get; set; }

        [Column("user_id")]
        public int UserId { get; set; }

        [Column("conversationId")]
        public int ConversationId { get; set; }

        [ForeignKey(nameof(ConversationId))]
        [InverseProperty("ConversationReply")]
        public virtual Conversation Conversation { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty("ConversationReply")]
        public virtual User User { get; set; }
    }
}
