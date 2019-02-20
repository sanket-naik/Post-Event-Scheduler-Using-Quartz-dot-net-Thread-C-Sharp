using Quartz.Job;
using Quartz.Quartz;
using System;

namespace Quartz
{
    class Program
    {
        static void Main(string[] args)
        {
            string cMonth = DateTime.Now.ToString("dd/MM");
            Console.WriteLine("Current Date Is: DAY/MONTH= "+cMonth);
            Console.WriteLine("Your Cron Will Be Triggered Once The Date Given in Jobs.cs & Time Matches The Present Date...");
            Console.WriteLine("Your Can Modify Time On Scheduler.cs By Changing Cron Expression...");
            Console.WriteLine("Generate Cron Expression @ http://www.cronmaker.com/ \n");

            GenerateXml ge = new GenerateXml();
            ge.write();

            Scheduler sc = new Scheduler();
            sc.Schedule();

            Console.ReadKey();
        }
    }
}
