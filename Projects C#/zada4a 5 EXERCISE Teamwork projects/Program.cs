using System;
using System.Linq;
using System.Collections.Generic;

namespace zada4a_5_EXERCISE_Teamwork_projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<Teams> arengetTeams = new List<Teams>();
            List<string> nubs = new List<string>();
            string names = "";

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split("-").ToArray();
                string name = input[0];
                string teamName = input[1];

                if (Contains(arengetTeams, name, teamName))
                {
                    Teams teaming = new Teams
                    {
                        Members = name,
                        NameOfTeam = teamName,
                        Memberses = new List<string>()
                    };
                    arengetTeams.Add(teaming);

                    Console.WriteLine($"Team {teamName} has been created by {name}!");
                }
            }
            var filteredList = new List<Teams>();
            while (true)
            {
                string[] addNames = Console.ReadLine().Split("->");
                string name = addNames[0];
                if (addNames[0] == "end of assignment")
                {
                    break;
                }
                string temName = addNames[1];
               
                if (IncludetMembers(arengetTeams, name, temName))
                {
                    if (Contains2(arengetTeams, name, temName))
                        if (arengetTeams.Any(x => x.NameOfTeam.Equals(temName)))
                        {
                            Teams current = arengetTeams.FirstOrDefault(x => x.NameOfTeam.Equals(temName));

                            if (current.Memberses.Contains(name) && current.Members == (name))
                            {
                                Console.WriteLine($"Member {name} cannot join team {temName}!");
                            }
                            else
                            {
                                current.Memberses.Add(name);
                            }
                        }

                }
                else if (arengetTeams.Any(x => x.NameOfTeam.Equals(temName) && x.Members.Equals (name) ))
                {
                    Console.WriteLine($"Member {name} cannot join team {temName}!");
                }
                else if (!(arengetTeams.Any(x => x.NameOfTeam.Equals(temName))))
                {
                    Console.WriteLine($"Team {temName} does not exist!");
                }
                
            }

            arengetTeams = arengetTeams.OrderByDescending(x => x.Memberses.Count).ThenBy(x => x.Members).ToList();
         
            foreach (var item in arengetTeams)
            {    
                if (item.Memberses.Count == 0)
                {
                    names += (item.NameOfTeam) + Environment.NewLine;
                }
                else
                {
                    Console.WriteLine(item.NameOfTeam);
                    Console.WriteLine($"- {item.Members}");
                    item.Memberses = item.Memberses.OrderBy(x => x).ToList();
                    foreach (var name in item.Memberses)
                    { 
                        Console.WriteLine($"-- {name}");
                    }
                }
            }

            Console.WriteLine($"Teams to disband:");
            Console.WriteLine("{0}",names,Environment.NewLine);
        }
        static bool IncludetMembers(List<Teams> arengetTeams, string name, string teamName)
        {
            //bool isTrue = false;
            foreach (var item in arengetTeams)
            {
                if (item.NameOfTeam == teamName && item.Members != name && !(item.Memberses.Contains(name)))
                {
                    return true;
                }
            }
            return false;
        }
        static void Objective(List<Teams> arengetTeams, string name, string teamName)
        {
            Teams teaming = new Teams
            {

                Members = name,
                NameOfTeam = teamName,
                Memberses = new List<string>()

            };
            arengetTeams.Add(teaming);
        }
        static bool Contains2(List<Teams> arengetTeams, string name, string teamName)
        {
            bool isTrue = true;
            foreach (var item in arengetTeams)
            {

                if (item.Members == name && item.NameOfTeam == teamName)
                {
                    Console.WriteLine($"Member {name} cannot join team {teamName}!");
                    isTrue = false;
                }
            }
            return isTrue;
        }
    
        static bool Contains(List<Teams> arengetTeams, string name, string teamName)
        {
            bool isTrue = true;
            foreach (var item in arengetTeams)
            {

                if (item.Members == name)
                {
                    Console.WriteLine($"Member {name} cannot join team {teamName}!");
                    isTrue = false;
                }
                else if (item.NameOfTeam == teamName)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    isTrue = false;
                }
            }
            return isTrue;
        }

    }

    class Teams
    {

        public string Members { get; set; }

        public string NameOfTeam { get; set; }

        public List<string> Memberses { get; set; }

    }
}
