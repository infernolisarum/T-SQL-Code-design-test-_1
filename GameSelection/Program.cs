using System;
using System.Linq;

namespace GameSelection
{
    class Program
    {

        public static GameStatistics statistics1 = new GameStatistics
        {
                        TeamName = Teams.Green.ToString(),
                        GameDate = new DateTime(2019, 01, 01),
                        Score = 0
        };

        public static GameStatistics statistics2 = new GameStatistics
        {
                        TeamName = Teams.Green.ToString(),
                        GameDate = new DateTime(2019, 01, 02),
                        Score = 0
        };

        public static GameStatistics statistics3 = new GameStatistics
        {
                        TeamName = Teams.Green.ToString(),
                        GameDate = new DateTime(2019, 01, 03),
                        Score = 1
        };

        public static GameStatistics statistics4 = new GameStatistics
        {
                        TeamName = Teams.Green.ToString(),
                        GameDate = new DateTime(2019, 01, 04),
                        Score = 2
        };

        public static GameStatistics statistics5 = new GameStatistics
        {
                        TeamName = Teams.Green.ToString(),
                        GameDate = new DateTime(2019, 01, 05),
                        Score = 2
        };

        public static GameStatistics statistics6 = new GameStatistics
        {
                        TeamName = Teams.Green.ToString(),
                        GameDate = new DateTime(2019, 01, 06),
                        Score = 0
        };

        public static GameStatistics statistics7 = new GameStatistics
        {
                        TeamName = Teams.Green.ToString(),
                        GameDate = new DateTime(2019, 01, 07),
                        Score = 1
        };

        public static GameStatistics statistics8 = new GameStatistics
        {
                        TeamName = Teams.Green.ToString(),
                        GameDate = new DateTime(2019, 01, 08),
                        Score = 1
        };

        public static GameStatistics statistics9 = new GameStatistics
        {
                        TeamName = Teams.Green.ToString(),
                        GameDate = new DateTime(2019, 01, 09),
                        Score = 0
        };

        public static GameStatistics statistics10 = new GameStatistics
        {
                        TeamName = Teams.Green.ToString(),
                        GameDate = new DateTime(2019, 01, 10),
                        Score = 1
        };

        public static GameStatistics statistics11 = new GameStatistics
        {
                        TeamName = Teams.Green.ToString(),
                        GameDate = new DateTime(2019, 01, 11),
                        Score = 2
        };

        public static GameStatistics statistics12 = new GameStatistics
        {
                        TeamName = Teams.Green.ToString(),
                        GameDate = new DateTime(2019, 01, 12),
                        Score = 1
        };

        public static GameStatistics statistics13 = new GameStatistics
        {
                        TeamName = Teams.Green.ToString(),
                        GameDate = new DateTime(2019, 01, 13),
                        Score = 0
        };

        public static GameStatistics statistics14 = new GameStatistics
        {
                        TeamName = Teams.Green.ToString(),
                        GameDate = new DateTime(2019, 01, 14),
                        Score = 0
        };

        public static GameStatistics statistics15 = new GameStatistics
        {
                        TeamName = Teams.Green.ToString(),
                        GameDate = new DateTime(2019, 01, 15),
                        Score = 2
        };

        public static GameStatistics statistics16 = new GameStatistics
        {
                        TeamName = Teams.Green.ToString(),
                        GameDate = new DateTime(2019, 01, 16),
                        Score = 3
        };

        public static GameStatistics statistics17 = new GameStatistics
        {
                        TeamName = Teams.Green.ToString(),
                        GameDate = new DateTime(2019, 01, 17),
                        Score = 0
        };

        public static GameStatistics statistics18 = new GameStatistics
        {
                        TeamName = Teams.Green.ToString(),
                        GameDate = new DateTime(2019, 01, 18),
                        Score = 2
        };

        public static GameStatistics statistics19 = new GameStatistics
        {
                        TeamName = Teams.Green.ToString(),
                        GameDate = new DateTime(2019, 01, 19),
                        Score = 0
        };

        public static GameStatistics statistics20 = new GameStatistics
        {
                        TeamName = Teams.Green.ToString(),
                        GameDate = new DateTime(2019, 01, 20),
                        Score = 4
        };

        static void Main(string[] args)
        {
            //using (GameSelectionDBContext gameSelection = new GameSelectionDBContext())
            //{
            //    gameSelection.GameStatistics.Add(statistics1);
            //    gameSelection.GameStatistics.Add(statistics2);
            //    gameSelection.GameStatistics.Add(statistics3);
            //    gameSelection.GameStatistics.Add(statistics4);
            //    gameSelection.GameStatistics.Add(statistics5);
            //    gameSelection.GameStatistics.Add(statistics6);
            //    gameSelection.GameStatistics.Add(statistics7);
            //    gameSelection.GameStatistics.Add(statistics8);
            //    gameSelection.GameStatistics.Add(statistics9);
            //    gameSelection.GameStatistics.Add(statistics10);
            //    gameSelection.GameStatistics.Add(statistics11);
            //    gameSelection.GameStatistics.Add(statistics12);
            //    gameSelection.GameStatistics.Add(statistics13);
            //    gameSelection.GameStatistics.Add(statistics14);
            //    gameSelection.GameStatistics.Add(statistics15);
            //    gameSelection.GameStatistics.Add(statistics16);
            //    gameSelection.GameStatistics.Add(statistics17);
            //    gameSelection.GameStatistics.Add(statistics18);
            //    gameSelection.GameStatistics.Add(statistics19);
            //    gameSelection.GameStatistics.Add(statistics20);

            //    gameSelection.SaveChanges();
            //}

            //using (GameSelectionDBContext gameSelection = new GameSelectionDBContext())
            //{
            //    var statistics = gameSelection.GameStatistics.ToList();

            //    gameSelection.RemoveRange(statistics);

            //    gameSelection.SaveChanges();
            //}

            using (GameSelectionDBContext gameSelection = new GameSelectionDBContext())
            {
                var statistics = gameSelection.GameStatistics.ToList();

                foreach (GameStatistics game in statistics)
                {
                    Console.WriteLine($"{game.TeamName}, {game.GameDate},"
                        + $" {game.Score}");
                }
            }
        }
    }
}
