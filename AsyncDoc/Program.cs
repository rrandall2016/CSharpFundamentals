using System.IO;


async Task ReadFile()
{
    var lines = await File.ReadAllLinesAsync("TextFile1.txt");
    foreach (var line in lines)
    {
        Console.WriteLine(line);
    }
}
await ReadFile();
async Task<int> GetDataFromNetworkAsync()
{
    //simulate network call
    await Task.Delay(150);//await will not block cpu (While we are awaiting, go do other things, then continue)
    var result = 42;

    return result;
}
var net = await GetDataFromNetworkAsync();  