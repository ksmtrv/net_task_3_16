namespace net_task_3_16
{
    class Day : Time
    {
        public Day(int x, int y) : base(x, y)
        {

        }

        public string ShowTime()
        {
            return $"Текущее время: {hour.Amount:0#}:{mins.Amount:0#}";
        }

        public string Define()
        {
            if (hour.Amount < 18)
            {
                if (hour.Amount < 12)
                {
                    if (hour.Amount < 6)
                    {
                        return "Ночь";
                    }
                    else
                    {
                        return "Утро";
                    }
                }
                else
                {
                    return "День";
                }

            }
            else
            {
                return "Вечер";
            }
        }
    }
}