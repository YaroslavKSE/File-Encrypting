using Caesar_Encryption_Algorithm_PPO;
using File_Encrypting;

const string path = @"C:\C#\File_Encrypting\File_Encrypting\";

while (true)
{
    Console.WriteLine("Enter '1' to encrypt \n" +
                      "Enter '2' to decrypt:");
    var whatToDo = Console.ReadLine();
    var caesarCypher = new Caesar();
    if (whatToDo == "1")
    {
        Console.WriteLine("Enter file name for encryption:");
        var forReading = Console.ReadLine();

        Console.WriteLine("Enter file name for saving:");
        var forWriting = Console.ReadLine();
        Console.WriteLine("Enter key:");
        var key = Console.ReadLine();

        var fileReader = new FileReader();
        var encrypted = caesarCypher.Encrypt(fileReader.Read($"{path}{forReading}"), int.Parse(key!));

        var fileWriter = new FileWriter();
        fileWriter.Write($"{path}{forWriting}", encrypted);
    }
    else
    {
        Console.WriteLine("Enter file name for decryption:");
        var forReading = Console.ReadLine();

        Console.WriteLine("Enter file name for saving:");
        var forWriting = Console.ReadLine();
        Console.WriteLine("Enter key:");
        var key = Console.ReadLine();

        var fileReader = new FileReader();
        var decrypted = caesarCypher.Decrypt(fileReader.Read($"{path}{forReading}"), int.Parse(key!));

        var fileWriter = new FileWriter();
        fileWriter.Write($"{path}{forWriting}", decrypted);
    }

    Console.WriteLine("Successful");
    Console.WriteLine("Continue? [yes/no]");
    var end = Console.ReadLine();
    if (end?.ToLower() == "no")
    {
        break;
    }
}