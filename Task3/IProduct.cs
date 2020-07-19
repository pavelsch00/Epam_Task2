using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    interface IProduct
    {
        /// <summary>
        /// The field describes the type of product.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The field describes the name of the product.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The field describes the price of the product.
        /// </summary>
        public  decimal Price { get; set; }
    }
}
