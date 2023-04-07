namespace net_task_3_16
{
    class Day : Time
    {
        public Day(int x, int y) : base(x, y)
        {

        }
        
        public override string ToString()
        {
            return $"Текущее время: {hour.Amount:0#}:{mins.Amount:0#}";
        }

        public string Define()
        {
            if (hour.Amount < 6) return "Время суток: ночь";  
            if (hour.Amount < 12) return "Время суток: утро";            
            if (hour.Amount < 18) return "Время суток: день";
            return "Время суток: вечер";
        }
    }
}