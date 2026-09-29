namespace GameInheritanceDemo
{
    public class Dwarf : Character
    {
        public int bonus;

        public Dwarf()
        {
            Console.WriteLine("> Konstruktor default dwarf <");
        }

        public Dwarf(int bonus, string id,string name, int basePower, string address)
        : base(id, name, basePower, address)
        {
            Console.WriteLine("> Konstruktor berparameter dwarf <");
            this.bonus = bonus;
        }

        public void DisplayData()
        {
            base.DisplayBaseData();
            Console.WriteLine("BONUS       = " + bonus);
            Console.WriteLine("TOTAL POWER = " + (GetBasePower() + bonus));
            Console.WriteLine("==================");
        }
    }
}