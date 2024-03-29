﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] drive = DriveInfo.GetDrives();
            foreach (DriveInfo d in drive)
            {
                Console.WriteLine("Название {0}", d.Name);
                if (d.IsReady)
                {
                    Console.WriteLine("Объём диска: {0}", d.TotalSize);
                    Console.WriteLine("Свободно: {0}", d.AvailableFreeSpace);
                }
            }
            Console.ReadKey();
        }
    }
}
