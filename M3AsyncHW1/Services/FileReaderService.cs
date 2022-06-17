using M3AsyncHW1.Interfaces;
using System.Text;

namespace M3AsyncHW1.Services
{
    public class FileReaderService : IFileReader
    {

        public async Task ReadTextFromFileAsync(string path)
        {
            if (File.Exists(path))
            {
                using (FileStream fileStream = File.OpenRead(path))
                {
                    byte[] buffer = new byte[fileStream.Length];
                    await fileStream.ReadAsync(buffer, 0, buffer.Length);
                    string text = Encoding.Default.GetString(buffer);
                    Console.WriteLine(text);
                }
            }
            else
            {
                Console.WriteLine("Wrong Path");
            }
        }
    }
}
