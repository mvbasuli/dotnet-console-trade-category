using Moq;
using TradeCategory.Domain.Factories;
using TradeCategory.Domain.Model;
using TradeCategory.Domain.Extensions;
using Xunit;

namespace TradeCategory.Domain.Test
{
    public class CategoryTest
    {
        readonly DateTime referenceDate = "03/02/2020".InputToDate();
        readonly DateTime dateBeforelimit = "01/31/2020".InputToDate();
        readonly DateTime dateBeforeReferenceDate = "02/02/2020".InputToDate();
        readonly DateTime dateAfterReferenceDate = "10/20/2020".InputToDate();

        readonly double referenceValue = 1000000;
        readonly double valueAboveReferenceValue = 1000000.00000001;
        readonly double valueUnderReferenceValue = 999999.999999999;

        [Fact]
        public void CategoryExpired_Private_AboveValue_DateBeforeLimit()
        {
            Trade trade = new Trade(valueAboveReferenceValue, "Private", dateBeforelimit);

            var mockCategoryFactory = new Mock<CategoryFactory>().Object;
            var result = mockCategoryFactory.CreateCategory(trade, referenceDate);
            Assert.Equal("EXPIRED", result.Name);
        }

        [Fact]
        public void CategoryExpired_Private_UnderValue_DateBeforeLimit()
        {
            Trade trade = new Trade(valueUnderReferenceValue, "Public", dateBeforelimit);

            var mockCategoryFactory = new Mock<CategoryFactory>().Object;
            var result = mockCategoryFactory.CreateCategory(trade, referenceDate);
            Assert.Equal("EXPIRED", result.Name);
        }

        [Fact]
        public void CategoryExpired_Public_AboveValue_DateBeforeLimit()
        {
            Trade trade = new Trade(valueAboveReferenceValue, "Public", dateBeforelimit);

            var mockCategoryFactory = new Mock<CategoryFactory>().Object;
            var result = mockCategoryFactory.CreateCategory(trade, referenceDate);
            Assert.Equal("EXPIRED", result.Name);
        }

        [Fact]
        public void CategoryExpired_Public_UnderValue_DateBeforeLimit()
        {
            Trade trade = new Trade(valueUnderReferenceValue, "Public", dateBeforelimit);

            var mockCategoryFactory = new Mock<CategoryFactory>().Object;
            var result = mockCategoryFactory.CreateCategory(trade, referenceDate);
            Assert.Equal("EXPIRED", result.Name);
        }

        [Fact]
        public void CategoryHighRisk_Private_AboveValue_BeforeReferenceDate()
        {
            Trade trade = new Trade(valueAboveReferenceValue, "Private", dateBeforeReferenceDate);

            var mockCategoryFactory = new Mock<CategoryFactory>().Object;
            var result = mockCategoryFactory.CreateCategory(trade, referenceDate);
            Assert.Equal("HIGHRISK", result.Name);
        }

        [Fact]
        public void CategoryHighRisk_Private_AboveValue_AfterReferenceDate()
        {
            Trade trade = new Trade(valueAboveReferenceValue, "Private", dateAfterReferenceDate);

            var mockCategoryFactory = new Mock<CategoryFactory>().Object;
            var result = mockCategoryFactory.CreateCategory(trade, referenceDate);
            Assert.Equal("HIGHRISK", result.Name);
        }

        [Fact]
        public void CategoryWithoutCategory_Private_BelowValue_BeforeReferenceDate()
        {
            Trade trade = new Trade(valueUnderReferenceValue, "Private", dateBeforeReferenceDate);

            var mockCategoryFactory = new Mock<CategoryFactory>().Object;
            var result = mockCategoryFactory.CreateCategory(trade, referenceDate);
            Assert.Equal("WITHOUTCATEGORY", result.Name);
        }

        [Fact]
        public void CategoryWithoutCategory_Private_BelowValue_AfterReferenceDate()
        {
            Trade trade = new Trade(valueUnderReferenceValue, "Private", dateAfterReferenceDate);

            var mockCategoryFactory = new Mock<CategoryFactory>().Object;
            var result = mockCategoryFactory.CreateCategory(trade, referenceDate);
            Assert.Equal("WITHOUTCATEGORY", result.Name);
        }

        [Fact]
        public void CategoryMediumRisk_Private_AboveValue_BeforeReferenceDate()
        {
            Trade trade = new Trade(valueAboveReferenceValue, "Public", dateBeforeReferenceDate);

            var mockCategoryFactory = new Mock<CategoryFactory>().Object;
            var result = mockCategoryFactory.CreateCategory(trade, referenceDate);
            Assert.Equal("MEDIUMRISK", result.Name);
        }

        [Fact]
        public void CategoryMediumRisk_Public_AboveValue_AfterReferenceDate()
        {
            Trade trade = new Trade(valueAboveReferenceValue, "Public", dateAfterReferenceDate);

            var mockCategoryFactory = new Mock<CategoryFactory>().Object;
            var result = mockCategoryFactory.CreateCategory(trade, referenceDate);
            Assert.Equal("MEDIUMRISK", result.Name);
        }


        [Fact]
        public void CategoryWithoutCategory_Public_BelowValue_BeforeReferenceDate()
        {
            Trade trade = new Trade(valueUnderReferenceValue, "Public", dateBeforeReferenceDate);

            var mockCategoryFactory = new Mock<CategoryFactory>().Object;
            var result = mockCategoryFactory.CreateCategory(trade, referenceDate);
            Assert.Equal("WITHOUTCATEGORY", result.Name);
        }

        [Fact]
        public void CategoryWithoutCategory_Public_BelowValue_AfterReferenceDate()
        {
            Trade trade = new Trade(valueUnderReferenceValue, "Public", dateAfterReferenceDate);

            var mockCategoryFactory = new Mock<CategoryFactory>().Object;
            var result = mockCategoryFactory.CreateCategory(trade, referenceDate);
            Assert.Equal("WITHOUTCATEGORY", result.Name);
        }

        [Fact]
        public void CategoryWithoutCategory_Private_IgualValue_AfterReferenceDate()
        {
            Trade trade = new Trade(referenceValue, "Private", dateAfterReferenceDate);

            var mockCategoryFactory = new Mock<CategoryFactory>().Object;
            var result = mockCategoryFactory.CreateCategory(trade, referenceDate);
            Assert.Equal("WITHOUTCATEGORY", result.Name);
        }

        [Fact]
        public void CategoryWithoutCategory_Public_IgualValue_AfterReferenceDate()
        {
            Trade trade = new Trade(referenceValue, "Public", dateAfterReferenceDate);

            var mockCategoryFactory = new Mock<CategoryFactory>().Object;
            var result = mockCategoryFactory.CreateCategory(trade, referenceDate);
            Assert.Equal("WITHOUTCATEGORY", result.Name);
        }
    }
}
