using Xunit;

namespace Ngsoft.Utils.Tests
{
    public class UXHelperTests
    {
        [Fact]
        public void GetDeclension_ReturnsExpectedValues()
        {
            // Arrange
            var nominative = "заказ";
            var genetive = "заказа";
            var plural = "заказов";

            // Act
            var value1 = UXHelper.GetDeclension(0, nominative, genetive, plural);
            var value2 = UXHelper.GetDeclension(1, nominative, genetive, plural);
            var value3 = UXHelper.GetDeclension(2, nominative, genetive, plural);
            var value4 = UXHelper.GetDeclension(5, nominative, genetive, plural);
            var value5 = UXHelper.GetDeclension(21, nominative, genetive, plural);
            var value6 = UXHelper.GetDeclension(2011, nominative, genetive, plural);
            var value7 = UXHelper.GetDeclension(2351, nominative, genetive, plural);
            var value8 = UXHelper.GetDeclension(2315, nominative, genetive, plural);
            var value9 = UXHelper.GetDeclension(-158, nominative, genetive, plural);
            var value10 = UXHelper.GetDeclension(-2315, nominative, genetive, plural);

            // Assert
            Assert.Equal(plural, value1);
            Assert.Equal(nominative, value2);
            Assert.Equal(genetive, value3);
            Assert.Equal(plural, value4);
            Assert.Equal(nominative, value5);
            Assert.Equal(plural, value6);
            Assert.Equal(nominative, value7);
            Assert.Equal(plural, value8);
            Assert.Equal(plural, value9);
            Assert.Equal(plural, value10);
        }
    }
}
