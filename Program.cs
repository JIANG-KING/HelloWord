using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("这是我的第一个C#程序");
            //Console.ReadLine();
            //string s = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkBlue;//设置控制台字体颜色
            Console.BackgroundColor = ConsoleColor.Red;//设置背景色
            Console.Title = "king";//设置控制台标题
            Console.WriteLine("这是我的第一个C#程序");//输出语句
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("这是我的第一个C#程序");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("这是我的第一个C#程序");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("这是我的第一个C#程序");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("这是我的第一个C#程序");
            //Process.Start("C:\\Windows\\System32\\cmd.exe");//启动电脑内自带软件
            Console.ReadLine();
        }
    }
}
