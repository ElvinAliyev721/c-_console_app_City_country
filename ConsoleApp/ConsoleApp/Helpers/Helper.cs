﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class Helper
    {
        public static void Alert(ConsoleColor color,string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }

    public enum Menu
    {
        CreateGroup=1,
        CreateStudent,
        StudentList,
        FindStudent
    }
}
