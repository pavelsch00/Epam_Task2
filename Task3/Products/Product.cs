namespace Task3
{
    public class Product : IProduct
    {
        public Product(string name, string type, decimal price)
        {
            Name = name;
            Type = type;
            Price = price;
        }

        public string Type { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

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

            var product = (Product)obj;

            return Type == product.Type && Name == product.Name && Price == product.Price;
        }

        /// <summary>
        ///  Method GetHashCode.
        ///  Method gets the hash code of the object.
        ///  Input parameters: null.
        ///  Returned value: int.
        /// </summary>
        public override int GetHashCode() => Type.GetHashCode() + Name.GetHashCode() + Price.GetHashCode();

        /// <summary>
        ///  Method ToString.
        ///  Allows you to get class status information as a string.
        ///  Input parameters: null.
        ///  Returned value: string.
        /// </summary>

        public override string ToString() => $"Type: {Type}, Name: {Name}, Price: {Price}";
    }
}
