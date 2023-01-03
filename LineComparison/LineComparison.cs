using System.Buffers.Text;

namespace LineComparison
{

    internal class InbuiltMethodsContainer //UC4 Using OOPS concept.
    {
        public void UsingEquals(int[] input)
        {
            bool equals = input[0].Equals(input[1]);
            if (equals == true)
            {
                Console.WriteLine("Both the lines are of equal length.");
            }

            else
            {
                Console.WriteLine("Lines are not of equal length.");
            }
        }

        public void UsingCompareTo(int[] input2)
        {
            int checker = input2[0].CompareTo(input2[1]);
            if (checker > 0)
            {
                Console.WriteLine("Line 1 (Length = {0}) is greater than Line 2 (Length = {1}).", input2[0], input2[1]);
            }
            else if (checker < 0)
            {
                Console.WriteLine("Line 1 (Length = {0}) is less than Line 2 (Length = {1}).", input2[0], input2[1]);
            }
            else
            {
                Console.WriteLine("Line 1 (Length = {0}) is equal to Line 2 (Length = {1}).", input2[0], input2[1]);
            }
        }
    }
    internal class LineComparison
    {

        static int LineLengthCalculator()
        {
            //UC1 Model a line based on a point consisting of (x,y) co-ordinates using the cartesian system, to calculate length.
            Console.WriteLine("Enter x1 and y1 values : ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2 and y2 values : ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            int lengthOfLine = (int)(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return lengthOfLine;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to line comparison problem!");
            int tracker = 0;

            //UC2 Check equality of two lines based on the end points.
            int[] twoLengths = new int[2];
            for (int count = 0; count < twoLengths.Length; count++)
            {
                tracker++;
                Console.WriteLine("\n" + tracker + " Line values .");
                twoLengths[count] =  LineLengthCalculator();
            }
            //Console.WriteLine("\nLength of Line 1 : " + twoLengths[0] + "\nLength of Line 2 : " + twoLengths[1]);

            InbuiltMethodsContainer inbuiltMethodsContainer = new InbuiltMethodsContainer();

            inbuiltMethodsContainer.UsingEquals(twoLengths);

            //UC3 Compare two lines to check wether they are equal, grater than or less than another line
            
            inbuiltMethodsContainer.UsingCompareTo(twoLengths);
            
        }
    }

    
}