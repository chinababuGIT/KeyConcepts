using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Net;
using Quartz;
using Quartz.Job;

namespace smtpclient
{
    public class EmailJob : SendMailJob
    {
        private EmailJob()
        {
        }

        public void Execute(IJobExecutionContext context)
        {
            throw new NotImplementedException();
        }
    }
}
