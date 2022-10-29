namespace File_Encrypting;

public class FileReader : IReader
{
    public char[] Read(string path)
    {
        var text = new char[] { };
        if (path.EndsWith(".txt") && File.Exists(path))
        {
            var lines = File.ReadAllText(path);
            var textArray = new char[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                textArray[i] = lines[i];
            }

            text = textArray;
        }

        return text;
    }
}