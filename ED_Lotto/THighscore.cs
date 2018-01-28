using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_Lotto
{
    class THighscore
    {

        private THighscore()
        {

        }

        private static THighscore highscore = new THighscore();

        public static THighscore getInstance()
        {
            return highscore;
        }

        public struct Players
        {
            public string name;
            public int points;
        }

        Players[] ahighscore = new Players[4];


        public Players[] Ahighscore
        {
            get { return ahighscore; }
            set { ahighscore = value; }
        }



    }
}
