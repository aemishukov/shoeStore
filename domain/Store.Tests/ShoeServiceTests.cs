using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Store.Tests
{
    public class ShoeServiceTests
    {
        [Fact]
        public void GetAllByQuery_WithArticle_CallsGetByArticle()
        {
            var shoeRepositoryStub = new Mock<IShoeRepository>();
            shoeRepositoryStub.Setup(x => x.GetByArticle(It.IsAny<string>()))
                .Returns(new[] { new Shoe(1, "", "", "") });

            shoeRepositoryStub.Setup(x => x.GetAllByTitleOrCompanyName(It.IsAny<string>()))
                .Returns(new[] { new Shoe(2, "", "", "") });

            var shoeService = new ShoeService(shoeRepositoryStub.Object);
            var validArticle = "123456 ab";

            var actual = shoeService.GetAllByQuery(validArticle);

            Assert.Collection(actual, shoe => Assert.Equal(1, shoe.Id));
        }

        [Fact]
        public void GetAllByQuery_WithCompanyName_CallsGetByTitleOrCompanyName()
        {
            var shoeRepositoryStub = new Mock<IShoeRepository>();
            shoeRepositoryStub.Setup(x => x.GetByArticle(It.IsAny<string>()))
                .Returns(new[] { new Shoe(1, "", "", "") });

            shoeRepositoryStub.Setup(x => x.GetAllByTitleOrCompanyName(It.IsAny<string>()))
                .Returns(new[] { new Shoe(2, "", "", "") });

            var shoeService = new ShoeService(shoeRepositoryStub.Object);
            var invalidArticle = "123456";

            var actual = shoeService.GetAllByQuery(invalidArticle);

            Assert.Collection(actual, shoe => Assert.Equal(2, shoe.Id));
        }
    }
}
