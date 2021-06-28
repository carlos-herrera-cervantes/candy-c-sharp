using CandyDomain.Models;
using Xunit;

namespace CandyTests.Models
{
    public class SuperArrayTests
    {
        [Fact]
        public void GetNumberOfCandies_Should_Return_Correct_Number()
        {
            var ratings = new[] { 1, 2, 2 };
            const int ExpectedResult = 4;

            int result = SuperArray.GetNumberOfCandies(ratings);

            Assert.Equal(result, ExpectedResult);
        }
    }
}