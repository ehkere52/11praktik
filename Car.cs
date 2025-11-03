namespace praktik11
{
    internal class Car
    {
        private int speed;

        public int Speed
        {
            get { return speed; }
            set
            {
                if (value < 0 || value > 300)
                {
                    speed = 150; //default value
                    Console.WriteLine("Ошибка, некоректное значение!");
                }
                else
                { 
                    speed = value;                
                }
            }
        }
        public string Model { get; set; }
        public Car(int speed, string model) 
        {
            Speed = speed;
            Model = model;
        }

        public void Drive()
        {
            Console.WriteLine($"{Model} едет со скоростью {speed} км/ч.");
        }
    }
}
