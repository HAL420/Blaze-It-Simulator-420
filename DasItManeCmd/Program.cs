using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DasItManeCmd
{
    class Program
    {
        static void DoIt() {
             string strIntro =
"  ______            _____ _    ___  ___\n" +
"  |  _  \\          |_   _| |   |  \\/  |\n" +
"  | | | |__ _ ___    | | | |_  | .  . | __ _ _ __   ___ \n" +
"  | | | / _` / __|   | | | __| | |\\/| |/ _` | '_ \\ / _ \\ \n" +
"  | |/ / (_| \\__ \\  _| |_| |_  | |  | | (_| | | | |  __/ \n" +
"  |___/ \\__,_|___/  \\___/ \\__| \\_|  |_/\\__,_|_| |_|\\___|\n" +
"            [ 420 Blaze It Simulator 2014 ]";
            string strQuestion = "You see a dank ass blunt chilaxing on the edge of your table.\nDo you toke it? [Y/N]";
            string answer;
            ConsoleKeyInfo cki;
            string strResultYes = "- Yeah.\nDas it mane.";
            string strResultNo = "- Nah.\nWow. Gay.";
            string strUnknown = "Come again?";
            string strRestart = "Restart? [Y/N]";

            Console.Clear();
            Console.WriteLine("\n" + strIntro + "\n");
            Console.WriteLine(strQuestion);
            do
            {
                answer = Console.ReadKey(true).Key.ToString();
                if (answer == "Y")
                {
                    Console.WriteLine(strResultYes);
                    break;
                }
                else if (answer == "N")
                {
                    Console.WriteLine(strResultNo);
                    break;
                }
                else
                {
                    Console.WriteLine(strUnknown);
                }
            } while (true);
            Console.ReadKey(true);
            Console.WriteLine("\n" + strRestart);
            answer = Console.ReadKey(true).Key.ToString();
            if (answer == "Y")
            {
                DoIt();
            }
        }
        static void Main(string[] args)
        {
            Console.Title = "Das It Mane: 420 Blaze It Simulator 2014";
            DoIt();
        }
    }
}
