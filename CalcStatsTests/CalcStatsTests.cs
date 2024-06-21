using CalcStatsKata;

namespace CalcStatsTests
{
    public class CalcStatsTests
    {

        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, 3)]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 10)]
        [InlineData(new int[] { 0 }, 1)]
        [InlineData(new int[] { }, 0)]
        public void Length_ShouldReturnCorrectLength(int[] numberSequence, int expectedLength)
        {
            /* Arrange */
            var calcStats = new CalcStats(numberSequence);

            /* Act */
            var length = calcStats.Length;

            /* Assert */
            Assert.Equal(expectedLength, length);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 1)]
        [InlineData(new int[] { 10, 90, -15, -20 }, -20)]
        [InlineData(new int[] { 0, 0, 0, 0 }, 0)]
        public void Min_ShouldReturnMinimumValue(int[] numberSequence, int expectedValue)
        {
            /* Arrange */
            var calcStats = new CalcStats(numberSequence);

            /* Act */
            var minValue = calcStats.Min();

            /* Assert */
            Assert.Equal(expectedValue, minValue);
        }


        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 5)]
        [InlineData(new int[] { 10, 90, -15, -20 }, 90)]
        [InlineData(new int[] { 0, 0, 0, 0 }, 0)]
        public void Max_ShouldReturnMaximumValue(int[] numberSequence, int expectedValue)
        {
            /* Arrange */
            var calcStats = new CalcStats(numberSequence);

            /* Act */
            var maxValue = calcStats.Max();

            /* Assert */
            Assert.Equal(expectedValue, maxValue);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 5, 2, 3 }, 3)]
        [InlineData(new int[] { 10, 20, 30, 40 }, 25)]
        [InlineData(new int[] { 0, 0, 0, 0 }, 0)]
        public void Average_ShouldReturnAverageValue(int[] numberSequence, int expectedValue)
        {
            /* Arrange */
            var calcStats = new CalcStats(numberSequence);

            /* Act */
            var average = calcStats.Average();

            /* Assert */
            Assert.Equal(expectedValue, average);
        }
    }
}
