namespace StopWatchExercise // Note: actual namespace depends on the project name.
{
    public class StopWatch {

        public TimeSpan timeSpan = new TimeSpan();

        /*public DateTime t1() // Start time of stopwatch
        {
            var st1 = DateTime.Now;
            return st1;
        }
        public DateTime st1 {get; private set;}
        public DateTime t2() // Stop time of the stopwatch
        {
            var st2 = DateTime.Now;
            return st2;
        }
        public DateTime st2 {get; private set;}*/
        public TimeSpan StartTimer(TimeSpan start)
        {
           StartTime = start;

           return StartTime;
        }
        public TimeSpan StartTime {get; private set;}

        public TimeSpan StopTimer(TimeSpan stop) 
        {
            StopTime = stop;

            return StopTime;
        }
        public TimeSpan StopTime {get; private set;}

        
    }
}
