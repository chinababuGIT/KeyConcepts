namespace ASPMVC4Demo
{
    using System;
    using CrystalQuartz.Core.SchedulerProviders;
    using Quartz;
    using Quartz.Job;
    using Quartz.Impl;

    public class SimpleSchedulerProvider : StdSchedulerProvider
    {
        protected override System.Collections.Specialized.NameValueCollection GetSchedulerProperties()
        {
            var properties = base.GetSchedulerProperties();
            // Place custom properties creation here:
            //     properties.Add("test1", "test1value");
            return properties;
        }

        protected override void InitScheduler(IScheduler scheduler)
        {
            // Put jobs creation code here

            // Sample job

            IJobDetail jobDetail = JobBuilder
                                   .Create(typeof(HelloJob))
                                   .WithDescription("myjob")
                                   .WithIdentity(new Quartz.JobKey("jobKey"))
                                   .StoreDurably(true)
                                   .Build();
           
            //ITrigger trigger = TriggerBuilder.Create().WithDailyTimeIntervalSchedule().
            //trigger.StartTimeUtc = DateTime.UtcNow;
            //trigger.Name = "myTrigger";
            //scheduler.ScheduleJob(jobDetail, trigger);
        }

        internal class HelloJob : IJob
        {
            public void Execute(IJobExecutionContext context)
            {
                Console.WriteLine("Hello, CrystalQuartz!");
            }
        }
    }
}