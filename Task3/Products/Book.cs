namespace Task3.Products
{
    public class Book : Product
    {
        public Book(string name, string type, decimal price) : base(name, type, price)
        {
        }

        /// <summary>
        /// Method converts an object to a Food class
        ///  Input parameters: Book.
        ///  Returned value: Food.
        /// </summary>
        public static explicit operator Food(Book book) => new Food(book.Name, book.Type, book.Price);

        /// <summary>
        /// Method converts an object to a Technics class
        ///  Input parameters: Book.
        ///  Returned value: Technics.
        /// </summary>
        public static explicit operator Technics(Book book) => new Technics(book.Name, book.Type, book.Price);

        /// <summary>
        /// Method converts an object to a Stationery class        
        ///  Input parameters: Book.
        ///  Returned value: Stationery.
        /// </summary>
        public static explicit operator Stationery(Book book) => new Stationery(book.Name, book.Type, book.Price);

        /// <summary>
        /// Method converts an object to a Stationery class
        ///  Input parameters: Book.
        ///  Returned value: int.
        /// </summary>
        public static explicit operator int(Book book) => (int)(book.Price * 100);

        /// <summary>
        /// The method returns the price in kopecks
        ///  Input parameters: Book.
        ///  Returned value: decimal.
        /// </summary>
        public static explicit operator decimal(Book book) => book.Price;

        /// <summary>
        /// The method of addition objects of the same type
        ///  Input parameters: Book, Book.
        ///  Returned value: Book.
        /// </summary>
        public static Book operator +(Book book1, Book book2) => new Book(book1.Name + "-" + book2.Name, book1.Type, (book1.Price + book2.Price) / 2);

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

            var book = (Book)obj;

            return Type == book.Type && Name == book.Name && Price == book.Price;
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
