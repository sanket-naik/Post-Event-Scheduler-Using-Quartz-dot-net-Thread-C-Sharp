using Quartz;

namespace Quartz.Job
{
    class Cron:IJob
    {
        public void Execute(IJobExecutionContext context)
        {

            ReadXml r1 = new ReadXml();
            r1.Get();

        }
    }
}
