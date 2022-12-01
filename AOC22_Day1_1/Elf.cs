namespace AOC22_Day1_1
{
    public class Elf
    {
        public int Id { get; set; }
        private List<int> caloriesHeld = new List<int>();

        public void InputCalorieEntry(int i)
        {
            caloriesHeld.Add(i);
        }

        public int TotalHeld()
        {
            return caloriesHeld.Sum();
        }
    }
}