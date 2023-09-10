namespace Labb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            input = Console.ReadLine();

            int i = 0;

            while (i < input.Length)
            {
                char currentDidget = input[i];
                int indexOfFirstDidgetSameasThisDidget = input.IndexOf(currentDidget, i + 1);
                if (indexOfFirstDidgetSameasThisDidget != -1)

                {
                    string possibleCorrectSubstring = input.Substring(i, indexOfFirstDidgetSameasThisDidget - i + 1);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(input.Substring(0, i));
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(possibleCorrectSubstring);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(input.Substring(indexOfFirstDidgetSameasThisDidget + 1, input.Length - indexOfFirstDidgetSameasThisDidget - 1));
                    Console.WriteLine();
                }
                i++;
            }
        }
    }
}






        
    
