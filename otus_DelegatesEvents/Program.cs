using otus_DelegatesEvents.ConsoleWriter;
using otus_DelegatesEvents.Extensions;
using otus_DelegatesEvents.FileSearcher;

//TestsExtention tests = new TestsExtention();

//Console.WriteLine(tests.TheBestTeam());
//Console.WriteLine(tests.TheHighestMountain());



FileSearcher fileSearcher = new FileSearcher();
fileSearcher.FileFound += FileSearcher_FileFound;
fileSearcher.SearchStoped += FileSearcher_SearchStoped;
fileSearcher.JSGHD();




void FileSearcher_FileFound(object sender, FileArgs e)
{
    Console.WriteLine($"File: \"{e.FileName}\" was found");
    Console.WriteLine("Press SPACE to stop:");

     e.isStopSearching =  (Console.ReadKey().Key == ConsoleKey.Spacebar) ? true: false;
}

void FileSearcher_SearchStoped(object sender, EventArgs e)
{
    Console.WriteLine("Searching files in the directory was stopped");
}

Console.ReadKey();


