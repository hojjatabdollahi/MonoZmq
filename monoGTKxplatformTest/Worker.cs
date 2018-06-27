using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monoGTKxplatformTest
{
    class Worker
    {
//        public static bool Verbose = false;
//        public static int gestureid = 0;
//        static void Main(string[] args)
//        {
//            if (args != null && args.Length > 0)
//            {
//                foreach (string arg in args)
//                {
//                    if (arg.StartsWith("--"))
//                    {
//                        if (arg == "--verbose")
//                            Verbose = true;
//                    }
//                }
//            }
//
//            CancellationTokenSource cts = new CancellationTokenSource();
//            Console.CancelKeyPress += (s, ea) =>
//            {
//                ea.Cancel = true;
//                cts.Cancel();
//            };
//
//            using (MajordomoWorker session = new MajordomoWorker("tcp://127.0.0.1:5555", "unity", Verbose))
//            {
//                ZMessage reply = null;
//                while (true)
//                {
//                    ZMessage request = session.Recv(reply, cts);
//                    if (request == null)
//                        break; // worker was interrupted
//
//                    using (ZFrame command = request.Pop())
//                    {
//                        if (command.ToString() == "posture")
//                        {
//                            using (ZFrame param = request.Pop())
//                            {
//                                int pos = Int32.Parse(param.ToString());
//                                pos++;
//
//                                request.Clear();
//                                request.Prepend(new ZFrame(pos.ToString()));
//                                request.Prepend(new ZFrame("new posture"));
//
//                            }
//                        }
//                        else if (command.ToString() == "gesture")
//                        {
//                            request.Clear();
//                            request.Append(new ZFrame("gesture received"));
//                            request.Append(new ZFrame(gestureid++.ToString()));
//
//                        }
//                        else
//                        {
//                            request.Clear();
//                            request.Prepend(new ZFrame("UNKNOWNCMD"));
//                        }
//                    }
//
//                    reply = request; // Echo is complex
//
//
//
//                    //while (request.Count > 0) {
//                    //    ZFrame frame = request.Pop();
//                    //    try
//                    //    {
//                    //        Console.WriteLine("Msg: " + frame + "\n");
//                    //    }
//                    //    catch (Exception ex)
//                    //    {
//                    //        break;
//                    //    }
//                    //}
//                }
//            }
//        }

    }
}
