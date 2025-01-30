using System.Diagnostics;

public static class AutoTDPLogger
{
    public static string appPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\GHelper";
    public static string logFile = appPath + "\\auto_tdp_log.txt";

    public static void WriteLine(string logMessage)
    {
        Debug.WriteLine(logMessage);
        if (!Directory.Exists(appPath)) Directory.CreateDirectory(appPath);

        try
        {
            using (StreamWriter w = File.AppendText(logFile))
            {
                w.WriteLine($"{DateTime.Now}: {logMessage}");
                w.Close();
            }
        }
        catch { }

        if (new Random().Next(100) == 1) Cleanup();


    }

    public static void Cleanup()
    {
        try
        {
            var file = File.ReadAllLines(logFile);
            int skip = Math.Max(0, file.Count() - 5000);
            File.WriteAllLines(logFile, file.Skip(skip).ToArray());
        }
        catch { }
    }

}
