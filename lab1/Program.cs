
  

class Program {
    public static void Main(String[] args) {
        const int n = 12;
        Random rand = new Random();
        RomanNumber[] b = new RomanNumber[n];
        for (int i = 0; i < n; i++)
        {
            ushort x = (ushort)(rand.NextDouble() * 2000);
            b[i] = new RomanNumber(x);
            Console.WriteLine(b[i].ToString() + " " + x);
        }

        Array.Sort<RomanNumber>(b);
        Console.WriteLine();

        foreach (RomanNumber r in b)
        {
            Console.WriteLine(r.ToString());
        }
    }
}