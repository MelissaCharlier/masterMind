using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masterMind
{
    class Program
    {
        static void Main(string[] args)
        {
            Game g = new Game();
            Memory m = new Memory();

            // Entrer dans le jeu 
            Console.WriteLine("MasterMind ! \nSerez-vous plus fort que la machine ? \n Tapez 'y' pour commencer la partie et 'n' pour quitter le jeu");
            g.onOff = Console.ReadLine().ToLower();
            do
            { 
                if (g.onOff == "y")
                    {
                    Console.WriteLine("Choisiez votre niveau de douleur : \n 1 (5 chiffres mystères)\n 2 (10 chiffres mystères)\n 3 (15 chiffres)");
                    int.TryParse(Console.ReadLine(), out g.level);
                    Console.WriteLine(g.level);
                    string choice = (g.CheckLevel());
                    string choices = "";
                    do
                    {
                        if (choice == "true" || choices == "true")
                        {
                            // Choisir level
                            g.ChooseLevel();
                            // Créer la playerList correspondante 
                            g.LevelPlayerList();
                            Console.WriteLine("Jouons ! ");
                            //Tant que les deux listes ne correspondent pas 
                            bool again = g.Finish();
                            do
                            {
                                Console.WriteLine("Entrez votre proposition : ");
                                int.TryParse(Console.ReadLine(), out g.prop);
                                string D = g.CheckProp(g.prop);
                                Console.WriteLine("test D"+D);
                                string E = "";
                                do
                                {
                                    Console.WriteLine("test E"+E);
                                    if (D == "true" || E == "true")
                                    {
                                        g.Testing();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ce que vous avez entré ne correspond pas à la demande, veuillez réessayer");
                                        int.TryParse(Console.ReadLine(), out g.prop);
                                        E = g.CheckProp(g.prop);
                                    }
                                } while (D != "true" && E != "true"); // Procédure récurante => méthode
                                Console.ReadLine();
                               
                                again = g.Finish();
                                Console.WriteLine("bool"+again);
                            } while (again == true);
                            Console.WriteLine("Trouvé en " + " coups");
                        }
                        else
                        {
                            Console.WriteLine("Le choix indiqué ne fait pas partie de ceux possibles. \n Veuillez introduire 1, 2 ou 3 selon le niveau de difficulté souhaitée");
                            int.TryParse(Console.ReadLine(), out g.level); 
                            choices = (g.CheckLevel());
                        }
                    }
                    while (choice != "true" && choices!= "true");
                }
                else if (g.onOff == "n")
                {
                    Console.WriteLine("Merci à bientôt !");
                }
               
                else
                {
                    Console.WriteLine("Vous n'utlisez pas le code instauré. \nUtilisez 'y' pour lancer le jeu et 'n' pour quitter la console");
                    g.onOff = Console.ReadLine().ToLower();
                }
            } while (g.onOff != "y" && g.onOff != "n");

          
        }
    }
}
