using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsDI.Interfaces;

namespace SportsDI.Models
{
    public class TeamDAL : ITeam
    {
        public List<Team> SelectAllTeams()
        {
            List<Team> teams = new List<Team>();
            teams.Add(new Team() { ID = 1, Sport = "Football", City = "Dallas", Nickname = "Cowboys" });
            teams.Add(new Team() { ID = 2, Sport = "Baseball", City = "Chicago", Nickname = "White Sox" });
            teams.Add(new Team() { ID = 3, Sport = "Basketball", City = "Oklahoma City", Nickname = "Thunder" });
            teams.Add(new Team() { ID = 4, Sport = "Soccer", City = "Portland", Nickname = "Timbers" });

            return teams;
        } 
    }
}
