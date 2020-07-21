using Task3.Products;
using Xunit;

namespace Task3_Tests
{
    public class StationeryTests
    {
        [Fact]
        public void Equals_StationeryAndStationery_Equal()
        {
            // arrange
            string name1 = "Scissors";
            decimal price1 = 3.4m;
            string type1 = "stationery";

            Stationery stationery1 = new Stationery(name1, type1, price1);

            string name2 = "Scissors";
            decimal price2 = 3.4m;
            string type2 = "stationery";

            Stationery stationery2 = new Stationery(name2, type2, price2);

            bool expected = true;

            // act
            bool actual = Equals(stationery1, stationery2);

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Plus_FoodAndFood_Equal()
        {
            // arrange
            string name1 = "Scissors";
            decimal price1 = 3.4m;
            string type1 = "stationery";

            Stationery stationery1 = new Stationery(name1, type1, price1);

            string name2 = "Pencil";
            decimal price2 = 2.2m;
            string type2 = "stationery";

            Stationery stationery2 = new Stationery(name2, type2, price2);

            string name3 = "Scissors-Pencil";
            decimal price3 = 2.8m;
            string type3 = "stationery";

            Stationery stationery3Expected = new Stationery(name3, type3, price3);

            // act
            Stationery actual = stationery1 + stationery2;

            // assert;
            Assert.Equal(stationery3Expected, actual);
        }

        [Fact]
        public void ConvertMoneyToCoins_2dot4_340()
        {
            // arrange
            string name1 = "Scissors";
            decimal price1 = 3.4m;
            string type1 = "stationery";

            Stationery stationery1 = new Stationery(name1, type1, price1);

            int expected = 340;

            // assert;
            Assert.Equal(expected, (int)stationery1);
        }

        [Fact]
        public void ConvertMoney_340_340()
        {
            // arrange
            string name1 = "Scissors";
            decimal price1 = 340m;
            string type1 = "stationery";

            Stationery stationery1 = new Stationery(name1, type1, price1);

            int expected = 340;

            // assert;
            Assert.Equal(expected, (decimal)stationery1);
        }

        [Fact]
        public void CastToBook_Stationery_Book()
        {
            // arrange
            string name1 = "Scissors";
            decimal price1 = 340m;
            string type1 = "stationery";

            Stationery stationery1 = new Stationery(name1, type1, price1);

            string name2 = "Scissors";
            decimal price2 = 340m;
            string type2 = "stationery";

            Book book2Expected = new Book(name2, type2, price2);

            // assert;
            Assert.Equal(book2Expected, (Book)stationery1);
        }

        [Fact]
        public void CastToFood_Stationery_Food()
        {
            // arrange
            string name1 = "Scissors";
            decimal price1 = 340m;
            string type1 = "stationery";

            Stationery stationery1 = new Stationery(name1, type1, price1);

            string name2 = "Scissors";
            decimal price2 = 340m;
            string type2 = "stationery";

            Food Stationery2Expected = new Food(name2, type2, price2);


            // assert;
            Assert.Equal(Stationery2Expected, (Food)stationery1);
        }


        [Fact]
        public void CastToTechnics_Stationery_Technics()
        {
            // arrange
            string name1 = "Scissors";
            decimal price1 = 340m;
            string type1 = "stationery";

            Stationery stationery1 = new Stationery(name1, type1, price1);

            string name2 = "Scissors";
            decimal price2 = 340m;
            string type2 = "stationery";

            Technics technics2Expected = new Technics(name2, type2, price2);

            // assert;
            Assert.Equal(technics2Expected, (Technics)stationery1);
        }
    }
}
