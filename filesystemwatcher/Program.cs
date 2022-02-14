var path = @"C:";
using var fsw = new FileSystemWatcher(path);
fsw.Created += onCreated;
fsw.Renamed += onRename;
fsw.Deleted += onDelete;

fsw.EnableRaisingEvents = true;
fsw.IncludeSubdirectories = true;

Console.WriteLine($"Monitorando {path}");
Console.WriteLine("Aperte [enter] para sair...");
Console.ReadLine();
void onRename(object sender, RenamedEventArgs e)
{
   Console.WriteLine($"o arquivo {e.OldName} foi alterado para{e.Name} ");
}



void onDelete(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"Foi deletado o arquivo: {e.Name}");
}


void onCreated(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"Foi criado um arquivo: {e.Name}");
}
