namespace Task2
{
    abstract class GrapeJuice:Juice
    {
        internal string color;

        public override void Show()
        {
            System.Console.WriteLine("from {0} grapes", color);
            System.Console.WriteLine("sugar: {0} grams", sugar);
            System.Console.WriteLine("in " + package);
            System.Console.WriteLine(price + "$");
        }
    }
}