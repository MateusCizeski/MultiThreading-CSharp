class Program
{
    static void Main(string[] args)
    {
        //var thread1 = new Thread(ProcessoA);
        //var thread2 = new Thread(ProcessoB);

        //thread1.Start();
        //thread2.Start();

        Thread t = new Thread(new ThreadStart(MeuMetodo));
        t.Priority = ThreadPriority.Normal; //Prioridade padrão
        t.Start();
        
        Thread t1 = new Thread(new ThreadStart(MeuMetodo));
        t1.Priority = ThreadPriority.Lowest; //Prioridade baixa
        t1.Start();

        Thread t2 = new Thread(new ThreadStart(MeuMetodo1));
        t2.Priority = ThreadPriority.Highest; //Prioridade alta
        t2.Start();

        int valor = 3;
        Thread t3 = new Thread(new ParameterizedThreadStart(MeuMetodoP));
        t3.IsBackground = true;
        t3.Start(valor);

        Console.ReadLine();
    }

    public static void MeuMetodo()
    {
        for(int i = 0; i <= 20; i++)
        {
            Console.WriteLine("ThreadProc {0}", i);
            Thread.Sleep(1000);
        }
    }    
    
    public static void MeuMetodo1()
    {
        for(int i = 0; i <= 20; i++)
        {
            Console.WriteLine("ThreadProc prioridade alta {0}", i);
            Thread.Sleep(1000);
        }
    }

    public static void MeuMetodoP(object a)
    {
        for (int i = 0; i <= 20; i++)
        {
            Console.WriteLine("valor do parametro a: {0}", a);
            Thread.Sleep(1000);
        }
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