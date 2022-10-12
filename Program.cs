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

        static int score;





        static void Main(string[] args)
        {
            ShowHUD();
        }

        



        //Show the HUD

        static void ShowHUD()
        {
            Console.WriteLine("========== Here are your stats ==========");
            Console.WriteLine("=");
            Console.WriteLine("=      Health: " + health + "            Shield: " + shield);
            Console.WriteLine("=");
            Console.WriteLine("=      Lives: " + lives + "              Score: " + score);
            Console.WriteLine("=                                      ");


            Console.ReadKey();
        }





        

    }
}
