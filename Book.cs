namespace praktik11
{
    internal class Book
    {
        private string title;

        public string Title
        {
            get { return title; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Ошибка, некоректное значение!");
                }
                else
                {
                    title = value;
                }
            }
        }
        public int Pages { get; init; }= 1;

        public bool IsLong
        {
            get => Pages > 300;
        }
        public Book (string title)
        {
            if(string.IsNullOrWhiteSpace(title))
            {
                Console.WriteLine("Книга пустая!");
                Title = "Unkown";
            }
            else
            {
                Title = title;
            }   
        }

        public void Info ()
        {
            Console.Write($"Книга: {title}, страниц: {Pages}, длинная: ");
            if (IsLong)
            {
                Console.WriteLine("да");
            }
            else
            {
                Console.WriteLine("нет"); 
            }
        }
    }
}
