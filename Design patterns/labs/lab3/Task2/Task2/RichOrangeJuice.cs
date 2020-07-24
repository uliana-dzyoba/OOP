namespace Task2
{
    internal class RichOrangeJuice : OrangeJuice
    {
        public RichOrangeJuice()
        {
            price = 3.6;
            package = "tetra pack carton";
            sugar = 22.1;
            vitaminC = 24.7;
        }

        public override void Show()
        {
            System.Console.WriteLine("Rich Orange Juice");
            base.Show();
            System.Console.WriteLine("");
        }
    }
}