using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var race = new StrategyContext(new BigLeadStrategy());
            race.SetRaceStrategy();
            Console.WriteLine("Did we win: {0}", race.Strategy.DidIWin.ToString());

            race = new StrategyContext(new SneakStrategy());
            race.SetRaceStrategy();
            Console.WriteLine("Did we win: {0}", race.Strategy.DidIWin.ToString());

            race = new StrategyContext(new SteadyStrategy());
            race.SetRaceStrategy();
            Console.WriteLine("Did we win: {0}", race.Strategy.DidIWin.ToString());

            Console.ReadKey();
        }
    }
}
