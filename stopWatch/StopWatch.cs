namespace StopWatchExercise // Note: actual namespace depends on the project name.
{
    public class StopWatch {
        public DateTime StartTimer(DateTime start)
        {
           StartTime = start;

           return StartTime;
        }
        public DateTime StartTime {get; private set;}

        public DateTime StopTimer(DateTime stop) 
        {
            StopTime = stop;

            return StopTime;
        }
        public DateTime StopTime {get; private set;}

        public TimeSpan Duration(StartTime,StopTime)
        {
            var TimeDuration = StartTime - StopTime;

            return TimeDuration;
        }
        public TimeSpan TimeDuration {get; private set;}

    }
}
