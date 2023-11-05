namespace SUT23_Labb3_Poly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Rectangle rectangle = new Rectangle();
            Square square = new Square();

            circle.PrintInfo();
            rectangle.PrintInfo();
            square.PrintInfo();

            Console.ReadKey();
        }
    }
}