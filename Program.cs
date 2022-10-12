using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemProject2022
{
    internal class Program
    {
        //HUD variables

        static int health;

        static int shield;

        static int lives;

        static float score;

        static float scoreMultiplier;

        static string healthStatus;


        static void Main(string[] args)
        {
            ShowHUD();
        }

        



        //Show the HUD

        static void ShowHUD()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("=========================================");
            Console.WriteLine("========== Here are your stats ==========");
            Console.WriteLine("=========================================");
            Console.WriteLine("=             " + healthStatus + "           ");
            Console.WriteLine("=                                        ");
            Console.WriteLine("=      Health: " + health + "            Shield: " + shield);
            Console.WriteLine("=                                       =");
            Console.WriteLine("=      Lives: " + lives + "              Score: " + score);
            Console.WriteLine("=                                       =");
            Console.WriteLine("=          Score Multiplier: " +  scoreMultiplier);
            Console.WriteLine("=                                       =");
            Console.WriteLine("=========================================");


            Console.ReadKey();
        }



        //Health Status Check System


        static void healthStatusCheck()
        {
            if (health == 100)
            {
                healthStatus = "Full Health";
            }

            else if (health >= 76 && health <=99)
            {
                healthStatus = "Good Health";
            }

            else if (health >= 51 && health <=75)
            {
                healthStatus = "Okay Health";
            }

            else if (health >= 26 && health <=50)
            {
                healthStatus = "Damaged";
            }

            else if (health >= 11 && health <= 25)
            {
                healthStatus = "=== !WARNING! ===";
            }

            else if (health >= 1 && health <= 10)
            {
                healthStatus = "=== !!!CRITICAL!!! ===";
            }
                
            
        }


        



        

    }
}
