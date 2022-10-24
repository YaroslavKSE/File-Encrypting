using Caesar_Encryption_Algorithm_PPO;
using File_Encrypting;

var path = @"C:\C#\File_Encrypting\File_Encrypting\";
var caesarCipher = new Caesar();
var fileReader = new FileReader();
var text = fileReader.Read($"{path}text.txt");
caesarCipher.Print(text);
var fileWriter = new FileWriter();
fileWriter.Write($"{path}file.txt", text);