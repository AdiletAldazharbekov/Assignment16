using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace AsyncBreakfast
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Team team1 = new Team();
            //Team team2 = new Team();
            //Team team3 = new Team();
            //Team team4 = new Team();



            Console.WriteLine("Start!\n");

            


            Task<Team> team1 = Start(1);
          

            Task<Team> team2 = Start(2);
           

            Task<Team> team3 = Start(3);
            

            Task<Team> team4 = Start(4);
          

            await Task.Delay(15000);


            Console.WriteLine("All teams finished!");


        }


        private static async Task<Team> Start(int teamNumber)
        {
            var timer = Stopwatch.StartNew();
            double teamSpeed;
            Random random = new Random();
            int speed=random.Next(1, 4);
            for (int i = 1; i <= 4; i++)
            {
                await Task.Delay(speed * 1000);
                Console.WriteLine($"{i}-runner finished ({teamNumber}-team)");
            }
            timer.Stop();
            teamSpeed = timer.Elapsed.TotalSeconds;
            Console.WriteLine($"\n{teamNumber}-Team Finished,\ttime: {teamSpeed: 0.00} sec.");
            return new Team();
        }
    }

    internal class Team
    {
       
    }
}