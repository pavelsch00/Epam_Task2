using Task3.Products;
using Xunit;

namespace Task3_Tests
{
    public class TechnicsTests
    {
        [Fact]
        public void Equals_TechnicsAndTechnics_Equal()
        {
            // arrange
            string name1 = "smartphone";
            decimal price1 = 320.9m;
            string type1 = "Technics";

            Technics technics1 = new Technics(name1, type1, price1);

            string name2 = "smartphone";
            decimal price2 = 320.9m;
            string type2 = "Technics";

            Technics technics2 = new Technics(name2, type2, price2);

            bool expected = true;

            // act
            bool actual = Equals(technics1, technics2);

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Plus_TechnicsAndTechnics_Equal()
        {
            // arrange
            string name1 = "smartphone";
            decimal price1 = 320.9m;
            string type1 = "Technics";

            Technics technics1 = new Technics(name1, type1, price1);

            string name2 = "computer";
            decimal price2 = 540m;
            string type2 = "Technics";

            Technics technics2 = new Technics(name2, type2, price2);

            string name3 = "smartphone-computer";
            decimal price3 = 430.45m;
            string type3 = "Technics";

            Technics technics3Expected = new Technics(name3, type3, price3);

            // act
            Technics actual = technics1 + technics2;

            // assert;
            Assert.Equal(technics3Expected, actual);
        }

        [Fact]
        public void ConvertMoneyToCoins_320dot9_32090()
        {
            // arrange
            string name1 = "smartphone";
            decimal price1 = 320.9m;
            string type1 = "Technics";

            Technics technics1 = new Technics(name1, type1, price1);

            int expected = 32090;

            // assert;
            Assert.Equal(expected, (int)technics1);
        }

        [Fact]
        public void ConvertMoney_320dot9_32090()
        {
            // arrange
            string name1 = "smartphone";
            decimal price1 = 32090;
            string type1 = "Technics";

            Technics technics1 = new Technics(name1, type1, price1);

            int expected = 32090;

            // assert;
            Assert.Equal(expected, (decimal)technics1);
        }

        [Fact]
        public void CastToBook_Technicsy_Book()
        {
            // arrange
            string name1 = "smartphone";
            decimal price1 = 320.9m;
            string type1 = "Technics";

            Technics technics1 = new Technics(name1, type1, price1);

            string name2 = "smartphone";
            decimal price2 = 320.9m;
            string type2 = "Technics";

            Book book2Expected = new Book(name2, type2, price2);

            // assert;
            Assert.Equal(book2Expected, (Book)technics1);
        }

        [Fact]
        public void CastToFood_Technics_Food()
        {
            // arrange
            string name1 = "smartphone";
            decimal price1 = 320.9m;
            string type1 = "Technics";

            Technics technics1 = new Technics(name1, type1, price1);

            string name2 = "smartphone";
            decimal price2 = 320.9m;
            string type2 = "Technics";

            Food technics12Expected = new Food(name2, type2, price2);


            // assert;
            Assert.Equal(technics12Expected, (Food)technics1);
        }


        [Fact]
        public void CastToStationery_Technics_Stationery()
        {
            // arrange
            string name1 = "smartphone";
            decimal price1 = 320.9m;
            string type1 = "Technics";

            Technics technics1 = new Technics(name1, type1, price1);

            string name2 = "smartphone";
            decimal price2 = 320.9m;
            string type2 = "Technics";

            Stationery technics2Expected = new Stationery(name2, type2, price2);

            // assert;
            Assert.Equal(technics2Expected, (Stationery)technics1);
        }
    }
}
