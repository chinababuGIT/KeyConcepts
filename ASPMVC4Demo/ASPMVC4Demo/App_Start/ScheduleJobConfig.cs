using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Quartz;
using Quartz.Util;
using Quartz.Job;
using Quartz.Impl;

namespace ASPMVC4Demo.App_Start
{
    public class ScheduleJobConfig
    {
        private static double _start = 10.0;
        public static void RegisterScheduler() 
        {
            var schedulerFactory = new StdSchedulerFactory();
            var scheduler = schedulerFactory.GetScheduler();
            scheduler.StartDelayed(TimeSpan.FromSeconds(_start));
        }

    }
}