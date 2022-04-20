using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGameVIDO
{
    internal class ScoreDetail
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }

        public DateTime Times { get; set; }

        public ScoreDetail()
        {

        }

        public ScoreDetail(string sName, int iScore, DateTime dtTimes)
        {
            this.Name = sName;
            this.Score = iScore;
            this.Times = dtTimes;
        }
    }
}
