using System;

namespace Inheritance3
{
    class Program
    {
        static void Main(string[] args)
        {
            TeamName T = new Baseball("abc");
            T.PrintName();
            Console.WriteLine("Hello World!");
            Baseball dodgers = new Baseball("Royals");
            dodgers.totalLosses = 4;
            dodgers.totalWins = 8;
            Sport sport = new Baseball("Dodgers");
            sport.totalLosses = 3;
            sport.totalWins = 9;
            Console.WriteLine($"{sport.WinLossRatio()}");
            Console.WriteLine($"{sport.WinLossRatio(4)}");
        }
    }
    public class Sport
    {
        public string TeamName { get; set; }
        public int maxPlayers;
        public int totalWins;
        public int totalLosses;
        public string[] rules;
        public Sport(string name)
        {
            TeamName = name;
        }

        public Sport()
        {
        }

        public virtual string WinLossRatio()
        {
            return $"Your team win ratio is {totalWins / totalLosses}!";
        }

        public virtual string WinLossRatio(int tie)
        {
            return $"Your team win ratio is {totalWins / totalLosses} and {tie} ties!";
        }
    }

    public interface TeamName
    {
        public void PrintName();
    }

    public class Baseball : Sport, TeamName
    {
        public Baseball(string name) : base()
        {
            TeamName = name;
        }

        public void PrintName()
        {
            Console.WriteLine($"baseball Team: {this.TeamName}");
        }

        public override string WinLossRatio()
        {
            return $"Your Baseball team win ratio is {totalWins / totalLosses}!";
        }
        public override string WinLossRatio(int tie)
        {
            return $"Your Baseball team win ratio is {totalWins / totalLosses} and {tie} ties!";
        }
    }
























}

