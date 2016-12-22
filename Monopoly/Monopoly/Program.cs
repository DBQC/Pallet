using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Monopoly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Time to Play Monopoly!");
            Console.WriteLine("Choose how many players, up to four...");
            Console.Read();
        }
        /// <summary>
        /// Example Hotfix work done
        /// </summary>
        /// <returns></returns>
        static int Rolls()
        {
            int roll = DateTime.Now.Second;
            return roll;
        }

        

        static void AssignPlayers()
        {
            int numberOfPlayers;
        }
    }
}
