namespace AOC22_Day1_1
{
    public class AcceptanceTests
    {
        const string ExampleCalorieList = "1000\r\n2000\r\n3000\r\n\r\n4000\r\n\r\n5000\r\n6000\r\n\r\n7000\r\n8000\r\n9000\r\n\r\n10000";

        public AcceptanceTests()
        {
            elfTotaliser = new ElfTotaliser(ExampleCalorieList);
        }

        private ElfTotaliser elfTotaliser;

        [Fact]
        public void FirstElf()
        {
            var firstElf = elfTotaliser.ElfAt(1);

            Assert.Equal(6000, firstElf.TotalHeld());
        }

        [Fact]
        public void SecondElf()
        {
            var secondElf = elfTotaliser.ElfAt(2);

            Assert.Equal(4000, secondElf.TotalHeld());
        }

        [Fact]
        public void ThirdElf()
        {
            var thirdElf = elfTotaliser.ElfAt(3);

            Assert.Equal(11000, thirdElf.TotalHeld());
        }

        [Fact]
        public void FourthElf()
        {
            var fourthElf = elfTotaliser.ElfAt(4);

            Assert.Equal(24000, fourthElf.TotalHeld());
        }

        [Fact]
        public void FifthElf()
        {
            var fifthElf = elfTotaliser.ElfAt(5);

            Assert.Equal(10000, fifthElf.TotalHeld());
        }

        [Fact]
        public void FindElfCarryingMost()
        {
            var elf = elfTotaliser.ElfWithMostCalories();

            Assert.Equal(24000, elf.TotalHeld());
        }
    }
}