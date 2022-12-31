string folderPath = @"C:\data";
string fileName = "chuck.txt";
string[] lines = File.ReadAllLines(Path.Combine(folderPath, fileName));

ShowFileContent(lines);

static void ShowFileContent(string[] fileContentArray)
{
    int i = 1;
    foreach(string line in fileContentArray)
    {
        Console.WriteLine($"{i}. {ShowFileContent}");
        i++;
    }
}