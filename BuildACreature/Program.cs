using System;
using System.Threading;

namespace ExquisiteCorpse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of head for your creature? ghost, monster or bug?");
            string head = Console.ReadLine().ToLower();

            Console.WriteLine("What type of body for your creature? ghost, monster or bug?");
            string body = Console.ReadLine().ToLower();

            Console.WriteLine("What type of feet for your creature? ghost, monster or bug?");
            string feet = Console.ReadLine().ToLower();

            Console.WriteLine("Generating your creature...");

            Thread.Sleep(3000);
            Console.WriteLine("Gluing the feet together...");
            Thread.Sleep(3000);
            Console.WriteLine("Prepearing presentation...");
            Thread.Sleep(3000);

            BuildACreature(head, body, feet);
        }

        static void BuildACreature(string head = "", string body = "", string feet = "")
        {

            // if param is not defined, assign random value between 1 & 3.
            Random randomNumber = new Random();

            // initialize variables
            int headNum;
            int bodyNum;
            int feetNum;

            if (head == "")
            {
                string emptyHead;
                emptyHead = randomNumber.Next(1, 4).ToString();

                switch (emptyHead)
                {
                    case "1":
                        emptyHead = "ghost";
                        break;
                    case "2":
                        emptyHead = "monster";
                        break;
                    case "3":
                        emptyHead = "bug";
                        break;
                }

                headNum = TranslateToNumber(emptyHead);
            }
            else
            {
                headNum = TranslateToNumber(head);

            }

            if (body == "")
            {
                string emptyBody;
                emptyBody = randomNumber.Next(1, 4).ToString();

                switch (emptyBody)
                {
                    case "1":
                        emptyBody = "ghost";
                        break;
                    case "2":
                        emptyBody = "monster";
                        break;
                    case "3":
                        emptyBody = "bug";
                        break;

                }
                bodyNum = TranslateToNumber(emptyBody);
            }
            else
            {
                bodyNum = TranslateToNumber(body);
            }

            if (feet == "")
            {
                string emptyFeet;
                emptyFeet = randomNumber.Next(1, 4).ToString();

                switch (emptyFeet)
                {
                    case "1":
                        emptyFeet = "ghost";
                        break;
                    case "2":
                        emptyFeet = "monster";
                        break;
                    case "3":
                        emptyFeet = "bug";
                        break;

                }
                feetNum = TranslateToNumber(emptyFeet);
            }
            else
            {
                feetNum = TranslateToNumber(feet);
            }

            SwitchCase(headNum, bodyNum, feetNum);


        }

        static void RandomMode()
        {
            Random randomNumber = new Random();

            int head = randomNumber.Next(1, 4);
            int body = randomNumber.Next(1, 4);
            int feet = randomNumber.Next(1, 4);

            SwitchCase(head, body, feet);
        }

        static void SwitchCase(int head, int body, int feet)
        {
            switch (head)
            {
                case 1:
                    GhostHead();
                    break;
                case 2:
                    MonsterHead();
                    break;
                case 3:
                    BugHead();
                    break;
            }

            switch (body)
            {
                case 1:
                    GhostBody();
                    break;
                case 2:
                    MonsterBody();
                    break;
                case 3:
                    BugBody();
                    break;
            }

            switch (feet)
            {
                case 1:
                    GhostFeet();
                    break;
                case 2:
                    MonsterFeet();
                    break;
                case 3:
                    BugFeet();
                    break;
            }

        }

        static int TranslateToNumber(string creature)
        {

            return creature switch
            {
                "ghost" => 1,
                "bug" => 2,
                "monster" => 3,
                _ => 1,
            };
        }
        static void GhostHead()
        {
            Console.WriteLine("     ..-..");
            Console.WriteLine("    ( o o )");
            Console.WriteLine("    |  O  |");
        }

        static void GhostBody()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
        }

        static void GhostFeet()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    '~~~~~'");
        }

        static void BugHead()
        {
            Console.WriteLine("     /   \\");
            Console.WriteLine("     \\. ./");
            Console.WriteLine("    (o + o)");
        }

        static void BugBody()
        {
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
        }

        static void BugFeet()
        {
            Console.WriteLine("     v   v");
            Console.WriteLine("     *****");
        }

        static void MonsterHead()
        {
            Console.WriteLine("     _____");
            Console.WriteLine(" .-,;='';_),-.");
            Console.WriteLine("  \\_\\(),()/_/");
            Console.WriteLine("　  (,___,)");
        }

        static void MonsterBody()
        {
            Console.WriteLine("   ,-/`~`\\-,___");
            Console.WriteLine("  / /).:.('--._)");
            Console.WriteLine(" {_[ (_,_)");
        }

        static void MonsterFeet()
        {
            Console.WriteLine("    |  Y  |");
            Console.WriteLine("   /   |   \\");
            Console.WriteLine("   \"\"\"\" \"\"\"\"");
        }
    }
}
