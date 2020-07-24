namespace Task2
{
    abstract class AppleJuice:Juice
    {
        internal string variety;
        public override void Show()
        {
            System.Console.WriteLine("from {0} apples", variety);
            System.Console.WriteLine("sugar: {0} grams", sugar);
            System.Console.WriteLine("in " + package);
            System.Console.WriteLine(price + "$");
        }
    }
}