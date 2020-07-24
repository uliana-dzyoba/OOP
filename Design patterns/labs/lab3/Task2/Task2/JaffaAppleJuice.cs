namespace Task2
{
    internal class JaffaAppleJuice : AppleJuice
    {
        public JaffaAppleJuice()
        {
            price = 3.2;
            package = "PET plastic bottle";
            sugar = 28.2;
            variety = "Golden Delicious";
        }

        public override void Show()
        {
            System.Console.WriteLine("Jaffa Apple Juice");
            base.Show();
            System.Console.WriteLine("");
        }
    }
}