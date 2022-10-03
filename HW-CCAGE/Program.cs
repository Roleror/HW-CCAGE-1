using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_CCAGE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Александр Блок");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Ночь, улица, фонарь, аптека");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ночь, улица, фонарь, аптека,\r\nБессмысленный и тусклый свет.\r\nЖиви еще хоть четверть века —\r\nВсё будет так. Исхода нет.\r\n\r\nУмрешь — начнешь опять сначала\r\nИ повторится всё, как встарь:\r\nНочь, ледяная рябь канала,\r\nАптека, улица, фонарь.");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
