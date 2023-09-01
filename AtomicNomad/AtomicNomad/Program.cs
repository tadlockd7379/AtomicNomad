/**
* 8/25/2023
* CSC 253
* Group 1
* Group Members: David Jones, Daniel Parks, Drew Tadlock
* Mud Game for CSC 253. DUNGON CRAWLER MEETS ATOMIC DISASTER
* 
* 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using NomadLibrary;

using AtomicNomad.game;

namespace AtomicNomad
{
    class Program
    {
        static void Main(string[] args)
        {

            Title = "Atomic Nomad";
            CursorVisible = false;


            Intro IntroToGame = new Intro();
            IntroToGame.GameIntro();

            bool shouldExit = false;

            do
            {


                string prompt = "";
                string[] options = { " play ", " about", " exit " };
                Menu mainMenu = new Menu(prompt, options);
                int selectedIndex = mainMenu.RunMenu();


                switch (selectedIndex)
                {
                    case 0:
                        RunFirstOption();
                        break;
                    case 1:
                        AboutInfo();
                        break;
                    case 2:
                        ExitGame();
                        break;
                }

                Clear();
            } while (!shouldExit);




            void ExitGame()
            {
                WriteLine("                                                   Press any key to exit...");
                ReadKey(true);
                Environment.Exit(0);
            }



            void AboutInfo()
            {
                Clear();
                WriteLine(@"                                 


                                           Some info about the group goes here.



                   The path of the righteous man is beset on all sides by the inequities of the selfish 
                   and the tyranny of evil men. Blessed is he who, in the name of charity and good will, 
                   shepherds the weak through the valley of darkness, for he is truly his brother's keeper 
                   and the finder of lost children. And I will strike down upon thee with great vengeance 
                   and furious anger those who attempt to poison and destroy my brothers. And you will 
                   know my name is the Lord when I lay my vengeance upon thee.


                                               Press any key to continue...


");
                ReadKey();
                Clear();

            }
            void RunFirstOption()
            {
                Clear();
                new Game();
            }
        }
    }
}