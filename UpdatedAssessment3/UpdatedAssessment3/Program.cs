
using System;
using System.Collections.Generic;

namespace my3rdAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            string strOption;
            string response;


            List<string> skillsNidhi = new List<string>() { "Problem Solving", "Organization", "Time Management", "Microsoft Office" };
            List<string> skillsHuy = new List<string>() { "Writing", "Research", "Time Management", "Microsoft Office", "Computers", "Leadership" };

            SiftMember sm1 = new SiftMember("Nidhi Gusain", new DateTime(2020, 08, 14), "Associate Software Engineer in Training", "nidhigusain@rocketmortgage.com", skillsNidhi);
            SiftMember sm2 = new SiftMember("Huy Phan", new DateTime(2019, 11, 11), "Team Leader", "huyphan@rocketmortgage.com", skillsHuy);

            List<SiftMember> siftMembersList = new List<SiftMember>() { sm1, sm2 };

            do
            {

                Console.WriteLine("Welcome to Sift, what would you like to do?");
                Console.WriteLine("1. Add a team member\n2. Search for a team member and add skills\n3. Print all members\n4. Quit");
                Console.Write("\nSelect an option: ");
                strOption = Console.ReadLine();
                int.TryParse(strOption, out int option);

                while (option != 1 && option != 2 && option != 3 && option != 4)
                {
                    Console.WriteLine("Wrong input.");
                    Console.WriteLine("Enter 1 or 2 or 3 or 4");
                    strOption = Console.ReadLine();
                    int.TryParse(strOption, out option);
                }

                if (option == 1)
                {
                    AddTeamMember(siftMembersList);

                }

                if (option == 2)
                {
                    SearchMemberAddSkill(siftMembersList);
                }


                if (option == 3)
                {
                    foreach (SiftMember item in siftMembersList)
                    {
                        Console.WriteLine(item.ToString());

                    }
                }

                if (option == 4)
                {
                    Console.WriteLine("Goodbye!");
                    return;
                }



                Console.Write("\n\nContinue? (y/n): ");
                response = Console.ReadLine().ToLower();
                while (response != "y" && response != "n")
                {
                    Console.Write("Enter y or n: ");
                    response = Console.ReadLine().ToLower();
                }

            } while (response == "y");

            Console.WriteLine("Goodbye!");
        }

        public static void AddTeamMember(List<SiftMember> memberlist)
        {
            Console.Write("Enter the team member's name: ");
            string name = Console.ReadLine();
            Console.Write("Enter their job titile: ");
            string jobTitle = Console.ReadLine();
            Console.Write("Enter their email: ");
            string email = Console.ReadLine();
            Console.Write("Enter their anniversary: ");
            string anniversary = Console.ReadLine();
            DateTime.TryParse(anniversary, out DateTime userDateTime);

            Console.Write("Enter their skills: ");
            string skills = Console.ReadLine();
            List<string> skillsList = new List<string>
            {
                string.Join(",", skills)
            };
            SiftMember newMember = new SiftMember(name, userDateTime, jobTitle, email, skillsList);
            memberlist.Add(newMember);

        }

        public static void SearchMemberAddSkill(List<SiftMember> siftMembersList)
        {
            string memberName;
            bool present;

            Console.Write("Enter the full name of the person you'd like to search for: ");
            memberName = Console.ReadLine();
            present = IsMemberPresent(siftMembersList, memberName);

            while (!present)
            {
                Console.WriteLine("\nWrong input.");
                Console.Write("Enter the full name of the person you'd like to search for: ");
                memberName = Console.ReadLine();
                present = IsMemberPresent(siftMembersList, memberName);

            }

            SiftMember memberToUpdate = null;
            foreach (var item in siftMembersList)
            {
                if (item.GetName().ToLower() == memberName.ToLower())
                {
                    memberToUpdate = item;
                    break;
                }
            }
            string skill;

            do
            {
                Console.Write("Enter a skill, enter 'q' to stop adding skills: ");
                skill = Console.ReadLine().ToLower();
                if (skill == "q")
                {
                    break;
                }

                if (memberToUpdate.AddSkill(skill) == false)
                {
                    Console.WriteLine($"{skill} already added.");
                }
                else
                {
                    Console.WriteLine($"{skill} added.");
                }

            } while (skill != "q");

            return;

        }


        public static bool IsMemberPresent(List<SiftMember> siftMembersList, string memberName)
        {

            if (siftMembersList.Exists(x => x.GetName().ToLower() == memberName.ToLower()))
            {
                return true;
            }
            else
            {
                return false;
            }

        }


    }


}

class SiftMember
{
    private string _Name;
    private DateTime _AnniversaryDate;
    private string _JobTitle;
    private string _Email;
    private List<string> _Skills;

    public SiftMember()
    {

    }
    public SiftMember(string name, DateTime anniversaryDate, string jobTitle, string email, List<string> skills)
    {
        _Name = name;
        _AnniversaryDate = anniversaryDate;
        _JobTitle = jobTitle;
        _Email = email;
        _Skills = skills;
    }

    public string GetName()
    {
        return _Name;
    }

    public bool AddSkill(string skill)
    {
        if (_Skills.Contains(skill) == false)
        {
            _Skills.Add(skill);
            //Console.WriteLine($"{skill} added!");
            return true;
        }
        else
        {
            return false;
        }

    }

    public override string ToString()
    {
        return $"\nName: {_Name}\nJob Title: {_JobTitle}\nEmail: {_Email}\nSkills: {string.Join(", ", _Skills)}";
    }





}
