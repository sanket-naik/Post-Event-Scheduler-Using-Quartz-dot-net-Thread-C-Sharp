using Quartz.Impl;
using Quartz.Job;
using System;
using System.Threading;

namespace Quartz.Quartz
{
    /// <summary>
    /// Install Quartz version 2.6 as reference
    /// </summary>
    class Scheduler
    {
        public void Schedule()
        {
            try
            {
                // Common.Logging.LogManager.Adapter = new Common.Logging.Simple.ConsoleOutLoggerFactoryAdapter { Level = Common.Logging.LogLevel.Info };

                // Grab the Scheduler instance from the Factory 
                IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler();

                // define the job and tie it to our HelloJob class
                IJobDetail job = JobBuilder.Create<Cron>()
                  .Build();

                //check this for cron expression: https://www.quartz-scheduler.net/documentation/quartz-2.x/tutorial/crontriggers.html
                // Creating Trigger
                ITrigger trigger = TriggerBuilder.Create()
                 //Generate Cron Expression @ http://www.cronmaker.com/
                 //Trigger that will fire every week day at 10:42 am
                 .WithCronSchedule("0 32 19 ? * MON-FRI *")
                 .StartNow()
                 .Build();

                // Tell quartz to schedule the job using our trigger
                scheduler.ScheduleJob(job, trigger);

                scheduler.Start();
                // some sleep to show what's happening
                Thread.Sleep(TimeSpan.FromDays(20));
                scheduler.Shutdown();
            }
            catch (SchedulerException se)
            {
                Console.WriteLine(se);
            }
        }
    }
}
