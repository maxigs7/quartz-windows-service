using Quartz.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quartz.Service.Jobs
{
    [DisallowConcurrentExecution]
    public class TestJob : BaseJob, IJob
    {
        public TestJob()
        {
            // TODO: Add Logger
        }

        public override string JobName()
        {
            return nameof(TestJob);
        }

        public override bool IsEnabled()
        {
            // TODO: Make it configurable
            return true;
        }

        public override Task ProcessJob(IJobExecutionContext context)
        {
            // TODO: Add Log.Info($"PROCESSING {JobName()}");
            return Task.CompletedTask;
        }
    }
}
