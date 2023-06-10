using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Trenirovka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string taskManagerPath = Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\Taskmgr.exe";
           // string taskManagerPath = "C:\\Windows\\System32\\Taskmgr.exe";
            while (true)
            {
                Process[] taskManagerProcesses = Process.GetProcessesByName("Taskmgr");
                if (taskManagerProcesses.Length == 0)
                {
                    try
                    {
                        Process.Start(taskManagerPath);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Не удалось запустить Диспетчер задач: " + ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Диспетчер задач уже запущен.");
                }
                Thread.Sleep(5000);
            }
        }
    }
}
