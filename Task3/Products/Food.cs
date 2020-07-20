﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Products
{
    public class Food : Product
    {
        public Food(string name, string type, decimal price) : base(name, type, price)
        {
        }

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