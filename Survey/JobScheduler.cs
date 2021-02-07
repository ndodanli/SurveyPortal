using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Survey
{
    public class JobScheduler
    {
        public async void Start()
        {
            ISchedulerFactory schedulerFactory = new StdSchedulerFactory();
            IScheduler scheduler = await schedulerFactory.GetScheduler();
            await scheduler.Start();

            IJobDetail job = JobBuilder.Create<AnketTemizleyici>().Build();

            ITrigger trigger = TriggerBuilder.Create()

                .WithIdentity("AnketTemizleyici ", "Group0")
                .WithCronSchedule("0 0 12 * * ?")
                .Build();

            await scheduler.ScheduleJob(job, trigger);

        }
    }
}