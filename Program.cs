using System.Threading.Tasks;

namespace DNSInfo
{

    public class Program
    {
        public static async Task Main(string[] args)
        {
            var argumentsInfo = new ArgumentsInfo(args);
            var printer = new Printer();

            if (!argumentsInfo.IsValid())
            {
                printer.PrintInvalidArguments();
                return;
            }

            var url = argumentsInfo.GetURL();

            var loader = new DNSInfoLoader();

            var adresses = await loader.LoadAddressesAsync(printer, url);

            if (adresses.Length > 0)
            {
                printer.PrintBeginAdresses();

                foreach (var adress in adresses)
                {
                    printer.PrintAdress(adress);
                }
            }
        }
    }
}
