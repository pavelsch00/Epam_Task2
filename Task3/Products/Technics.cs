namespace Task3.Products
{
    public class Technics : Product
    {
        public Technics(string name, string type, decimal price) : base(name, type, price)
        {
        }

        /// <summary>
        /// Method converts an object to a Book class
        ///  Input parameters: Technics.
        ///  Returned value: Book.
        /// </summary>
        public static explicit operator Book(Technics technics) => new Book(technics.Name, technics.Type, technics.Price);

        /// <summary>
        /// Method converts an object to a Technics class
        ///  Input parameters: Technics.
        ///  Returned value: Stationery.
        /// </summary>
        public static explicit operator Stationery(Technics technics) => new Stationery(technics.Name, technics.Type, technics.Price);

        /// <summary>
        /// Method converts an object to a Stationery class        
        ///  Input parameters: Technics.
        ///  Returned value: Food.
        /// </summary>
        public static explicit operator Food(Technics technics) => new Food(technics.Name, technics.Type, technics.Price);

        /// <summary>
        /// Method converts an object to a Stationery class
        ///  Input parameters: Technics.
        ///  Returned value: int.
        /// </summary>
        public static explicit operator int(Technics technics) => (int)(technics.Price * 100);

        /// <summary>
        /// The method returns the price in kopecks
        ///  Input parameters: Technics.
        ///  Returned value: decimal.
        /// </summary>
        public static explicit operator decimal(Technics technics) => technics.Price;

        /// <summary>
        /// The method of addition objects of the same type
        ///  Input parameters: Technics, Technics.
        ///  Returned value: Technics.
        /// </summary>
        public static Technics operator +(Technics technics1, Technics technics2) => new Technics(technics1.Name + "-" + technics2.Name, technics1.Type, (technics1.Price + technics2.Price) / 2);

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

            var technics = (Technics)obj;

            return Type == technics.Type && Name == technics.Name && Price == technics.Price;
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
