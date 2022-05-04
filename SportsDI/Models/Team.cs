using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsDI.Interfaces;

namespace SportsDI.Models
{
    public class Team
    {
        public int ID { get; set; }
        public string Sport { get; set; }
        public string City { get; set; }
        public string Nickname { get; set; }
    }
}
