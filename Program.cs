
static void Recursive(string path)
{
    try
    {
        string[] items = Directory.GetFileSystemEntries(path);

        foreach (string item in items)
        {
            if (Directory.Exists(item))
            {
              
                Recursive(item);
            }
            else
            {
               
                Console.WriteLine(item); 
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("  error : " + ex.Message);
    }
}

string startPath = "C:\\";
try
{
    Recursive(startPath);
}
catch (Exception ex)
{
    Console.WriteLine("error: " + ex.Message);
}
