using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masterMind
{
    class Board
    {
        Game g = new Game();
        //Affichage de la solution
        public string PrintPath()
        {
            string toPrint = "";
            foreach (int answer in g.playerList)
            {
                if (answer == 0)
                {
                    toPrint += "*";
                }
                else
                {
                    toPrint += answer.ToString();
                }
            }
            return toPrint;
        }


    }
}
