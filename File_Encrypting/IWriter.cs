namespace File_Encrypting;

public interface IWriter
{
    public void Write(string? path, char[] text);
}