namespace DotnetApps.lib.Security.Interface
{
    public interface IDecryptFile
    {
        void DecryptFile(string filePath, string password);
    }
}