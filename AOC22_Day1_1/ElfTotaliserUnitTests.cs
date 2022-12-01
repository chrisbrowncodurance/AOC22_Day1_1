namespace AOC22_Day1_1
{
    public class ElfTotaliserUnitTests
    {
        const string ExampleCalorieList = "1000\r\n2000\r\n3000\r\n\r\n4000\r\n\r\n5000\r\n6000\r\n\r\n7000\r\n8000\r\n9000\r\n\r\n10000";

        [Fact]
        public void SplitsInputCorrectly()
        {
            var elfCounter = new ElfTotaliser(ExampleCalorieList);
            
            var countOfCalorieFigures = elfCounter.CountCalorieEntries();

            Assert.Equal(14, countOfCalorieFigures);
        }


    }
}