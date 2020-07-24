namespace Task2
{
    internal class JaffaOrangeJuice : OrangeJuice
    {
        public JaffaOrangeJuice()
        {
            price = 3.5;
            package = "PET plastic bottle";
            sugar = 22.3;
            vitaminC = 24;
        }

        public override void Show()
        {
            System.Console.WriteLine("Jaffa Orange Juice");
            base.Show();
            System.Console.WriteLine("");
        }
    }
}