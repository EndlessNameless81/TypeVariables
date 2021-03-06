﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 130;
            Console.WindowHeight = 60;

            string mgr = "Тип {0,8} |\t.NET {1,8} |\tРазмер = {2} \t| MIN = {3,30}\t| MAX = {4}";

            Console.Title = "Типы данных в C#";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\t\t\tЧИСЛОВЫЕ (целочисленные) ТИПЫ:\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(string.Format(mgr,"byte",typeof(byte).Name,sizeof(byte),byte.MinValue,byte.MaxValue));
            Console.WriteLine(string.Format(mgr, "sbyte", typeof(sbyte).Name, sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue));
            Console.WriteLine(string.Format(mgr, "short", typeof(short).Name, sizeof(short), short.MinValue, short.MaxValue));
            Console.WriteLine(string.Format(mgr, "ushort", typeof(ushort).Name, sizeof(ushort), ushort.MinValue, ushort.MaxValue));
            Console.WriteLine(string.Format(mgr, "int", typeof(int).Name, sizeof(int), int.MinValue, int.MaxValue));
            Console.WriteLine(string.Format(mgr, "uint", typeof(uint).Name, sizeof(uint), uint.MinValue, uint.MaxValue));
            Console.WriteLine(string.Format(mgr, "long", typeof(long).Name, sizeof(long), long.MinValue, long.MaxValue));
            Console.WriteLine(string.Format(mgr, "ulong", typeof(ulong).Name, sizeof(ulong), ulong.MinValue, ulong.MaxValue));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t\t\t\t\tЧИСЛОВЫЕ (с плавающей точкой) ТИПЫ:\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(string.Format(mgr, "float", typeof(float).Name, sizeof(float), float.MinValue, float.MaxValue));
            Console.WriteLine(string.Format(mgr, "double", typeof(double).Name, sizeof(double), double.MinValue, double.MaxValue));
            Console.WriteLine(string.Format(mgr, "decimal", typeof(decimal).Name, sizeof(decimal), decimal.MinValue, decimal.MaxValue));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t\t\t\t\tСИМВОЛЬНЫЕ ТИПЫ:\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(string.Format(mgr, "char", typeof(char).Name, sizeof(char), char.MinValue, char.MaxValue));
            Console.WriteLine(string.Format(mgr, "string", typeof(string).Name, "N/A", "N/A", "N/A"));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t\t\t\t\tЛОГИЧЕСКИЕ ТИПЫ:\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(string.Format(mgr, "bool", typeof(bool).Name, sizeof(bool), bool.FalseString, bool.TrueString));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t\t\t\t\tОСОБЫЕ ТИПЫ:\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(string.Format(mgr, "object", typeof(object).Name, "N/A", "N/A", "N/A"));
            Console.WriteLine(string.Format(mgr, "dynamic", "N/A", "N/A", "N/A", "N/A"));

            Console.Read();

        }
    }
}

