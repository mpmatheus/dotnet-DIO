
var path = Path.Combine (Environment.CurrentDirectory, "globo");
var dirGlobo = Directory.CreateDirectory(path);
var dirAMNorte = dirGlobo.CreateSubdirectory ("América do Norte");
var dirAMCentral = dirGlobo.CreateSubdirectory ("América Central");
var dirAMSul = dirGlobo.CreateSubdirectory ("América do Sul");
dirAMNorte.CreateSubdirectory("USA");
dirAMNorte.CreateSubdirectory("Mexico");
dirAMNorte.CreateSubdirectory("Canada");

dirAMCentral.CreateSubdirectory("Costa Rica");
dirAMCentral.CreateSubdirectory("Panama");

dirAMSul.CreateSubdirectory("Brasil");
dirAMSul.CreateSubdirectory("Argentina");
dirAMSul.CreateSubdirectory("Paraguai");