namespace Task2
{
    abstract class OrangeJuice:Juice
    {
        internal double vitaminC;

        public override void Show()
        {
            System.Console.WriteLine("vitamin C: {0} grams", vitaminC);
            System.Console.WriteLine("sugar: {0} grams", sugar);
            System.Console.WriteLine("in " + package);
            System.Console.WriteLine(price + "$");
        }
    }
}