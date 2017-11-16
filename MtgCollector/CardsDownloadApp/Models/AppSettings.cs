using System.Configuration;

namespace CardsDownloadApp.Models
{
    public static class AppSettings
    {
        public static string MtgJsonFile => ConfigurationManager.AppSettings["mtgJsonFile"];
    }
}
