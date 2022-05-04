using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsDI.Models;

namespace SportsDI.Interfaces
{
    public interface ITeam
    {
        List<Team> SelectAllTeams();
    }
}
