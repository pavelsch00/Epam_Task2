using Task3.Products;
using Xunit;

namespace Task3_Tests
{
    public class BookTests
    {
        [Fact]
        public void Equals_BookAndBook_Equal()
        {
            // arrange
            string name1 = "S.T.A.L.K.E.R.";
            decimal price1 = 5.6m;
            string type1 = "book";

            Book book1 = new Book(name1, type1, price1);

            string name2 = "S.T.A.L.K.E.R.";
            decimal price2 = 5.6m;
            string type2 = "book";

            Book book2 = new Book(name2, type2, price2);

            bool expected = true;

            // act
            bool actual = Equals(book1, book2);

            // assert;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Plus_BookAndBook_Equal()
        {
            // arrange
            string name1 = "S.T.A.L.K.E.R.";
            decimal price1 = 5.6m;
            string type1 = "book";

            Book book1 = new Book(name1, type1, price1);

            string name2 = "Story";
            decimal price2 = 10m;
            string type2 = "book";

            Book book2 = new Book(name2, type2, price2);

            string name3 = "S.T.A.L.K.E.R.-Story";
            decimal price3 = 7.8m;
            string type3 = "book";

            Book book3Expected = new Book(name3, type3, price3);

            // act
            Book actual = book1 + book2;

            // assert;
            Assert.Equal(book3Expected, actual);
        }

        [Fact]
        public void ConvertMoneyToCoins_5dot6m_560()
        {
            // arrange
            string name1 = "S.T.A.L.K.E.R.";
            decimal price1 = 5.6m;
            string type1 = "book";

            Book book1 = new Book(name1, type1, price1);

            int expected = 560;

            // assert;
            Assert.Equal(expected, (int)book1);
        }

        [Fact]
        public void ConvertMoney_560_560()
        {
            // arrange
            string name1 = "S.T.A.L.K.E.R.";
            decimal price1 = 560;
            string type1 = "book";

            Book book1 = new Book(name1, type1, price1);

            int expected = 560;

            // assert;
            Assert.Equal(expected, (decimal)book1);
        }

        [Fact]
        public void CastToFood_Book_Food()
        {
            // arrange
            string name1 = "S.T.A.L.K.E.R.";
            decimal price1 = 560;
            string type1 = "book";

            Book book1 = new Book(name1, type1, price1);

            string name2 = "S.T.A.L.K.E.R.";
            decimal price2 = 560;
            string type2 = "book";

            Food food2Expected = new Food(name2, type2, price2);

            // assert;
            Assert.Equal(food2Expected, (Food)book1);
        }

        [Fact]
        public void CastToStationery_Book_Stationery()
        {
            // arrange
            string name1 = "S.T.A.L.K.E.R.";
            decimal price1 = 560;
            string type1 = "book";

            Book book1 = new Book(name1, type1, price1);

            string name2 = "S.T.A.L.K.E.R.";
            decimal price2 = 560;
            string type2 = "book";

            Stationery Stationery2Expected = new Stationery(name2, type2, price2);

            // act

            // assert;
            Assert.Equal(Stationery2Expected, (Stationery)book1);
        }


        [Fact]
        public void CastToTechnics_Book_Stationery()
        {
            // arrange
            string name1 = "S.T.A.L.K.E.R.";
            decimal price1 = 560;
            string type1 = "book";

            Book book1 = new Book(name1, type1, price1);

            string name2 = "S.T.A.L.K.E.R.";
            decimal price2 = 560;
            string type2 = "book";

            Technics technics2Expected = new Technics(name2, type2, price2);

            // act

            // assert;
            Assert.Equal(technics2Expected, (Technics)book1);
        }
    }
}
