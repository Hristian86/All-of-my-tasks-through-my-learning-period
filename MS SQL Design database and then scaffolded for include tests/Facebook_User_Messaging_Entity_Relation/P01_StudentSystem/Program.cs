using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Data;
using P01_StudentSystem.Data.Data;

namespace P01_StudentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentSystemContext())
            {
                //context.Database.Migrate();
                //context.Add(new User
                //{
                //    Name = "Gencho"
                //});
                //context.Add(new User
                //{
                //    Name = "Pencho"
                //});
                //context.SaveChanges();


                var participants1 = context.User
                    .Where(x => x.Name == "Gencho")
                    .FirstOrDefault();

                var participants2 = context.User
                   .Where(x => x.Name == "Pencho")
                   .FirstOrDefault();

                //// Creating convarsation party
                //var conversation = context.Add(new Conversation()
                //{
                //    UserOne = participants1.UserId,
                //    UserTwo = participants2.UserId,
                //    Ip = "123.1231.3123"
                //});
                //context.SaveChanges();

                //// Adding some messages in tables
                //var replay = context.Add(new ConversationReply()
                //{
                //    Conversation = conversation.Entity,
                //    ConversationId = conversation.Entity.Id,
                //    User = participants1,
                //    UserId = participants1.UserId,
                //    Reply = "Hello my friend"
                //});
                //context.SaveChanges();

                //// Answer to the text
                //var conversatio1 = context.Add(new Conversation()
                //{
                //    UserOne = participants1.UserId,
                //    UserTwo = participants2.UserId,
                //    Ip = "123.1231.3123"
                //});
                //context.SaveChanges();

                //var replays = context.Add(new ConversationReply()
                //{
                //    Conversation = conversatio1.Entity,
                //    ConversationId = conversatio1.Entity.Id,
                //    User = participants2,
                //    UserId = participants2.UserId,
                //    Reply = "Im fine and you"
                //});
                //context.SaveChanges();


                var user = context.Conversations.
                    Where(x => x.UserOne == 1 && x.UserTwo == 2)
                    .Select(x => x.ConversationReply).ToList();

                foreach (var item in user)
                {
                    foreach (var ite in item)
                    {
                        Console.WriteLine(ite.User.Name.Trim() + " Message: " + ite.Reply.Trim());
                    }
                }


                Console.ReadLine();







                //// add message
                //var msg1 = context.Add(new Message()
                //{
                //    Content = "What's up friend",
                //    // send to
                //    RecipeintId = participants1.Id,
                //});

                //context.SaveChanges();

                //var part1 = context.Add(new Participant()
                //{
                //    UserId = participants2.Id,
                //    Users = participants2,
                //    MessageId = msg1.Entity.Id,
                //    Messages = msg1.Entity,
                //});
                //context.SaveChanges();
                //// end of adding the message

                //// next message to add
                //var msg2 = context.Add(new Message()
                //{
                //    Content = "Nothing interesting!!!",
                //    RecipeintId = participants2.Id,
                //});

                //context.SaveChanges();

                //var part2 = context.Add(new Participant()
                //{
                //    UserId = participants1.Id,
                //    Users = participants1,
                //    MessageId = msg2.Entity.Id,
                //    Messages = msg2.Entity,
                //});
                //context.SaveChanges();
                //// end

            }
        }
    }
}
