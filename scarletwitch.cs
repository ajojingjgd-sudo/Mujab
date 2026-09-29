namespace GameInheritanceDemo
{
    public class Scarletwitch : Character
    {
        public int spellPower;

        public Scarletwitch()
        {
            Console.WriteLine("> Konstruktor default scarletwitch<");
        }

        public Scarletwitch(int spellPower, string id,string name, int basePower, string address)
        : base(id, name, basePower, address)
        {
            Console.WriteLine("> Konstruktor berparameter scarletwitch <");
            this.spellPower = spellPower;
        }

        public void DisplayData()
        {
            base.DisplayBaseData();
            Console.WriteLine("SPELL POWER = " + spellPower);
            Console.WriteLine("TOTAL POWER = " + (GetBasePower() + spellPower));
            Console.WriteLine("==================");
        }
    }
}