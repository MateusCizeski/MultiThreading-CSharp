class Program
{
    static void Main(string[] args)
    {
        var thread1 = new Thread(ProcessoA);
        var thread2 = new Thread(ProcessoB);

        thread1.Start();
        thread2.Start();

        Console.ReadLine();
    }

    public static void ProcessoA()
    {
        var items = new String[10] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };

        for(int i = 0; i < items.Length; i++)
        {
            Console.WriteLine("Processo A => " + items[i]);
            if(i == 5)
            {
                Thread.Sleep(2000);
            }
        }
    }
    
    public static void ProcessoB()
    {
        var items = new String[10] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };

        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine("Processo B => " + items[i]);
        }
    }
}