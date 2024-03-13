using otus_DelegatesEvents.ConsoleWriter;
using otus_DelegatesEvents.Extentions;
using otus_DelegatesEvents.FileSearcher;



Console.WriteLine("Part I");
StartExtention startExtention = new StartExtention();
startExtention.MaxElementFound += StartExtention_OnMaxElementFound;

startExtention.TheBestTeam();
startExtention.TheHighestMountain();


void StartExtention_OnMaxElementFound(object sender, GetMaxEventArgs e)
{
    Console.WriteLine(e.MaxMessage);
}



Console.ReadKey();
Console.Clear();
Console.WriteLine("Part II");



FileSearcher fileSearcher = new FileSearcher();
fileSearcher.FileFound += FileSearcher_FileFound;
fileSearcher.SearchStopped += FileSearcher_SearchStopped;
fileSearcher.Searching();


void FileSearcher_FileFound(object sender, FileArgs e)
{
    Console.WriteLine($"event: \"{e.FileName}\" was found");
    Console.WriteLine("Press SPACE to stop:");

    fileSearcher.IsStopSearching =  (Console.ReadKey().Key == ConsoleKey.Spacebar) ? true: false;
}

void FileSearcher_SearchStopped(object sender, EventArgs e)
{
    Console.WriteLine("Searching files in the directory was stopped");
}

Console.ReadKey();


