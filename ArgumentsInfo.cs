using System;

namespace DNSInfo
{
    public class ArgumentsInfo
    {
        private readonly string[] args;

        public ArgumentsInfo(string[] args)
        {
            this.args = args;
        }

        public bool IsValid()
        {
            return args.Length > 0;
        }

        public string GetURL()
        {
            if (!IsValid())
            {
                throw new InvalidOperationException();
            }

            return args[0];
        }
    }
}
