namespace AOC22_Day1_1
{
    public class ElfTotaliser
    {
        public ElfTotaliser(string exampleCalorieList)
        {
            CaloriesList = exampleCalorieList.Split("\r\n");
        }

        private readonly IEnumerable<string> CaloriesList;

        public int CountCalorieEntries()
        {
            return CaloriesList.Count();
        }
    }
}