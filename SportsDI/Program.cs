using SportsDI.Models;
using Microsoft.Extensions.DependencyInjection;

namespace SportsDI
{
    class Program
    {
        static void Main(string[] args)
        {
            TeamBL teamBL = new TeamBL(new TeamDAL());
            List<Team> teams = teamBL.GetAllTeams();

            foreach (Team team in teams)
            {
                Console.WriteLine("ID = {0}, Sport = {1}, City = {2}, Nickname = {3}", team.ID, team.Sport, team.City, team.Nickname);
            }
            Console.ReadKey();
        }
    }
}