using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Threading;

namespace MultipleRoblox
{
    internal class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to Roblox Multi-Instance!\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("--- INSTRUCTIONS ---\n 1. Close all Roblox instances\n 2. Press any key to activate Multi-Instance");
            System.Console.ReadKey();
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Activating ROBLOX_singletonMutex...");
            new Mutex(true, "ROBLOX_singletonMutex");
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Made by MiningTcup, some credit to MainDabRblx\n\n--- NOTES ---\nYou may now open as many Roblox instances as you like, ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("using seperate accounts");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(". If you close this window, all Roblox instances except for one will close. Make sure that you closed all Roblox instances before activating this.\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Roblox Multi-Instance is now activated!\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Please do not close this window.");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(-1);
        }
    }
}
