using CardsDownloadApp.Services;

namespace CardsDownloadApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new DownloadService();
            test.DownloadAndMerge();
        }
    }
}
