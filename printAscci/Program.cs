internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите строку");
        string line = Console.ReadLine();
        int n = 0;
        string asciiArray = "";
        for (int i = 0; i < 256; i++)
        {
            if (i >= 0 && i <= 47 || i >= 58 && i <= 64 || i >= 91 && i <= 96 || i >= 123 && i <= 191)
            {
                char c = (char)i;
                asciiArray = asciiArray + Convert.ToString(c);
            }
        }
        for (int i = 0; i < line.Length; i++)
        {
            for (int j = 0; j < asciiArray.Length; j++)
            {
                if (line[i] == asciiArray[j])
                {
                    Console.WriteLine(asciiArray[j]);
                    n++;
                }
            }
        }
        Console.WriteLine(n);
    }
}