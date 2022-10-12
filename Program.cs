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


        //Enemie Values

      

        //Main program
        static void Main(string[] args)
        {
            HUDResetValues();
            healthStatusCheck();
            ShowHUD();

        }



        //Show the HUD

        static void ShowHUD()
        {
            Console.WriteLine();
            Console.WriteLine();
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
            Console.WriteLine();
            Console.WriteLine();


            Console.ReadKey();
        }


        //HUD reset vaules quick command

        static void HUDResetValues()
        {
            health = 100;
            shield = 100;
            lives = 3;
            score = 0;
            scoreMultiplier = 1;
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
            
        
       //Enemie hit functions 

       static void enemieHitPlayerFunctions(int enemieDamage)
        {
            if (shield > 0)
            {
                shield = shield - enemieDamage;

                if (shield < 0)
                {
                    health = health + shield;
                    shield = 0;
                }
            }

            else if (shield == 0)
            {
                health = health - enemieDamage;
            }


        }

        



        

    }
}
