/**
* 9/17/2023
* CSC 253
* Group 1
* Group Members:Daniel Parks, Drew Tadlock
* Mud Game for CSC 253. DUNGON CRAWLER MEETS ATOMIC DISASTER
* 
* Moduel 1
* 
* 
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace NomadLibrary
{
    public class Menu
    {

        public int SelectedIndex;
        public string[] Options;
        public string Prompt;

        public Menu(string prompt, string[] options)
        {
            Prompt = prompt;
            Options = options;
            SelectedIndex = 0;
        }
        private void DisplayOptions()
        {
            WriteLine(Prompt);
            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];
                string prefix;

                if (i == SelectedIndex)
                {
                    prefix = "#";
                    ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    prefix = " ";
                    ForegroundColor = ConsoleColor.Gray;
                }


                WriteLine($"                                                   {prefix}    <<{currentOption} >>    {prefix} ");
            }
            ResetColor();
        }
        public int RunMenu()
        {
            ConsoleKey keyPressed;
            do
            {
                Clear();
                WriteLine(@"


           


             █████╗ ████████╗ ██████╗ ███╗   ███╗██╗ ██████╗    ███╗   ██╗ ██████╗ ███╗   ███╗ █████╗ ██████╗ 
            ██╔══██╗╚══██╔══╝██╔═══██╗████╗ ████║██║██╔════╝    ████╗  ██║██╔═══██╗████╗ ████║██╔══██╗██╔══██╗
            ███████║   ██║   ██║   ██║██╔████╔██║██║██║         ██╔██╗ ██║██║   ██║██╔████╔██║███████║██║  ██║
            ██╔══██║   ██║   ██║   ██║██║╚██╔╝██║██║██║         ██║╚██╗██║██║   ██║██║╚██╔╝██║██╔══██║██║  ██║
            ██║  ██║   ██║   ╚██████╔╝██║ ╚═╝ ██║██║╚██████╗    ██║ ╚████║╚██████╔╝██║ ╚═╝ ██║██║  ██║██████╔╝
            ╚═╝  ╚═╝   ╚═╝    ╚═════╝ ╚═╝     ╚═╝╚═╝ ╚═════╝    ╚═╝  ╚═══╝ ╚═════╝ ╚═╝     ╚═╝╚═╝  ╚═╝╚═════╝ 
                                                                                                  


            
                                          Use the ARROW keys to select your option.
                                            Press ENTER to finalize your choice.



");
                DisplayOptions();

                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;

                if (keyPressed == ConsoleKey.UpArrow)
                {
                    SelectedIndex--;
                    if (SelectedIndex == -1)
                    {
                        SelectedIndex = Options.Length - 1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    SelectedIndex++;
                    if (SelectedIndex == Options.Length)
                    {
                        SelectedIndex = 0;
                    }
                }

            } while (keyPressed != ConsoleKey.Enter);




            return SelectedIndex;
        }



    }


}
