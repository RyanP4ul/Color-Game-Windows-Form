using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorGame.Models
{
    public class GameStatistics
    {

        public int TotalPlayed { get; set; } = 0;
        public int TotalWins { get; set; } = 0;
        public int TotalLoses { get; set; } = 0;
        public int BiggestWins { get; set; } = 0;

    }
}
