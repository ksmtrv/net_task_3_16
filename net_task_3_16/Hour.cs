namespace net_task_3_16
{
    class Hour
    {
        private int amount;

        public Hour(int x)
        {
            while (x > 24) x %= 24;
            amount = x;
        }
        public Hour()
        {
            amount = 7;
        }

        public int Amount
        {
            get
            {
                return amount;
            }
            set
            {
                while (value > 24) value %= 24;
            }
        }
    }
}