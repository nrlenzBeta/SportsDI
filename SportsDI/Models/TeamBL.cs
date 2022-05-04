using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsDI.Interfaces;

namespace SportsDI.Models
{
    public class TeamBL
    {
        public ITeam team;

        public TeamBL(ITeam team)
        {
            this.team = team;
        }

        public List<Team> GetAllTeams()
        {
            return team.SelectAllTeams();
        }
    }
}
