System.Console.WriteLine(
    System.Threading.Tasks.Task.Factory.StartNew(() =>
    {
        var filename = "something.txt";
        if (!System.IO.File.Exists(filename))
            System.IO.File.Create(filename);

        System.IO.File.WriteAllText(filename, "hello world!");
        return "This line will write hello world to something.txt from inside a task inside a console write line, this is a one line code";
    }).Result +
    $"{System.Environment.NewLine} " +
    $"{System.IO.File.ReadAllText("something.txt")}");