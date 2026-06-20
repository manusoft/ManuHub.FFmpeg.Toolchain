Console.WriteLine("Welcome to ManuHub.FFmpeg.Toolchain!\n");

string basePath = Path.Combine(AppContext.BaseDirectory, "tools");
List<string> files = new List<string> { "ffmpeg.exe", "ffprobe.exe", "ffplay.exe" };
int success = 0;

foreach (var file in files)
{
    var path = Path.Combine(basePath, file);

    if (File.Exists(path))
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Found: {file}");
        Console.ResetColor();
        success++;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Not Found: {file}");
        Console.ResetColor();
        success--;
    }
}

if (success == 3)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("\nALL DEPENDECIES ARE READY TO USE.");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("\nREBUILD THE PROJECT AND TRY AGAIN!");
    Console.ResetColor();
}
