namespace Task2
{
    internal class RichGrapeJuice : GrapeJuice
    {
        public RichGrapeJuice()
        {
            price = 3.4;
            package = "tetra pack carton";
            sugar = 35;
            color = "green";
        }

        public override void Show()
        {
            System.Console.WriteLine("Rich Grape Juice");
            base.Show();
            System.Console.WriteLine("");
        }
    }
}