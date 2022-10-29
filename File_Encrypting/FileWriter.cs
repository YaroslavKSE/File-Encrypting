namespace File_Encrypting;

public class FileWriter : IWriter
{
    public void Write(string? path, char[] text)
    {
        if (path != null && path.EndsWith(".txt"))
        {
            using StreamWriter file = new(path, false);
            using (file)
            {
                file.Write(text);
                
            }
        }
    }
}