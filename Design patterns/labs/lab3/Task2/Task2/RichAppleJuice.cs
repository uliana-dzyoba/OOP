namespace Task2
{
    internal class RichAppleJuice : AppleJuice
    {
        public RichAppleJuice()
        {
            price = 3.5;
            package = "tetra pack carton";
            sugar = 28;
            variety = "Granny Smith";
        }

        public override void Show()
        {
            System.Console.WriteLine("Rich Apple Juice");
            base.Show();
            System.Console.WriteLine("");
        }
    }
}