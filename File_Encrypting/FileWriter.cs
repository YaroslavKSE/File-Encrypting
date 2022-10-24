namespace File_Encrypting;

public class FileWriter
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