namespace Learn4_Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //System.FormatException : 
            //System.OverflowException : 
            bool looping = true;

            while (looping)
            {
                try
                {
                    Console.Write("Enter a number: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(num);

                    looping = false;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Please only a number less than 2 bilion!");
                    looping = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please only a number!");
                    looping = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Something has went wrong!");
                }
            }

            Console.WriteLine("Goobye!");

            Console.ReadLine();
        }
    }
}
