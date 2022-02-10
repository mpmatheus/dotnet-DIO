var path = @"C:\globo";
lerDiretorios(path);
Console.WriteLine("aperte [enter] para finalizar");
Console.ReadLine();

static void lerDiretorios(String path)
{
    if(Directory.Exists(path))
    {
        var diretorio = Directory.GetDirectories(path,"*", SearchOption.AllDirectories);
        foreach (var dir in diretorio)
        {
            var dirInfo = new DirectoryInfo(dir);
            Console.WriteLine($"[Nome] : {dirInfo.Name}");
            Console.WriteLine($"[Raiz] : {dirInfo.Root}");
            if (dirInfo.Parent != null)
                Console.WriteLine($"[Pai] : {dirInfo.Parent.Name}");
            Console.WriteLine("-------------------------");
        }
    }
    else
        Console.WriteLine($"{path} não encontrado");
}