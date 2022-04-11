using System;
using System.Net;
using Xunit;

namespace ShopRUsWebAPITest
{
    public class WepApiTest
    {
        [Fact]
        public async void CreateDiscountSuccessTest()
        {
            var client = new TestClientProvider().Client;

            // Act
            var okResult = await client.PostAsync("/CreateDiscount", StaticFakeData.SuccessCreateDiscountData());

            Console.WriteLine(okResult);

            okResult.EnsureSuccessStatusCode();

            // Assert
            Assert.Equal(HttpStatusCode.OK, okResult.StatusCode);

        }

        [Fact]
        public async void CreateDiscountErrorTest()
        {
            var client = new TestClientProvider().Client;

            // Act
            var failResult = await client.PostAsync("/CreateDiscount", StaticFakeData.ErrorCreateDiscountData());

            // Assert
            Assert.Equal(HttpStatusCode.BadRequest, failResult.StatusCode);

        }

        [Fact]
        public async void GetUserTypeTest()
        {
            var client = new TestClientProvider().Client;

            // Act
            var okResult = await client.GetAsync("/GetUserType");


            okResult.EnsureSuccessStatusCode();

            // Assert
            Assert.Equal(HttpStatusCode.OK, okResult.StatusCode);

        }

        [Fact]
        public async void GetItemTypeTest()
        {
            var client = new TestClientProvider().Client;

            // Act
            var okResult = await client.GetAsync("/GetItemType");

            okResult.EnsureSuccessStatusCode();

            // Assert
            Assert.Equal(HttpStatusCode.OK, okResult.StatusCode);

        }
    }
}
