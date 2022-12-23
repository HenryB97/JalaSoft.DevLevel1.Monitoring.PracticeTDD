using TDD03;

namespace TestResult
{
    [TestClass]
    public class GildedRose
    {
        [TestMethod]
        public void TestWhenGivenProductReturnsUpdatedSellInValue()
        {
            Product myProduct = new Product("Bread", 35, 40);
            myProduct.UpdateProduct();
            Assert.AreEqual(34, myProduct.SellIn);
        }

        [TestMethod]
        public void TestProductWhenGivenProductReturnsUpdatedQualityValue()
        {
            Product myProduct = new Product("Bread", 35, 40);
            myProduct.UpdateProduct();
            Assert.AreEqual(39, myProduct.Quality);
        }

        [TestMethod]
        public void TestProductWhenSellDatePassedReturnsQualityDegradeTwiceAsFast()
        {
            Product myProduct = new Product("Bread", -4, 20);
            myProduct.UpdateProduct();
            Assert.AreEqual(18, myProduct.Quality);
        }

        [TestMethod]
        public void TestProductWhenIsAgedBrieReturnsIncreasedQuality()
        {
            Product myProduct = new Product("Aged Brie", 10, 20);
            myProduct.UpdateProduct();
            myProduct.UpdateProduct();
            myProduct.UpdateProduct();
            Assert.AreEqual(23, myProduct.Quality);
        }

        [TestMethod]
        public void TestProductWhenQualityGreaterThan50ReturnsErrorMessage()
        {
            string message = string.Empty;
            Product myProduct = new Product("Bread", 35, 60);
            try
            {
                myProduct.UpdateProduct();
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }

            Assert.AreEqual("Invalid Data", message);
        }

        [TestMethod]
        public void TestProductWhenLegendaryItemReturnsDoesNotDecrease()
        {
            Product myProduct = new Product("Sulfuras", 50, 80);
            myProduct.UpdateProduct();
            Assert.AreEqual(80, myProduct.Quality);
        }

        [TestMethod]
        public void TestProductWhenLegendaryItemReturnsCanNotBeSold()
        {
            Product myProduct = new Product("Sulfuras", 50, 80);
            myProduct.UpdateProduct();
            Assert.AreEqual(false, myProduct.CanBeSold);
        }

        [TestMethod]
        public void TestProductWhenLegendaryItemQualityIsNot80ReturnsErrorMessage()
        {
            string message = string.Empty;
            Product myProduct = new Product("Sulfuras", 50, 70);
            try
            {
                myProduct.UpdateProduct();
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }

            Assert.AreEqual("Invalid Data", message);
        }

        [TestMethod]
        public void TestProductWhenNormalItemReturnsCanBeSold()
        {
            Product myProduct = new Product("Item", 20, 50);
            myProduct.UpdateProduct();
            Assert.AreEqual(true, myProduct.CanBeSold);
        }

        [TestMethod]
        public void TestProductWhenIsBackstagePassesReturnsIncreasesQuality()
        {
            Product myProduct = new Product("Backstage passes", 15, 30);
            myProduct.UpdateProduct();
            Assert.AreEqual(31, myProduct.Quality);
        }

        [TestMethod]
        public void TestProductWhenIsBackstagePassesWith10DaysOrLessReturnsIncreasesQualityBy2()
        {
            Product myProduct = new Product("Backstage passes", 8, 30);
            myProduct.UpdateProduct();
            Assert.AreEqual(32, myProduct.Quality);
        }

        [TestMethod]
        public void TestProductWhenIsBackstagePassesWith5DaysOrLessReturnsIncreasesQualityBy3()
        {
            Product myProduct = new Product("Backstage passes", 4, 40);
            myProduct.UpdateProduct();
            Assert.AreEqual(43, myProduct.Quality);
        }

        [TestMethod]
        public void TestProductWhenIsBackstagePassesAfterTheConcertReturnsDropsToZero()
        {
            Product myProduct = new Product("Backstage passes", -1, 46);
            myProduct.UpdateProduct();
            Assert.AreEqual(0, myProduct.Quality);
        }

        [TestMethod]
        public void TestProductWhenIsConjuredReturnsDegradeTwiceAsFast()
        {
            Product myProduct = new Product("Conjured", 40, 30);
            myProduct.UpdateProduct();
            Assert.AreEqual(28, myProduct.Quality);
        }


        [TestMethod]
        public void TestProductWhenDigradeNormalItemReturnNonNegativeQuality()
        {
            Product myProduct = new Product("Bread", 18, 0);
            myProduct.UpdateProduct();
            Assert.AreEqual(0, myProduct.Quality);
        }


        [TestMethod]
        public void TestProductWhenDigradeConjuredReturnNonNegativeQuality()
        {
            Product myProduct = new Product("Conjured", 18, 0);
            myProduct.UpdateProduct();
            Assert.AreEqual(0, myProduct.Quality);
        }

        [TestMethod]
        public void TestProductWhenIncreaseAgedBrieReturnQualityNoMoreThan50()
        {
            Product myProduct = new Product("Aged Brie", 20, 50);
            myProduct.UpdateProduct();
            Assert.AreEqual(50, myProduct.Quality);
        }

        public void TestProductWhenIncreaseBackstagePassesReturnQualityNoMoreThan50()
        {
            Product myProduct = new Product("Aged Brie", 5, 49);
            myProduct.UpdateProduct();
            Assert.AreEqual(50, myProduct.Quality);
        }










    }
}