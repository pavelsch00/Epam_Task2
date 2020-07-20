namespace Task3.Products
{
    public class Stationery : Product
    {
        public Stationery(string name, string type, decimal price) : base(name, type, price)
        {
        }

        /// <summary>
        /// Method converts an object to a Book class
        ///  Input parameters: Stationery.
        ///  Returned value: Book.
        /// </summary>
        public static explicit operator Book(Stationery stationery) => new Book(stationery.Name, stationery.Type, stationery.Price);

        /// <summary>
        /// Method converts an object to a Technics class
        ///  Input parameters: Stationery.
        ///  Returned value: Technics.
        /// </summary>
        public static explicit operator Technics(Stationery stationery) => new Technics(stationery.Name, stationery.Type, stationery.Price);

        /// <summary>
        /// Method converts an object to a Stationery class        
        ///  Input parameters: Stationery.
        ///  Returned value: Food.
        /// </summary>
        public static explicit operator Food(Stationery stationery) => new Food(stationery.Name, stationery.Type, stationery.Price);

        /// <summary>
        /// Method converts an object to a Stationery class
        ///  Input parameters: Stationery.
        ///  Returned value: int.
        /// </summary>
        public static explicit operator int(Stationery stationery) => (int)(stationery.Price * 100);

        /// <summary>
        /// The method returns the price in kopecks
        ///  Input parameters: Stationery.
        ///  Returned value: decimal.
        /// </summary>
        public static explicit operator decimal(Stationery stationery) => stationery.Price;

        /// <summary>
        /// The method of addition objects of the same type
        ///  Input parameters: Stationery, Stationery.
        ///  Returned value: Stationery.
        /// </summary>
        public static Stationery operator +(Stationery stationery1, Stationery stationery2) => new Stationery(stationery1.Name + "-" + stationery2.Name, stationery1.Type, (stationery1.Price + stationery2.Price) / 2);

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

            var stationery = (Stationery)obj;

            return Type == stationery.Type && Name == stationery.Name && Price == stationery.Price;
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
