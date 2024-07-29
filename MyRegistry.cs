using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ToolsApp;
using ToolsApp.Helper;
using FluentScheduler;
using LLibrary;
using System.Net;
using NSClient;
using AutoSendCapNhapDH;


namespace AutoSendMailBaoNoSoPhieu
{
    public class MyRegistry : Registry
    {
        private readonly MyTask task = new MyTask();
        private readonly SemaphoreSlim _highPrioritySemaphore = new SemaphoreSlim(1, 1);
        private readonly SemaphoreSlim _lowPrioritySemaphore = new SemaphoreSlim(0, 1);

        public MyRegistry()
        {

            try
            {
                //KAutoHelper.MotionDetection.InitializeMotionDetection();
                _ThongThienThap("ThongThienThap", "");
                Hours("BosTruAc", "");
                _BossBang("BossBang", "");
                Minutes( "LungBat", "");
                _BangChien("BangChien", "");
                //ScheduleHighPriorityTasks();
                //ScheduleLowPriorityTask(30, "CaoNhan", "");
            }
            catch (Exception ex)
            {
                L.Log("", ex.Message);
            }
        }

        private void ScheduleHighPriorityTasks()
        {
            ScheduleTaskWithSemaphore(() => _ThongThienThap("ThongThienThap", ""), "ThongThienThap");
            ScheduleTaskWithSemaphore(() => Hours("BosTruAc", ""), "BosTruAc");
            ScheduleTaskWithSemaphore(() => _BossBang("BossBang", ""), "BossBang");
            ScheduleTaskWithSemaphore(() => Minutes("LungBat", ""), "LungBat");
        }

        private void ScheduleLowPriorityTask(int seconds, string TaskName, string DataType)
        {
            Schedule(async () => await ExecuteLowPriorityTaskWithSemaphore(TaskName, DataType))
                .WithName(TaskName)
                .ToRunEvery(seconds).Seconds();
        }

        private void ScheduleTaskWithSemaphore(Action action, string TaskName)
        {
            Schedule(async () =>
            {
                await _highPrioritySemaphore.WaitAsync();
                try
                {
                    action();
                }
                finally
                {
                    _highPrioritySemaphore.Release();
                    if (_lowPrioritySemaphore.CurrentCount == 0)
                    {
                        _lowPrioritySemaphore.Release();
                    }
                }
            }).WithName(TaskName);
        }

        private async Task ExecuteLowPriorityTaskWithSemaphore(string TaskName, string DataType)
        {
            await _lowPrioritySemaphore.WaitAsync();
            try
            {
                await _highPrioritySemaphore.WaitAsync();
                try
                {
                    ExcuteTask(TaskName, DataType);
                }
                finally
                {
                    _highPrioritySemaphore.Release();
                }
            }
            finally
            {
                if (_lowPrioritySemaphore.CurrentCount == 0)
                {
                    _lowPrioritySemaphore.Release();
                }
            }
        }

        private void Minutes(string TaskName, string DataType)
        {
            var hours = Enumerable.Range(0, 24).Where(h => h != 12 && h != 19 && h != 20);
            foreach (var hour in hours)
            {
                Schedule(async () => await ExecuteTaskWithSemaphore(TaskName, DataType))
                    .WithName(TaskName)
                    .ToRunEvery(1).Days().At(hour, 30);
            }
        }

        private void _BossBang(string TaskName, string DataType)
        {
            Schedule(async () => await ExecuteTaskWithSemaphore(TaskName, DataType))
                    .WithName(TaskName)
                    .ToRunEvery(1).Days().At(12, 00);

            Schedule(async () => await ExecuteTaskWithSemaphore(TaskName, DataType))
                    .WithName(TaskName)
                    .ToRunEvery(1).Days().At(20, 00);
        }


        private void Seconds(int seconds, string TaskName, string DataType)
        {
            L.Register(TaskName);
            L.Log(TaskName, seconds.ToString() + " second(s) has passed.");
            Schedule(async () => await ExecuteLowPriorityTaskWithSemaphore(TaskName, DataType))
                .WithName(TaskName)
                .ToRunEvery(seconds).Seconds();
        }

        private void Hours(string TaskName, string DataType)
        {
            var hours = Enumerable.Range(0, 24).Where(h => h != 12 && h != 19 && h != 20 & h != 13);
            foreach (var hour in hours)
            {
                Schedule(async () => await ExecuteTaskWithSemaphore(TaskName, DataType))
                    .WithName(TaskName)
                    .ToRunEvery(1).Days().At(hour, 00);
            }
        }

        private void _ThongThienThap(string TaskName, string DataType)
        {
            Schedule(async () => await ExecuteTaskWithSemaphore(TaskName, DataType))
                .WithName(TaskName)
                    .ToRunEvery(1).Days().At(19, 30);          
        }

        private void _BangChien(string TaskName, string DataType)
        {
            Schedule(async () => await ExecuteTaskWithSemaphore(TaskName, DataType))
                .WithName(TaskName)
                    .ToRunEvery(1).Days().At(20, 30);
        }

        private async Task ExecuteTaskWithSemaphore(string TaskName, string DataType)
        {
            await _highPrioritySemaphore.WaitAsync();
            try
            {
                ExcuteTask(TaskName, DataType);
            }
            finally
            {
                _highPrioritySemaphore.Release();
                if (_lowPrioritySemaphore.CurrentCount == 0)
                {
                    _lowPrioritySemaphore.Release();
                }
            }
        }

        private void ExcuteTask(string TaskName, string DataType)
        {
            int currentHour = DateTime.Now.Hour;
            int[] excludedHours = { 12,19, 20 };

            switch (TaskName)
            {
                case "BosTruAc":
                    if (Array.IndexOf(excludedHours, currentHour) == -1)
                    {
                        task._PostAPIMaHang(TaskName);
                    }
                    break;

                case "LungBat":
                    if (Array.IndexOf(excludedHours, currentHour) == -1)
                    {
                        task._LungBat(TaskName);
                    }
                    break;

                case "ThongThienThap":
                    task._ThongThienThap(TaskName);
                    break;
                case "BossBang":
                    task.startBossBang(TaskName);
                    break;
                case "BangChien":
                    task._bangchien(TaskName);
                    break;
            }
        }
    }
}


