using System;
using System.Threading.Tasks;

namespace Quartz.Service.Common
{
    public abstract class BaseJob
    {
        public BaseJob()
        {
            // Add Logger
        }

        public abstract string JobName();

        public abstract bool IsEnabled();

        public async Task Execute(IJobExecutionContext context)
        {
            var isEnabled = IsEnabled();
            if (!isEnabled) return;

            var jobName = JobName();

            // TODO: Add Log.Info($"STARTING JOB: {jobName}");

            try
            {
                await ProcessJob(context);
            }
            catch (Exception ex)
            {
                // TODO: Add Log.Error("GENERAL ERROR", ex);
            }

            // TODO: Add Log.Info($"FINISH JOB: {jobName}");
        }

        public abstract Task ProcessJob(IJobExecutionContext context);

    }
}
