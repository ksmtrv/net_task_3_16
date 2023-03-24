namespace net_task_3_16
{
    abstract class Time
    {
        protected Hour hour;
        protected Minutes mins;
        public Time(int x, int y)
        {
            hour = new Hour(x);
            mins = new Minutes(y);
        }
    }
}