using System;
using Xunit;

namespace Store.Tests
{
    public class ShoeTests
    {
        [Fact]
        public void IsArticle_WithNull_ReturnFalse()
        {
            bool actual = Shoe.IsArticle(null);

            Assert.False(actual);
        }

        [Fact]
        public void IsArticle_WithBlankString_ReturnFalse()
        {
            bool actual = Shoe.IsArticle("  ");

            Assert.False(actual);
        }

        [Fact]
        public void IsArticle_WithInvalidArticle_ReturnFalse()
        {
            bool actual = Shoe.IsArticle("0");

            Assert.False(actual);
        }

        [Fact]
        public void IsArticle_WithArticle9_ReturnTrue()
        {
            bool actual = Shoe.IsArticle("240156 ab");

            Assert.True(actual);
        }
    }
}
