namespace AOC22_Day1_1
{
    public class ElfUnitTests
    {
        public ElfUnitTests()
        {
            elf = new Elf();
        }

        private Elf elf;

        [Theory]
        [InlineData(1000, 1000)]
        [InlineData(3000, 1000, 2000)]
        [InlineData(6000, 1000, 2000, 3000)]
        public void EntriesCorrectlyTotalled(int expected, params int[] inputs)
        {
            foreach (var input in inputs)
            {
                elf.InputCalorieEntry(input);
            }

            Assert.Equal(expected, elf.TotalHeld());
        }
    }
}