criarDiretorioGlogo();
criarArquivo();
var origem = Path.Combine(Environment.CurrentDirectory, "Brasil.txt");
var destino = Path.Combine(Environment.CurrentDirectory, "globo", "América do Sul", "Argentina", "Argentina.txt");
moverArquivo(origem, destino);
copiarArquivo(origem,destino);

static void copiarArquivo(string pathOrigin, string pathDestino)
{
    if (!File.Exists(pathOrigin))
    {
        System.Console.WriteLine("o arquivo de origem nao existe");
        return;
    }
    if (File.Exists(pathDestino))
    {
        System.Console.WriteLine("o arquivo de destino ja existe na pasta de destino");
        return;
    }
    File.Copy(pathOrigin,pathDestino);

}





static void moverArquivo(string pathOrigin, string pathDestino)
{
    if (!File.Exists(pathOrigin))
    {
        System.Console.WriteLine("o arquivo de origem nao existe");
        return;
    }
    if (File.Exists(pathDestino))
    {
        System.Console.WriteLine("o arquivo de destino ja existe na pasta de destino");
        return;
    }
    File.Move(pathOrigin, pathDestino);
}

static void criarArquivo()
{
    var path = Path.Combine(Environment.CurrentDirectory, "Brasil.txt");
    if (!File.Exists(path))
    {
        using var sw = File.CreateText(path);
        sw.WriteLine("População: 212,6 Milhões");
        sw.WriteLine("IDH:0,710");
        sw.WriteLine("Dados atualizados em: 10/02/2022");
    }
}


static void criarDiretorioGlogo()
{
    var path = Path.Combine(Environment.CurrentDirectory, "globo");
    if (!Directory.Exists(path))
    {
        var dirGlobo = Directory.CreateDirectory(path);
        var dirAMNorte = dirGlobo.CreateSubdirectory("América do Norte");
        var dirAMCentral = dirGlobo.CreateSubdirectory("América Central");
        var dirAMSul = dirGlobo.CreateSubdirectory("América do Sul");
        dirAMNorte.CreateSubdirectory("USA");
        dirAMNorte.CreateSubdirectory("Mexico");
        dirAMNorte.CreateSubdirectory("Canada");

        dirAMCentral.CreateSubdirectory("Costa Rica");
        dirAMCentral.CreateSubdirectory("Panama");

        dirAMSul.CreateSubdirectory("Brasil");
        dirAMSul.CreateSubdirectory("Argentina");
        dirAMSul.CreateSubdirectory("Paraguai");
    }

}

