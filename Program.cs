using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Threading;

namespace MultipleRoblox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Welcome to Roblox Multi-Instance!\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("You must close all Roblox instances before continuing or the hack will not work.\nPress any key when you have closed all Roblox instances: ");
            System.Console.ReadKey();
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Activating ROBLOX_singletonMutex...");
            new Mutex(true, "ROBLOX_singletonMutex");
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Activation Complete\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--NOTES--");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("You may now open as many Roblox instances as you like, using sperate accounts.\nIf you close this window, all but 1 Roblox instance will close.\nBy MiningTcup\nCredits to MainDabRblx (Github). ");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(-1);
        }
    }
}