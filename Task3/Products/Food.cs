namespace Task3.Products
{
    public class Food : Product
    {
        public Food(string name, string type, decimal price) : base(name, type, price)
        {
        }

        /// <summary>
        /// Method converts an object to a Food class
        ///  Input parameters: Food.
        ///  Returned value: Book.
        /// </summary>
        public static explicit operator Book(Food food) => new Book(food.Name, food.Type, food.Price);

        /// <summary>
        /// Method converts an object to a Technics class
        ///  Input parameters: Food.
        ///  Returned value: Technics.
        /// </summary>
        public static explicit operator Technics(Food food) => new Technics(food.Name, food.Type, food.Price);

        /// <summary>
        /// Method converts an object to a Stationery class        
        ///  Input parameters: Food.
        ///  Returned value: Stationery.
        /// </summary>
        public static explicit operator Stationery(Food food) => new Stationery(food.Name, food.Type, food.Price);

        /// <summary>
        /// Method converts an object to a Stationery class
        ///  Input parameters: Food.
        ///  Returned value: int.
        /// </summary>
        public static explicit operator int(Food food) => (int)(food.Price * 100);

        /// <summary>
        /// The method returns the price in kopecks
        ///  Input parameters: Food.
        ///  Returned value: decimal.
        /// </summary>
        public static explicit operator decimal(Food food) => food.Price;

        /// <summary>
        /// The method of addition objects of the same type
        ///  Input parameters: Food, Food.
        ///  Returned value: Food.
        /// </summary>
        public static Food operator +(Food food1, Food food2) => new Food(food1.Name + "-" + food2.Name, food1.Type, (food1.Price + food2.Price) / 2);

        /// <summary>
        ///  Method Equals.
        ///  Lets you compare two objects.
        ///  Input parameters: object.
        ///  Returned value: bool.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj.GetType() != GetType())
                return false;

            var food = (Food)obj;

            return Type == food.Type && Name == food.Name && Price == food.Price;
        }

        /// <summary>
        ///  Method GetHashCode.
        ///  Method gets the hash code of the object.
        ///  Input parameters: null.
        ///  Returned value: int.
        /// </summary>
        public override int GetHashCode() => Type.GetHashCode() + Name.GetHashCode() + Price.GetHashCode();
    }
}
