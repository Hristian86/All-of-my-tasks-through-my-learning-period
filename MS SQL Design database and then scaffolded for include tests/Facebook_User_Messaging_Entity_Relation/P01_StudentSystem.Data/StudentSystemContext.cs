using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Data.Data;

namespace P01_StudentSystem.Data
{
    public class StudentSystemContext : DbContext
    {
        private readonly string connectionString = "Server=.\\SQLEXPRESS;Database=Messaging_System;Trusted_Connection=True;";

        public DbSet<User> User { get; set; }

        public DbSet<ConversationReply> ConversationReplies { get; set; }

        public DbSet<Conversation> Conversations { get; set; }

        public StudentSystemContext()
        {
        }

        public StudentSystemContext(DbContextOptions<StudentSystemContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Conversation>(entity =>
            {
                entity.Property(e => e.Ip).IsFixedLength();

                entity.HasOne(d => d.UserOneNavigation)
                    .WithMany(p => p.ConversationUserOneNavigation)
                    .HasForeignKey(d => d.UserOne)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Conversation_User1");

                entity.HasOne(d => d.UserTwoNavigation)
                    .WithMany(p => p.ConversationUserTwoNavigation)
                    .HasForeignKey(d => d.UserTwo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Conversation_User");
            });

            modelBuilder.Entity<ConversationReply>(entity =>
            {
                entity.Property(e => e.Reply).IsFixedLength();

                entity.HasOne(d => d.Conversation)
                    .WithMany(p => p.ConversationReply)
                    .HasForeignKey(d => d.ConversationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_conversation_reply_conversation_reply");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ConversationReply)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_conversation_reply_User");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Name).IsFixedLength();
            });

            //modelBuilder.Entity<User>()
            //    .HasMany(c => c.Conversations)
            //    .WithOne(u => u.UserOne)
            //    .HasForeignKey(a => a.UserOneId);

            //modelBuilder.Entity<User>()
            //    .HasMany(c => c.Conversations)
            //    .WithOne(u => u.UserTwo)
            //    .HasForeignKey(a => a.UserTwoId);

            //modelBuilder.Entity<User>()
            //    .HasMany(c => c.ConversationReplies)
            //    .WithOne(u => u.User_fk)
            //    .HasForeignKey(a => a.User_fkId);

            //modelBuilder.Entity<Conversation>()
            //    .HasOne(c => c.UserOne)
            //    .WithMany(u => u.Conversations)
            //    .HasForeignKey(a => a.ConversationId);


            //modelBuilder.Entity<Conversation>()
            //    .HasOne(c => c.UserTwo)
            //    .WithMany(u => u.Conversations)
            //    .HasForeignKey(a => a.ConversationId);


            //modelBuilder.Entity<Participant>().HasKey(t => new { t.UserId, t.MessageId });

            //modelBuilder.Entity<Participant>()
            //            .HasOne(t => t.Users)
            //            .WithMany(t => t.Participants)
            //            .HasForeignKey(t => t.UserId);


            //modelBuilder.Entity<Participant>()
            //            .HasOne(t => t.Messages)
            //            .WithMany(t => t.Participants)
            //            .HasForeignKey(t => t.MessageId);
        }
    }
}
