namespace praktik11
{
    internal class Player
    {
        private int level;
        private int health;

        public int Level
        {
            get { return level; } 
            set { level = value < 1 && value >100? 0: value ; }
        }
        public int Health
        {
            get { return health; }
            set { health = value < 0 && value > 100 ? 0 : value; }
        }
        public string Name { get; init; }
        
        public bool IsAlive { get => Health > 0; }

        public Player(string name, int level, int health)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Имя не может принимать значение NULL");
                Name = "DefaultName";
            }
            else
            {
                Name = name;
            }
            if (health < 1 || health > 100)
            {
                Console.WriteLine("Здоровье должно быть в диапазоне");
                Health = 0;
            }
            else 
            { 
                Health = health;
            }
            if (level < 1 || level > 100)
            {
                Console.WriteLine("Уровень должно быть в диапазоне");
                Level = 0;
            }
            else
            {
                Level = level;
            }
        }
        public void TakeDamage(int damage)
        {
            
            if((Health - damage) <0)
            {
                Health = 0;
                
            }
            else
            {
                Health -= damage;
                
            }
            Console.Write($"Персонаж {Name}, уровень: {Level}, здоровье {Health} Персонаж жив: ");
            if (IsAlive)
            {
                Console.WriteLine("Да ");
            }
            else
            {
                Console.WriteLine("Нет ");
            }
        }


    }
}
