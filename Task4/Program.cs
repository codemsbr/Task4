namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Task 1
            //int lasNumber = 0;
            //int nexNumber = 1;
            //int fibNumber = 0;
            //int number = 12;
            //while (fibNumber >= number)
            //{
            //    Console.Write(lasNumber + " ");
            //    fibNumber = lasNumber + nexNumber;
            //    lasNumber = nexNumber;
            //    nexNumber = fibNumber;
            //}
            #endregion

            #region Task 2
            int numberOne = 14;
            int numberTwo = 9;

            numberOne = numberOne + numberTwo;
            numberTwo = numberOne - numberTwo;
            numberOne = numberOne - numberTwo;
            Console.WriteLine(numberOne);
            Console.WriteLine(numberTwo);
            #endregion 
        }
    }
}