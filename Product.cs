namespace praktik11
{
    internal class Product
    {
        private int price;
        private int discount;

        public int Price
        { 
            get { return price; }
            set 
            {
                if (value <1)
                {
                    Console.WriteLine("Цена не может быть ниже 1");
                    price = 1;
                }
                else
                {
                    price = value;
                }
            } 
        }
        public int Discount
        {
            get { return discount; }
            set
            {
                if (value <0||discount >100)
                {
                    Console.WriteLine("Скидка не может принимать данное значение");
                    discount = 0;
                }
                else
                {
                    discount = value;
                }
            }
        }
        public int FinalPrice => (int)(Price * (1 - (double)Discount / (double)100));
        public string Name { get; init; } = "Без названия";

        public Product(int price, int discount)
        {
            if (price < 1)
            {
                Console.WriteLine("Цена не может быть ниже 1");
                Price = 1;
            }
            else
            {
                Price = price;
            }
            if (discount < 0 || discount > 100)
            {
                Console.WriteLine("Скидка не может принимать данное значение");
                Discount = 0;
            }
            else
            {
                Discount = discount;
            }

            
        }
        public void Show()
        {
            Console.WriteLine($"{Name}, цена: {FinalPrice} (скидка: {Discount} %)");
        }
    }
}
