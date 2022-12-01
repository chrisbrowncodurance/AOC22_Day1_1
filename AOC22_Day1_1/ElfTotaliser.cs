namespace AOC22_Day1_1
{
    public class ElfTotaliser
    {
        public ElfTotaliser(string entryCalorieList)
        {
            CaloriesList = entryCalorieList.Split("\r\n");
            MakeElves(new Queue<string>(CaloriesList));
        }

        private readonly IEnumerable<string> CaloriesList;
        private Elf foundElf;
        private readonly List<Elf> foundElves = new();

        public int CountCalorieEntries()
        {
            return CaloriesList.Count();
        }

        public Elf ElfWithMostCalories()
        {
            return foundElves
                .OrderByDescending(elf => elf.TotalHeld())
                .First();
        }

        private void MakeElves(Queue<string> calorieEntries)
        {
            var entry = calorieEntries.Dequeue();

            if (NeedToCreateNextElf(entry))
            {
                CreateNewElf();
            }

            AddCalorieEntry(entry);

            if (calorieEntries.Count > 0)
            {
                MakeElves(calorieEntries);
            }
        }

        private void AddCalorieEntry(string entry)
        {
            if (entry == string.Empty)
            {
                return;
            }
            foundElves.Last().InputCalorieEntry(int.Parse(entry));
        }

        private void CreateNewElf()
        {
            foundElf = new Elf { Id = NextId() };
            foundElves.Add(foundElf);
        }

        private bool NeedToCreateNextElf(string entry)
        {
            return !foundElves.Any() || entry == string.Empty;
        }

        private int NextId()
        {
            return foundElves.Count + 1;
        }

        public Elf ElfAt(int i)
        {
            return foundElves[i - 1];
        }
    }
}