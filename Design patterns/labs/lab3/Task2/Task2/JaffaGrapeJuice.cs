namespace Task2
{
    internal class JaffaGrapeJuice : GrapeJuice
    {
        public JaffaGrapeJuice()
        {
            price = 3.3;
            package = "PET plastic bottle";
            sugar = 36.7;
            color = "blue";
        }

        public override void Show()
        {
            System.Console.WriteLine("Jaffa Grape Juice");
            base.Show();
            System.Console.WriteLine("");
        }
    }
}