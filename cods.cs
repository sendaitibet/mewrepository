  static void Main()
    {
        Stopwatch sw = Stopwatch.StartNew();
        var folder = System.IO.Directory.CreateDirectory("output");
        foreach (var file in folder.GetFiles()) file.Delete();

        Random random = new();
        XDocument xdoc = XDocument.Load("samples.xml");

        foreach (XElement xelem in xdoc.Root.Elements("overlapping", "simpletiled"))
        {

           for (int i = 0; i < xelem.Get("screenshots", 2); i++)
            {
                for (int k = 0; k < 10; k++)
                {
                    Console.Write("> ");
                    int seed = random.Next();
                    bool success = model.Run(seed, xelem.Get("limit", -1));
                    if (success)
                    {
                        Console.WriteLine("DONE");
                        model.Save($"output/{name} {seed}.png");
                        if (model is SimpleTiledModel stmodel && xelem.Get("textOutput", false))
                            System.IO.File.WriteAllText($"output/{name} {seed}.txt", stmodel.TextOutput());
                        break;
                    }
//more
   static byte[] pattern(Func<int, int, byte> f, int N)
        {
            byte[] result = new byte[N * N];
            for (int y = 0; y < N; y++) for (int x = 0; x < N; x++) result[x + y * N] = f(x, y);
            return result;
