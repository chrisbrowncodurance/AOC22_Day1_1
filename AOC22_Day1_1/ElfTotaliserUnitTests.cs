namespace AOC22_Day1_1
{
    public class ElfTotaliserUnitTests
    {
        const string ExampleCalorieList = "1000\r\n2000\r\n3000\r\n\r\n4000\r\n\r\n5000\r\n6000\r\n\r\n7000\r\n8000\r\n9000\r\n\r\n10000";
        private ElfTotaliser elfTotaliser;

        [Fact]
        public void SplitsInputCorrectly()
        {
            elfTotaliser = new ElfTotaliser(ExampleCalorieList);

            var countOfCalorieFigures = elfTotaliser.CountCalorieEntries();

            Assert.Equal(14, countOfCalorieFigures);
        }

        private Elf FindElfWithMostCalories(string entryList)
        {
            elfTotaliser = new ElfTotaliser(entryList);
            return elfTotaliser.ElfWithMostCalories();
        }

        [Fact]
        public void SingleElfIsHoldingMost()
        {
            var elfWithMostCalories = FindElfWithMostCalories("1000");

            Assert.Equal(1, elfWithMostCalories.Id);
        }

        [Fact]
        public void SingleElfHoldsSingleCalories()
        {
            var elfWithMostCalories = FindElfWithMostCalories("1000");

            Assert.Equal(1000, elfWithMostCalories.TotalHeld());
        }

        [Fact]
        public void SingleElfHoldsAllCalories()
        {
            var elfWithMostCalories = FindElfWithMostCalories("1000\r\n2000");

            Assert.Equal(3000, elfWithMostCalories.TotalHeld());
        }

        [Fact]
        public void FindsTwoElves()
        {
            var elfWithMostCalories = FindElfWithMostCalories("1000\r\n\r\n2000");

            Assert.Equal(2, elfWithMostCalories.Id);
        }

        [Fact]
        public void FindsFirstElfAsHoldingMost()
        {
            var elfWithMostCalories = FindElfWithMostCalories("2000\r\n\r\n1000");

            Assert.Equal(1, elfWithMostCalories.Id);
        }

        [Fact]
        public void GetElfByPosition()
        {
            var elfTotaliser = new ElfTotaliser("1000\r\n\r\n2000");

            var elfAt = elfTotaliser.ElfAt(1);

            Assert.Equal(1000, elfAt.TotalHeld());
        }
    }
}