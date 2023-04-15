namespace net_task_3_16
{
    class Day : Time
    {
        public Day(int x, int y) : base(x, y)
        {

        }
        
        public override string ToString()
        {
            return $"Current time: {hour.Amount:0#}:{mins.Amount:0#}";
        }

        public string Define()
        {
            if (hour.Amount < 6) return "Time of day: night";  
            if (hour.Amount < 12) return "Time of day: morning";            
            if (hour.Amount < 18) return "Time of day: day";
            return "Time of day: evening";
        }
    }
}