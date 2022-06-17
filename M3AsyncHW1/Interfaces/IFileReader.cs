namespace M3AsyncHW1.Interfaces
{
    public interface IFileReader
    {
        public Task ReadTextFromFileAsync(string path);
    }
}
