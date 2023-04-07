namespace net_task_3_16
{
    class Hour
    {
        private int amount;
        
        public Hour(int x)
        {
            while (x > 23) x %= 24;
            amount = x;
        }
        
        public int Amount
        {
            get
            {
                return amount;
            }
            set
            {
                while (value > 23) value %= 24;
            }
        }
    }
}