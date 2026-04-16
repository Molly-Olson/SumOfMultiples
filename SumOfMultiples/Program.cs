namespace SumOfMultiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("   ___    _         _                                           _             __  __      _      _____   _   _ \r\n  / _ \\  | |__     | |__     ___    __      __   __ _   _ __   | |_   ___    |  \\/  |    / \\    |_   _| | | | |\r\n | | | | | '_ \\    | '_ \\   / _ \\   \\ \\ /\\ / /  / _` | | '_ \\  | __| / __|   | |\\/| |   / _ \\     | |   | |_| |\r\n | |_| | | | | |   | | | | |  __/    \\ V  V /  | (_| | | | | | | |_  \\__ \\   | |  | |  / ___ \\    | |   |  _  |\r\n  \\___/  |_| |_|   |_| |_|  \\___|     \\_/\\_/    \\__,_| |_| |_|  \\__| |___/   |_|  |_| /_/   \\_\\   |_|   |_| |_|\r\n                                                                                                               ");
            Console.WriteLine("                                   _                          _              ___ \r\n  _ __     ___   __      __     __| |   ___     ___   ___    | |__     ___  |__ \\\r\n | '_ \\   / _ \\  \\ \\ /\\ / /    / _` |  / _ \\   / _ \\ / __|   | '_ \\   / _ \\   / /\r\n | | | | | (_) |  \\ V  V /    | (_| | | (_) | |  __/ \\__ \\   | | | | |  __/  |_| \r\n |_| |_|  \\___/    \\_/\\_/      \\__,_|  \\___/   \\___| |___/   |_| |_|  \\___|  (_) \r\n                                                                                 ");
            Console.WriteLine("Hello, Proffessor Evil... I thank you for the invite to do math AND computer programming all at once!! ");
            Console.WriteLine("I hope you remember to always keep the sound on your machine! :)");
            Console.WriteLine("");

            int limit = 1000;
            int sum = 0;
            for (int i = 1; i < limit; i++)
            {
                if (i % 3 == 0 || i % 5 == 0) sum += i;
            }
            Console.WriteLine(sum);

            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            var list = new List<int>();
            for (int i = 1; i <100; i ++)
            {
                if (i % 3 == 0 || i % 5 == 0) list.Add(i);
            }
            Console.WriteLine(string.Join(",", list));
            Console.WriteLine("");
            Console.WriteLine("Scroll up sucka! The answer is there!!!!");
            Console.WriteLine("I think at least lol, ok this is kinda fun playing around and feeling like I know what i is doing finally!");
            Console.WriteLine("");

            Console.BufferHeight = 300; 
            Console.WindowHeight = 30;
            Console.SetWindowPosition(0, 0);
            // well that didn't work did it? Hmmm....
        }
    }
}
