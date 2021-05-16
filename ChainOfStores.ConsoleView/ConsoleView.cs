using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.Console
{
    public class ConsoleView
    {
        public void Run()
        {
            bool continueRunning = true;
            while (continueRunning)
            {

                WriteListOfCommand();
                System.Console.WriteLine();

                System.Console.Write(">>");
                string command = System.Console.ReadLine();
                System.Console.WriteLine();

                continueRunning = ProcessCommand(command);
               
                System.Console.WriteLine();
            }
        }
        private void WriteListOfCommand()
        {
            System.Console.WriteLine("1 - show list of products");
            System.Console.WriteLine("2 - show list of shop with this product");
            System.Console.WriteLine("3 - book product");
            System.Console.WriteLine("4 - show list of booking");
            System.Console.WriteLine("5 - remoove booking");
            System.Console.WriteLine("6 - close program");
        }

        private bool ProcessCommand(string command)
        {
            bool continueRunning = true;
            if (command == "1")
            {
            }
            else if (command == "2")
            {

            }
            else if (command == "3")
            {

            }
            else if (command == "4")
            {

            }
            else if (command == "5")
            {

            }
            else if (command == "6")
            {
                continueRunning = false;
            }
            else
            {
                System.Console.WriteLine("wrong command");
            }
            return continueRunning;
        }
    }

}
