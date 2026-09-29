namespace GameInheritanceDemo
{
    public class Monde : Scarletwitch
    {
        public int selatKnowledge;

        public Monde()
        {
            Console.WriteLine("> Konstruktor default monde <");
        }

        public Monde(int selatKnowledge, int spellPower, string id, string name, int basePower, string address)
        : base(spellPower, id, name, basePower, address)
        {
            Console.WriteLine("> Konstruktor berparameter monde <");
            this.selatKnowledge = selatKnowledge;
        }

        public void DisplayData1()
        {
            base.DisplayBaseData();
            Console.WriteLine("SELAT KNOWLEDGE = " + selatKnowledge);
            Console.WriteLine("GRAND TOTAL POWER = " + (GetBasePower() + spellPower + selatKnowledge));
            Console.WriteLine("==================");
        }
    }
}