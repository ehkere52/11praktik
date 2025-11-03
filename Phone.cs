namespace praktik11
{
    internal class Phone
    {
        private int battery;

        public int BatteryLevel
        {
            get => battery;
            set
            {
                if (value < 0 ||  value > 100)
                {
                    Console.WriteLine("Ошибка, некорекное значение!");
                }
                else
                {
                    battery = value;
                }
            }
        }
        public string Brand { get; init; }

        public Phone(string brand, int batteryLevel)
        {
            BatteryLevel = batteryLevel;
            Brand = brand;
        }

        public void Use()
        {
            if(battery - 10 >0)
            {
                battery -= 10;
                Console.WriteLine($"{Brand}: заряд {battery}%");
            }
            else
            {
                Console.WriteLine("Недостаточно энергии");
            }
        }

    }
}
