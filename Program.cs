namespace FailWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kirjuta faili läbi konsooli");

            string filePath = @"C:/Users/opilane/Desktop/WriteToFile.txt";
            string inputText = Console.ReadLine();

            File.WriteAllText(filePath, inputText);
        }
    }
}
