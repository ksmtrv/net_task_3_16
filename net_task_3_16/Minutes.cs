namespace net_task_3_16
{
    class Minutes
    {
        private int amount;

        public Minutes(int y)
        {
            while (y > 60) y %= 60;
            amount = y;
        }

        public int Amount
        {
            get
            {
                return amount;
            }
            set
            {
                while (value > 60) value %= 60;
            }
        }
    }
}