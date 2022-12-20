namespace LineComparison
{
    internal class LineComparison
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to line comparison problem!");

            //UC1 Model a line based on a point consisting of (x,y) co-ordinates using the cartesian system, to calculate length.
            Console.WriteLine("Enter x1 and y1 values : ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2 and y2 values : ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            int lengthOfLine1 = (int)(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Length of line 1 : "+lengthOfLine1);
        }
    }
}