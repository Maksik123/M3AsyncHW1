using M3AsyncHW1.Interfaces;
using M3AsyncHW1.Services;
using System.IO;

namespace M3AsyncHW1
{
    public class Starter
    {
        public string path;
        public async void Start()
        {
            Config.ConfigureContainer();

            FileReaderService fileReader = new();

            path = @"C:\Users\Максим\source\repos\M3AsyncHW1\M3AsyncHW1\Hello.txt";
            await fileReader.ReadTextFromFileAsync(path);

            path = @"C:\Users\Максим\source\repos\M3AsyncHW1\M3AsyncHW1\World.txt";
            await fileReader.ReadTextFromFileAsync(path);

        }
    }
}