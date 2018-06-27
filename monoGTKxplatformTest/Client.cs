using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monoGTKxplatformTest
{
    class Client
    {
        /*public static bool Verbose = true;
        static void Main(string[] args)
        {
            if (args != null && args.Length > 0)
            {
                foreach (string arg in args)
                {
                    if (arg.StartsWith("--"))
                    {
                        if (arg == "--verbose")
                            Verbose = true;
                    }
                }
            }
            CancellationTokenSource cts = new CancellationTokenSource();
            Console.CancelKeyPress += (s, ea) =>
                {
                    ea.Cancel = true;
                    cts.Cancel();
                };

            using (MajordomoClient session = new MajordomoClient("tcp://127.0.0.1:5555", Verbose))
            {
                int count;
                for (count = 0; count < 1; count++)
                {
                    ZMessage request = new ZMessage();
                    request.Prepend(new ZFrame("2"));
                    request.Prepend(new ZFrame("posture"));
                    using (ZMessage reply = session.Send("unity", request, cts))
                        if (reply == null)
                            break; // Interrupt or failure
                }
                Console.WriteLine("{0} requests/replies processed\n", count);
            }

            Console.ReadKey();
        }*/
    }
}
