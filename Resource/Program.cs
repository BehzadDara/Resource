using Resource;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine(MessageResourceHandler.Hello);

MessageResourceHandler.ChangeLanguageToPersian();

Console.WriteLine(MessageResourceHandler.Hello);

MessageResourceHandler.ChangeLanguageToEnglish();

Console.WriteLine(MessageResourceHandler.Hello);