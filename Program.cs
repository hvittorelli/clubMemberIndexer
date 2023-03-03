using System;
using System.Drawing;

namespace clubMemberIndexer
{
    class Program
    {
        public const int Size = 15;  // global variable
        class ClubMembers
        {
            private string[] Members = new string[Size];
            public string ClubType { get; set; }
            public string ClubLocation { get; set; }
            public string MeetingDate { get; set; }
            
            public ClubMembers()
            {
                for (int i = 0; i < Size; i++)
                {
                    Members[i] = string.Empty;
                }
                ClubType = string.Empty;
                ClubLocation = string.Empty;
                MeetingDate = string.Empty;
            }

            public string this[int x]
            { 
                get 
                {
                    string temp;
                    
                    if (x >=0 && x <= Size -1)
                    {
                        temp = Members[x];
                    }
                    else
                    {
                        temp = "";
                    }
                        return temp; 
                } 
                set
                {
                    if (x >= 0 && x <= Size -1) 
                    {
                        Members[x] = value;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            ClubMembers Member = new ClubMembers();
            bool done = false; 
            while (!done) 
            {
                int sub = 0;
                while (sub < 1 || sub > Size) 
                { 
                    Console.WriteLine($"Which club member do you want to enter? (Enter 1 - {Size})");
                    while (!int.TryParse(Console.ReadLine(), out sub))
                        Console.WriteLine($"Enter a value 1-{Size}");
                }
                Console.WriteLine("Enter the name of the club member:");
                Member[sub - 1] = Console.ReadLine();
                Console.WriteLine("Press any key to continue or q to stop");
                string end = Console.ReadLine();
                if (end == "q")
                    done = true;
            }
            Console.WriteLine("What type of club are these members a part of?");
            Member.ClubType = Console.ReadLine();
            Console.WriteLine("Where is the club located?");
            Member.ClubLocation = Console.ReadLine();
            Console.WriteLine("What day of the week does the club meet?");
            Member.MeetingDate = Console.ReadLine();

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Here is the clubs information:");
            Console.WriteLine("Club Members:");
            for (int i = 0; i < Size; i++)
            {
                if (Member[i] != string.Empty)
                    Console.WriteLine(Member[i]);
            }
            Console.WriteLine($"Club Type: {Member.ClubType}");
            Console.WriteLine($"Club Location: {Member.ClubLocation}");
            Console.WriteLine($"Meeting Day: {Member.MeetingDate}");
        }
    }
}