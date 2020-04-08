using HomeMaths;
using Xunit;

namespace UnitTests
{
    public class UnitTestAddition
    {
        private readonly IAddition _addition = new Addition();
        
        [Theory]
        [InlineData(10, 10)]
        [InlineData(10, 5)]
        public void Test1(int max, int tests)
        {
            var rets = _addition.GenerateAdditionUpto(max, tests);
            
            Assert.NotEmpty(rets);
            Assert.Equal(tests, rets.Count);

            foreach (var calculation in rets)
            {
                Assert.Equal(calculation.Item1 + calculation.Item2, calculation.Item3);
                Assert.Equal(max, calculation.Item3);
            }
        }
    }
}