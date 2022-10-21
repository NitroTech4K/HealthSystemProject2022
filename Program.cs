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
            FullHUDReset();

            deathcheck();

            ShowHUD();


            TakeDamage(50);

            deathcheck();

            ShowHUD();



            TakeDamage(100);

            deathcheck();

            ShowHUD();


            Medkit(100);
            shieldcell(100);

            deathcheck();

            ShowHUD();


        }



        //Show the HUD

        static void ShowHUD()
        {

            healthStatusCheck();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("=========================================");
            Console.WriteLine("========== Here are your stats ==========");
            Console.WriteLine("=========================================");
            Console.WriteLine("=         " + healthStatus + "           ");
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

        static void FullHUDReset()
        {
            health = 100;
            shield = 100;
            lives = 3;
            score = 0;
            scoreMultiplier = 1;

            healthStatusCheck();
        }

        
        
        //Health Status Check System

        static void healthStatusCheck()
        {
            if (health == 100)
            {
                healthStatus = "Full Health";
            }

            else if (health >= 76 && health <= 99)
            {
                healthStatus = "Good Health";
            }

            else if (health >= 51 && health <= 75)
            {
                healthStatus = "Okay Health";
            }

            else if (health >= 26 && health <= 50)
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

        //Medkits and shield kits

        static void Medkit(int heal)
        {

            Console.WriteLine("== Player is about to heal " + heal + " health. ==");

            health = health + heal;

            if (heal < 0)
            {
                heal = 0;
                Console.WriteLine("Cannot heal health with negative values! You're looking for damage. :)");
            }

            if (health > 100)
            {
                health = 100;
            }
        }

        static void shieldcell(int charge)
        {

            Console.WriteLine("== Player is about to charge " + charge + " shield points. ==");

            shield = shield + charge;

            if (charge < 0)
            {
                charge = 0;
                Console.WriteLine("Cannot charge shields with negative values! You're looking for damage. :)");
            }

            if (shield > 100)
            {
                shield = 100;
            }
        }







       //Enemie hit functions 

       static void TakeDamage(int damage)
        {

            Console.WriteLine("== Player is about to take " + damage + " damage. ==");

            if (damage > 0)
            {
                if (shield > 0)
                {
                    shield = shield - damage;

                    if (shield < 0)
                    {
                        health = health + shield;
                        shield = 0;
                    }
                }

                else if (shield == 0)
                {
                    health = health - damage;
                }

                healthStatusCheck();
            }
           

            else if (shield == 0)
            {
                health = health - damage;
            }

            if (damage < 0)
            {
                Console.WriteLine("ERROR! The enemieDamage value you set is " + damage + ". Damage values cannot be in negative values. " +
                    "Set the damage to how much damage the player is taking, NOT how much health is being lost. :)");
            }

        }

        



        //Check if dead
        static void deathcheck()
        {
            if (health == 0)
            {
                lives = lives - 1; 
                
                healthShieldReset();
            }

            if (lives < 0)
            {
                lives = 0;
                Console.WriteLine("ERROR! Lives cannot equal negative values. When you're dead, you're DEAD! :)");
            }

            if (lives == 0)
            {
                gameOverScreen();
            }
        }


        //Health & Shield Reset.

        static void healthShieldReset()
        {
            health = 100;
            shield = 100;
        }

        //Game over
        static void gameOverScreen()
        {
            Console.WriteLine("          ===============");
            Console.WriteLine("        ===================");
            Console.WriteLine("       =====================");
            Console.WriteLine("      =======================");
            Console.WriteLine("     =========================");
            Console.WriteLine("     ========= R.I.P =========");
            Console.WriteLine("     ===-----Game Over-----===");
            Console.WriteLine("     =========================");
            Console.WriteLine("     =========================");
            Console.WriteLine("     === Please restart to ===");
            Console.WriteLine("     ====== play again. ======");
            Console.WriteLine("     =========================");
            Console.WriteLine("     =========================");
            Console.WriteLine("     =========================");
            Console.WriteLine("     =========================");
            Console.WriteLine("     =========================");
            Console.WriteLine("     =========================");

            Console.ReadKey(true);

        }
        



        

    }
}
