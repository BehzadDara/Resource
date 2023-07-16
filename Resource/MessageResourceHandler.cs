using System.Globalization;
using System.Resources;

namespace Resource
{
    public static class MessageResourceHandler
    {

        private readonly static ResourceManager rm = new("Resource.Messages", typeof(MessageResourceHandler).Assembly);

        public static void ChangeLanguageToPersian()
        {
            ChangeLanguage("fa-IR");
        }

        public static void ChangeLanguageToEnglish()
        {
            ChangeLanguage("en-US");
        }

        private static void ChangeLanguage(string language)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
        }

        public static string Hello
        {
            get
            {
                return rm.GetString(nameof(Hello)) ?? string.Empty;
            }
        }

    }

}
