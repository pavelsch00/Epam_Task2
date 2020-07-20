using Task3.Products;
using Xunit;

namespace Task3_Tests
{
    public class FoodTests
    {
        [Fact]
        public void Equals_FoodAndFood_Equal()
        {
            // arrange
            string name1 = "Milk";
            decimal price1 = 1.8m;
            string type1 = "book";

            Food foot1 = new Food(name1, type1, price1);

            string name2 = "Milk";
            decimal price2 = 1.8m;
            string type2 = "book";

            Food foot2 = new Food(name2, type2, price2);

            bool expected = true;

            // act
            bool actual = Equals(foot1, foot2);

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Plus_FoodAndFood_Equal()
        {
            // arrange
            string name1 = "Milk";
            decimal price1 = 1.8m;
            string type1 = "food";

            Food food1 = new Food(name1, type1, price1);

            string name2 = "Рerring";
            decimal price2 = 9.2m;
            string type2 = "food";

            Food food2 = new Food(name2, type2, price2);

            string name3 = "Milk-Рerring";
            decimal price3 = 5.5m;
            string type3 = "food";

            Food food3Expected = new Food(name3, type3, price3);

            // act
            Food actual = food1 + food2;

            // assert;
            Assert.Equal(food3Expected, actual);
        }

        [Fact]
        public void ConvertMoneyToCoins_9dot20_920()
        {
            // arrange
            string name1 = "Рerring";
            decimal price1 = 9.2m;
            string type1 = "food";

            Food food1 = new Food(name1, type1, price1);

            int expected = 920;

            // assert;
            Assert.Equal(expected, (int)food1);
        }

        [Fact]
        public void ConvertMoney_920_920()
        {
            // arrange
            string name1 = "Рerring";
            decimal price1 = 920m;
            string type1 = "food";

            Food food1 = new Food(name1, type1, price1);

            int expected = 920;

            // assert;
            Assert.Equal(expected, (decimal)food1);
        }

        [Fact]
        public void CastToBook_Fook_Bood()
        {
            // arrange
            string name1 = "Рerring";
            decimal price1 = 920m;
            string type1 = "food";

            Food food1 = new Food(name1, type1, price1);

            string name2 = "Рerring";
            decimal price2 = 920m;
            string type2 = "food";

            Book food2Expected = new Book(name2, type2, price2);

            // assert;
            Assert.Equal(food2Expected, (Book)food1);
        }

        [Fact]
        public void CastToStationery_Food_Stationery()
        {
            // arrange
            string name1 = "Рerring";
            decimal price1 = 920m;
            string type1 = "food";

            Food food1 = new Food(name1, type1, price1);

            string name2 = "Рerring";
            decimal price2 = 920m;
            string type2 = "food";

            Stationery Stationery2Expected = new Stationery(name2, type2, price2);


            // assert;
            Assert.Equal(Stationery2Expected, (Stationery)food1);
        }


        [Fact]
        public void CastToTechnics_Book_Technics()
        {
            // arrange
            string name1 = "Рerring";
            decimal price1 = 920m;
            string type1 = "food";

            Food food1 = new Food(name1, type1, price1);

            string name2 = "Рerring";
            decimal price2 = 920m;
            string type2 = "food";

            Technics technics2Expected = new Technics(name2, type2, price2);

            // act

            // assert;
            Assert.Equal(technics2Expected, (Technics)food1);
        }
    }
}