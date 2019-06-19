using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace DNSInfo
{
    public class DNSInfoLoader
    {
        public const int LoadingTimeout = 10;

        public async Task<IPAddress[]> LoadAddressesAsync(Printer printer, string url)
        {
            try
            {
                var getHostAddressesTask = Dns.GetHostAddressesAsync(url);

                WaitForResult(printer, getHostAddressesTask);

                return await getHostAddressesTask;
            }
            catch (Exception e)
            {
                printer.PrintError(e);
                return new IPAddress[0];
            }
        }

        private static void WaitForResult(Printer printer, Task<IPAddress[]> getHostAddressesTask)
        {
            printer.PrintBeginLoading();

            while (!getHostAddressesTask.IsCompleted)
            {
                printer.PrintLoadingProgress();
                Thread.Sleep(LoadingTimeout);
            }

            printer.PrintEndBeginLoading();
        }
    }
}
