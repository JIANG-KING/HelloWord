using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace HelloWord
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("这是我的第一个C#程序");
            //Console.ReadLine();

           // ConsoleColor console1 = ConsoleColor.DarkBlue;
            //string s = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Title = "king";
            Console.WriteLine("这是我的第一个C#程序"/*+Console.Title*/);


            Console.ForegroundColor = ConsoleColor.Yellow;


            Console.WriteLine("这是我的第一个C#程序"/*+Console.Title*/);

            Console.ForegroundColor = ConsoleColor.Green;


            Console.WriteLine("这是我的第一个C#程序"/*+Console.Title*/);

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("这是我的第一个C#程序"/*+Console.Title*/);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("这是我的第一个C#程序"/*+Console.Title*/);

            //Process.Start("C:\\Windows\\System32\\cmd.exe");
            Console.ReadLine();
        }
    }
}
