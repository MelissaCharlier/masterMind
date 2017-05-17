using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masterMind
{
    class Game
    {
        public string onOff;
        public int level;
        //public int cpM;
        public int prop;
        public List<int> guessTList = new List<int>();
        public List<int> playerList = new List<int>();
        public int longList;



        //Vérifier choix du niveau 
        public string CheckLevel()
        {
            string checkL = "true";
            if (this.level != 1 && this.level != 2 && this.level != 3)
            {
                checkL = "false";
            }
            return checkL;
        }

        //Choisir le niveau
        public void ChooseLevel()
        {
            switch (this.level)
            {
                case 1: MyRd(5);
                    longList = 5;
                    break;
                case 2: MyRd(10);
                    break;
                case 3: MyRd(15);
                    break;
            }
        }

        // Lancer le Random
        public List<int> MyRd(int longList)
        {
            int ndRand;
            Random random = new Random();
           
            for (int i = 0; i < longList; i++)
            {
                ndRand = random.Next(1, 9);
                this.guessTList.Add(ndRand);
            }
            return guessTList;
        }

        //public string Test ()
        //{
        //    string test = "";
        //    foreach(int guess in guessTList)
        //    {
        //        string g = guess.ToString();
        //        test = test + " ," + g; 
        //    }
        //    return test;
        //}

        // Donner les mêmes capacités aux playerList qu'au guessTList
        public void LevelPlayerList()
        {
            switch (this.level)
            {
                case 1:
                    FillPlayerList(5);
                    break;
                case 2:
                    FillPlayerList(10);
                    break;
                case 3:
                    FillPlayerList(15);
                    break;
            }
        }

        // Remplissage PlayerList
        public void FillPlayerList (int longList)
        {
            for (int i = 0; i < longList; i++)
            {
                this.playerList.Add(0);
            }
        }

        // Vérification proposition
        public string CheckProp (int prop)
        {
            string checkP = "";
            if (this.prop >=1 && this.prop <= 9)
            { 
                checkP = "true";
            }
            else
            {
                checkP = "false";
            }
            return checkP;
        }

        // Comparaison des propostions avec la guessTList
        public void Testing()
        {
           int cpT = 0;
           for(int i=0; i< this.guessTList.Count(); i++)
            {
                cpT++;
                if (this.guessTList[i] == this.prop)
                {
                    this.playerList[i] = this.prop;
                }
             }

        }

        //Vérification playerList complète 
        public bool Finish()
        {
            bool equal = this.guessTList.SequenceEqual(this.playerList);
            if (equal == true)
            {
                return true;
            }
            return true;
        }
       
    }
 }
